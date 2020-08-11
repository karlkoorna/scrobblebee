﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin {
	
	class Settings {
		
		private static readonly MetaDataType[] Tags = new MetaDataType[] { MetaDataType.Virtual1, MetaDataType.Virtual2, MetaDataType.Virtual3, MetaDataType.Virtual4, MetaDataType.Virtual5, MetaDataType.Virtual6, MetaDataType.Virtual7, MetaDataType.Virtual8, MetaDataType.Virtual9, MetaDataType.Virtual10, MetaDataType.Virtual11, MetaDataType.Virtual12, MetaDataType.Virtual13, MetaDataType.Virtual14, MetaDataType.Virtual15, MetaDataType.Virtual16 };
		private static readonly byte[] Entropy = Encoding.UTF8.GetBytes("U2Nyb2JibGVCZWU=");

		private static string Path = "";

		public static string Key = "";
		public static string Secret = "";
		public static string Session = "";

		private static string EncryptString(string str) {
			return Convert.ToBase64String(ProtectedData.Protect(Encoding.UTF8.GetBytes(str), Entropy, DataProtectionScope.CurrentUser));
		}

		private static string DecryptString(string str) {
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(str), Entropy, DataProtectionScope.CurrentUser));
		}

		public static void Load(string path) {
			Path = path;
			if (!File.Exists(path)) return;

			string[] lines = File.ReadAllLines(path, Encoding.UTF8);
			Key = DecryptString(lines[0]);
			Secret = DecryptString(lines[1]);
			Session = DecryptString(lines[2]);
		}

		public static void Save() {
			File.WriteAllLines(Path, new string[] {
				EncryptString(Key),
				EncryptString(Secret),
				EncryptString(Session)
			}, Encoding.UTF8);
		}

		public static void Delete() {
			File.Delete(Path);
		}

		public static MetaDataType GetTag(string name, MetaDataType defaultTag) {
			MetaDataType tag = Array.Find(Tags, _tag => Api.Setting_GetFieldName(_tag) == name);
			return tag == 0 ? defaultTag : tag;
		}

	}

}
