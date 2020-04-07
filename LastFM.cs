using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin {

	class LastFM {
		
		public class Response {

			public readonly int Code = 0;
			public readonly string Data = "";

			public Response(int code, string data) {
				Code = code;
				Data = data;
			}

			public Response(string data) {
				Data = data;
			}

			public Response(int code) {
				Code = code;
			}

		}

		private static readonly WebProxy Proxy = new WebProxy() {
			BypassProxyOnLocal = false
		};

		private static readonly HttpClient Http = new HttpClient(new HttpClientHandler() {
			Proxy = Proxy,
			UseProxy = true
		}) {
			BaseAddress = new Uri("https://ws.audioscrobbler.com/2.0/")
		};

		private static string Key;
		private static string Secret;
		private static string Session;

		private static async Task<Response> Execute(string method, List<KeyValuePair<string, string>> content) {
			content.Add(new KeyValuePair<string, string>("method", method));
			content.Add(new KeyValuePair<string, string>("api_key", Key));
			content.Add(new KeyValuePair<string, string>("api_sig", string.Concat(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(content.OrderBy(pair => pair.Key).Aggregate("", (string str, KeyValuePair<string, string> pair) => str + pair.Key + pair.Value) + Secret)).Select(b => b.ToString("X2")))));
			content.Sort((prev, next) => prev.Key.CompareTo(next.Key));

			string proxy = Api.Setting_GetWebProxy();
			Proxy.Address = proxy == null ? null : new Uri(proxy);
			string res = await (await Http.PostAsync("", new FormUrlEncodedContent(content))).Content.ReadAsStringAsync();

			if (res.Contains("status=\"failed\"")) {
				Match match = new Regex("<error code=\"(\\d+)\">(.+)</error>").Match(res);
				return new Response(int.Parse(match.Groups[1].Value), match.Groups[2].Value);
			}

			return new Response(res);
		}

		public static async Task<Response> Login(string key, string secret, string username, string password) {
			Key = key;
			Secret = secret;

			Response res = await Execute("auth.getMobileSession", new List<KeyValuePair<string, string>>() {
				new KeyValuePair<string, string>("username", username),
				new KeyValuePair<string, string>("password", password)
			});

			return res.Code == 0 ? new Response(Session = new Regex("<key>(.+?)</key>").Match(res.Data).Groups[1].Value) : res;
		}

		public static void Login(string key, string secret, string session) {
			Key = key;
			Session = session;
			Secret = secret;
		}

		public static void Update(string track, string artist, string album, string duration) {
			if (Session != null) _ = Execute("track.updateNowPlaying", new List<KeyValuePair<string, string>>() {
				new KeyValuePair<string, string>("sk", Session),
				new KeyValuePair<string, string>("track", track),
				new KeyValuePair<string, string>("artist", artist),
				new KeyValuePair<string, string>("album", album),
				new KeyValuePair<string, string>("duration", duration)
			});
		}

		public static void Scrobble(string track, string artist, string album, string duration) {
			if (Session != null) _ = Execute("track.scrobble", new List<KeyValuePair<string, string>>() {
				new KeyValuePair<string, string>("sk", Session),
				new KeyValuePair<string, string>("track[0]", track),
				new KeyValuePair<string, string>("artist[0]", artist),
				new KeyValuePair<string, string>("album[0]", album),
				new KeyValuePair<string, string>("duration[0]", duration),
				new KeyValuePair<string, string>("timestamp[0]", ((int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds).ToString())
			});
		}

	}

}
