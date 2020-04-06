using System;
using System.IO;

namespace MusicBeePlugin {
	
	public partial class Plugin {
		
		public static MusicBeeApiInterface Api;

		private bool hasScrobbled = false;
		private DateTime started;
		private int played = 0;

		private string lastTitle;
		private string lastArtist;
		private string lastAlbum;
		private int lastDuration;

		private void TryScrobble(string title, string artist, string album, int duration) {
			if (hasScrobbled) return;

			played += (int) DateTime.UtcNow.Subtract(started).TotalMilliseconds;
			if (played < Api.NowPlaying_GetDuration() / 2 && played < 240000) return;
			hasScrobbled = true;
			played = 0;

			LastFM.Scrobble(title, artist, album, (duration / 1000).ToString());
		}

		public static PluginInfo Initialise(IntPtr ApiPtr) {
			Api = new MusicBeeApiInterface();
			Api.Initialise(ApiPtr);
			
			Settings.Load(Path.Combine(Api.Setting_GetPersistentStoragePath(), "ScrobbleBee.ini"));
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
				ReceiveNotifications = ReceiveNotificationFlags.PlayerEvents,
				ConfigurationPanelHeight = 0
			};
		}

		public static bool Configure(IntPtr panelPtr) {
			new FormConfigure().ShowDialog();
			return true;
		}

		public static void Uninstall() {
			Settings.Delete();
		}

		public void ReceiveNotification(string src, NotificationType type) {
			if (type != NotificationType.TrackChanged && type != NotificationType.PlayStateChanged) return;
			
			string title = Api.NowPlaying_GetFileTag(Settings.Title);
			string artist = Api.NowPlaying_GetFileTag(Settings.Artist);
			string album = Api.NowPlaying_GetFileTag(Settings.Album);
			int duration = Api.NowPlaying_GetDuration();

			switch (type) {
				case NotificationType.TrackChanged:
					TryScrobble(lastTitle, lastArtist, lastAlbum, lastDuration);
					LastFM.Update(title, artist, album, (duration / 1000).ToString());
					
					hasScrobbled = duration < 30000;
					started = DateTime.UtcNow;
					played = 0;

					lastTitle = title;
					lastArtist = artist;
					lastAlbum = album;
					lastDuration = duration;
					break;
				case NotificationType.PlayStateChanged:
					switch (Api.Player_GetPlayState()) {
						case PlayState.Playing:
							started = DateTime.UtcNow;
							break;
						case PlayState.Paused:
						case PlayState.Stopped:
							TryScrobble(title, artist, album, duration);
							break;
					}
					break;
			}
		}

	}

}
