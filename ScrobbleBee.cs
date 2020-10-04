using System;
using System.IO;

namespace MusicBeePlugin {
	
	public partial class Plugin {
		
		public static MusicBeeApiInterface Api;

		private bool hasScrobbled = false;
		private DateTime started = DateTime.MinValue;
		private int played = 0;

		private string lastTitle = "";
		private string lastArtist = "";
		private string lastAlbum = "";
		private string lastAlbumArtist = "";
		private int lastDuration = 0;

		public static PluginInfo Initialise(IntPtr ApiPtr) {
			Api = new MusicBeeApiInterface();
			Api.Initialise(ApiPtr);
			Api.Player_SetScrobbleEnabled(false);

			Settings.Load(Path.Combine(Api.Setting_GetPersistentStoragePath(), "Plugins/MB_ScrobbleBee.ini"));
			LastFM.Login(Settings.Key, Settings.Secret, Settings.Session);
			
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

		public static bool Configure(IntPtr panelPtr) {
			new FormConfigure().ShowDialog();
			return true;
		}

		public static void Uninstall() {
			Api.Player_SetScrobbleEnabled(true);
			Settings.Delete();
		}

		public void ReceiveNotification(string src, NotificationType type) {
			if (type == NotificationType.PlayerScrobbleChanged) {
				if (Api.Player_GetScrobbleEnabled()) Api.Player_SetScrobbleEnabled(false);
				return;
			}
			
			if (type != NotificationType.TrackChanged && type != NotificationType.PlayStateChanged) return;

			string title = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-Title", MetaDataType.TrackTitle));
			string artist = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-Artist", MetaDataType.Artist));
			string album = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-Album", MetaDataType.Album));
			string albumArtist = Api.NowPlaying_GetFileTag(Settings.GetTag("ScrobbleBee-AlbumArtist", MetaDataType.AlbumArtist));
			int duration = Api.NowPlaying_GetDuration();

			switch (type) {
				case NotificationType.TrackChanged:
					TryScrobble(lastTitle, lastArtist, lastAlbum, lastAlbumArtist, lastDuration);
					_ = LastFM.Update(title, artist, album, albumArtist, duration);
					
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

			LastFM.Scrobble(title, artist, album, albumArtist, duration);
		}

	}

}
