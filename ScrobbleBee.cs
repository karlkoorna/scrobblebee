using System;

namespace MusicBeePlugin {

	public partial class Plugin {

		internal static MusicBeeApiInterface Api;

		private bool hasScrobbled = false;
		private DateTime started = DateTime.MinValue;
		private int played = 0;

		private string lastTitle = "";
		private string lastArtist = "";
		private string lastAlbum = "";
		private string lastAlbumArtist = "";
		private int lastDuration = 0;

		public PluginInfo Initialise(IntPtr apiPtr) {
			Api = new MusicBeeApiInterface();
			Api.Initialise(apiPtr);
			Api.Player_SetScrobbleEnabled(false);

			Settings.Load();
			LastFm.Login(Settings.Key, Settings.Secret, Settings.Session);

			return new PluginInfo {
				Type = PluginType.General,
				Name = "ScrobbleBee",
				Description = "Customizable scrobbling for MusicBee.",
				Author = "Karl Köörna",
				VersionMajor = 1,
				VersionMinor = 0,
				Revision = 1,
				PluginInfoVersion = PluginInfoVersion,
				MinInterfaceVersion = MinInterfaceVersion,
				MinApiRevision = MinApiRevision,
				ReceiveNotifications = ReceiveNotificationFlags.PlayerEvents | ReceiveNotificationFlags.TagEvents,
				ConfigurationPanelHeight = 0
			};
		}

		public bool Configure(IntPtr panelPtr) {
			new FormConfigure().ShowDialog();
			return true;
		}

		public void Uninstall() {
			Api.Player_SetScrobbleEnabled(true);
			Settings.Delete();
		}

		public void ReceiveNotification(string src, NotificationType type) {
			if (type == NotificationType.PlayerScrobbleChanged) {
				if (Api.Player_GetScrobbleEnabled()) Api.Player_SetScrobbleEnabled(false);
				return;
			}

			if (type != NotificationType.TrackChanged && type != NotificationType.PlayStateChanged) return;

			var title = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-Title", MetaDataType.TrackTitle));
			var artist = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-Artist", MetaDataType.Artist));
			var album = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-Album", MetaDataType.Album));
			var albumArtist = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-AlbumArtist", MetaDataType.AlbumArtist));
			var duration = Api.NowPlaying_GetDuration();

			switch (type) {
				case NotificationType.TrackChanged:
					TryScrobble(lastTitle, lastArtist, lastAlbum, lastAlbumArtist, lastDuration);
					LastFm.Update(title, artist, album, albumArtist, duration);

					hasScrobbled = duration < 30000;
					started = DateTime.UtcNow;
					played = 0;

					lastTitle = title;
					lastArtist = artist;
					lastAlbum = album;
					lastAlbumArtist = albumArtist;
					lastDuration = duration;
					break;
				case NotificationType.PlayStateChanged:
					switch (Api.Player_GetPlayState()) {
						case PlayState.Playing:
							started = DateTime.UtcNow;
							break;
						case PlayState.Paused:
						case PlayState.Stopped:
							TryScrobble(title, artist, album, albumArtist, duration);
							break;
					}
					break;
			}
		}

		private void TryScrobble(string title, string artist, string album, string albumArtist, int duration) {
			if (hasScrobbled) return;
			if (duration == -1) return;

			played += (int) DateTime.UtcNow.Subtract(started).TotalMilliseconds;
			if (played < duration / 2 && played < 240000) return;
			hasScrobbled = true;

			LastFm.Scrobble(title, artist, album, albumArtist, duration);
		}

	}

}
