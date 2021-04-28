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
using System.Windows.Forms;
using Parameter = System.Collections.Generic.KeyValuePair<string, string>;

namespace MusicBeePlugin {

	class LastFm {

		public enum ResponseType {
			Net = -1,
			Ok = 0,
			Auth = 4,
			Values = 6,
			Key = 10,
			Secret = 13
		}

		public class Response {

			public readonly ResponseType Type = 0;
			public readonly string Data = "";

			public Response(ResponseType type, string data) {
				Type = type;
				Data = data;
			}

			public Response(ResponseType type) {
				Type = type;
			}

			public Response(string data) {
				Data = data;
			}

		}

		private static readonly WebProxy proxy = new WebProxy() { BypassProxyOnLocal = false };

		private static readonly HttpClient http = new HttpClient(new HttpClientHandler() {
			Proxy = proxy,
			UseProxy = true
		});

		private static string key;
		private static string secret;
		private static string session;

		private static async Task<Response> Execute(string method, List<Parameter> parameters) {
			parameters.Add(new Parameter("method", method));
			parameters.Add(new Parameter("api_key", key));
			parameters.Add(new Parameter("api_sig", string.Concat(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(parameters.OrderBy(parameter => parameter.Key).Aggregate("", (string str, KeyValuePair<string, string> parameter) => str + parameter.Key + parameter.Value) + secret)).Select(hash => hash.ToString("X2")))));
			parameters.Sort((prev, next) => string.Compare(prev.Key, next.Key, StringComparison.Ordinal));

			var address = Api.Setting_GetWebProxy();
			if (address != null) proxy.Address = new Uri(address);

			try {
				var res = await (await http.PostAsync("https://ws.audioscrobbler.com/2.0/", new FormUrlEncodedContent(parameters))).Content.ReadAsStringAsync();
				if (res.Contains("status=\"failed\"")) {
					var match = new Regex("<error code=\"(\\d+)\">(.+)</error>").Match(res);
					return new Response((ResponseType) int.Parse(match.Groups[1].Value), match.Groups[2].Value);
				}

				return new Response(res);
			} catch {
				return new Response(ResponseType.Net);
			}
		}

		public static async Task<Response> Login(string key, string secret, string username, string password) {
			LastFm.key = key;
			LastFm.secret = secret;

			var res = await Execute("auth.getMobileSession", new List<Parameter>() {
				new Parameter("username", username),
				new Parameter("password", password)
			});

			return res.Type == ResponseType.Ok ? new Response(session = new Regex("<key>(.+?)</key>").Match(res.Data).Groups[1].Value) : res;
		}

		public static void Login(string key, string secret, string session) {
			LastFm.key = key;
			LastFm.session = session;
			LastFm.secret = secret;
		}

		public static void Update(string track, string artist, string album, string albumArtist, int duration) {
			if (session != null)
				_ = Execute("track.updateNowPlaying", new List<Parameter>() {
					new Parameter("sk", session),
					new Parameter("track", track),
					new Parameter("artist", artist),
					new Parameter("album", album),
					new Parameter("album_artist", albumArtist),
					new Parameter("duration", (duration / 1000).ToString())
				});
		}

		public static async void Scrobble(string track, string artist, string album, string albumArtist, int duration) {
			if (session == null) return;

			var res = await Execute("track.scrobble", new List<Parameter>() {
				new Parameter("sk", session),
				new Parameter("track[0]", track),
				new Parameter("artist[0]", artist),
				new Parameter("album[0]", album),
				new Parameter("album_artist[0]", albumArtist),
				new Parameter("duration[0]", (duration / 1000).ToString()),
				new Parameter("timestamp[0]", ((int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds).ToString())
			});

			if (res.Type != ResponseType.Ok) MessageBox.Show("Failed to scrobble!\n(" + res.Data + ")", "ScrobbleBee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

	}

}
