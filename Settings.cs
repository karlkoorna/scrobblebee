using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin {
	
	class Settings {
		
		public static MetaDataType[] Tags = new MetaDataType[] { MetaDataType.Virtual1, MetaDataType.Virtual2, MetaDataType.Virtual3, MetaDataType.Virtual4, MetaDataType.Virtual5, MetaDataType.Virtual6, MetaDataType.Virtual7, MetaDataType.Virtual8, MetaDataType.Virtual9, MetaDataType.Virtual10, MetaDataType.Virtual11, MetaDataType.Virtual12, MetaDataType.Virtual13, MetaDataType.Virtual14, MetaDataType.Virtual15, MetaDataType.Virtual16 };

		private static readonly byte[] Entropy = Encoding.UTF8.GetBytes("U2Nyb2JibGVCZWU=");
		private static string path = "";

		public static string Key = "";
		public static string Secret = "";
		public static string Session = "";

		private static MetaDataType title = MetaDataType.TrackTitle;
		private static MetaDataType artist = MetaDataType.Artist;
		private static MetaDataType album = MetaDataType.Album;

		public static MetaDataType Title {
			get => GetTag(ref title, MetaDataType.TrackTitle);
			set => title = value;
		}
		
		public static MetaDataType Artist {
			get => GetTag(ref artist, MetaDataType.Artist);
			set => artist = value;
		}

		public static MetaDataType Album {
			get => GetTag(ref album, MetaDataType.Album);
			set => album = value;
		}

		private static string EncryptString(string str) {
			return Convert.ToBase64String(ProtectedData.Protect(Encoding.ASCII.GetBytes(str), Entropy, DataProtectionScope.CurrentUser));
		}

		private static string DecryptString(string str) {
			return Encoding.ASCII.GetString(ProtectedData.Unprotect(Convert.FromBase64String(str), Entropy, DataProtectionScope.CurrentUser));
		}

		public static bool IsTag(MetaDataType tag) {
			return (Api.NowPlaying_GetFileTag(tag) ?? "").Trim().Length > 0 || (Api.Pending_GetFileTag(tag) ?? "").Trim().Length > 0;
		}

		private static MetaDataType GetTag(ref MetaDataType tag, MetaDataType defaultTag) {
			if (!IsTag(tag)) tag = defaultTag;
			return tag;
		}

		public static void Load(string path) {
			Settings.path = path;
			if (!File.Exists(path)) return;

			string[] lines = File.ReadAllLines(path, Encoding.ASCII);
			Key = DecryptString(lines[0]);
			Secret = DecryptString(lines[1]);
			Session = DecryptString(lines[2]);
			Title = (MetaDataType) Enum.Parse(typeof(MetaDataType), lines[3]);
			Artist = (MetaDataType) Enum.Parse(typeof(MetaDataType), lines[4]);
			Album = (MetaDataType) Enum.Parse(typeof(MetaDataType), lines[5]);
		}

		public static void Save() {
			File.WriteAllLines(path, new string[] {
				EncryptString(Key),
				EncryptString(Secret),
				EncryptString(Session),
				Title.ToString(),
				Artist.ToString(),
				Album.ToString()
			}, Encoding.ASCII);
		}

		public static void Delete() {
			File.Delete(path);
		}

	}

}
