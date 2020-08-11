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

	class LastFM {

		public enum ApiCode {
			Ok = 0,
			Auth = 4,
			Values = 6,
			Key = 10,
			Secret = 13
		}

		public class Response {

			public readonly ApiCode Code = 0;
			public readonly string Data = "";

			public Response(ApiCode code, string data) {
				Code = code;
				Data = data;
			}

			public Response(ApiCode code) {
				Code = code;
			}

			public Response(string data) {
				Data = data;
			}

		}

		private static readonly WebProxy Proxy = new WebProxy() { BypassProxyOnLocal = false };
		private static readonly HttpClient Http = new HttpClient(new HttpClientHandler() {
			Proxy = Proxy,
			UseProxy = true
		});

		private static string Key;
		private static string Secret;
		private static string Session;

		private static async Task<Response> Execute(string method, List<Parameter> parameters) {
			parameters.Add(new Parameter("method", method));
			parameters.Add(new Parameter("api_key", Key));
			parameters.Add(new Parameter("api_sig", string.Concat(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(parameters.OrderBy(parameter => parameter.Key).Aggregate("", (string str, KeyValuePair<string, string> parameter) => str + parameter.Key + parameter.Value) + Secret)).Select(hash => hash.ToString("X2")))));
			parameters.Sort((prev, next) => prev.Key.CompareTo(next.Key));

			string address = Api.Setting_GetWebProxy();
			Proxy.Address = address == null ? null : new Uri(address);
			
			string res = await (await Http.PostAsync("https://ws.audioscrobbler.com/2.0/", new FormUrlEncodedContent(parameters))).Content.ReadAsStringAsync();
			if (res.Contains("status=\"failed\"")) {
				Match match = new Regex("<error code=\"(\\d+)\">(.+)</error>").Match(res);
				return new Response((ApiCode) int.Parse(match.Groups[1].Value), match.Groups[2].Value);
			}

			return new Response(res);
		}

		public static async Task<Response> Login(string key, string secret, string username, string password) {
			Key = key;
			Secret = secret;

			Response res = await Execute("auth.getMobileSession", new List<Parameter>() {
				new Parameter("username", username),
				new Parameter("password", password)
			});
			
			return res.Code == ApiCode.Ok ? new Response(Session = new Regex("<key>(.+?)</key>").Match(res.Data).Groups[1].Value) : res;
		}

		public static void Login(string key, string secret, string session) {
			Key = key;
			Session = session;
			Secret = secret;
		}

		public static async Task Update(string track, string artist, string album, string albumArtist, int duration) {
			if (Session != null) _ = Execute("track.updateNowPlaying", new List<Parameter>() {
				new Parameter("sk", Session),
				new Parameter("track", track),
				new Parameter("artist", artist),
				new Parameter("album", album),
				new Parameter("album_artist", albumArtist),
				new Parameter("duration", (duration / 1000).ToString())
			});
		}

		public static async void Scrobble(string track, string artist, string album, string albumArtist, int duration) {
			if (Session == null) return;

			Response res = await Execute("track.scrobble", new List<Parameter>() {
				new Parameter("sk", Session),
				new Parameter("track[0]", track),
				new Parameter("artist[0]", artist),
				new Parameter("album[0]", album),
				new Parameter("album_artist[0]", albumArtist),
				new Parameter("duration[0]", (duration / 1000).ToString()),
				new Parameter("timestamp[0]", ((int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds).ToString())
			});

			if (res.Code != ApiCode.Ok) MessageBox.Show("Failed to scrobble!\n(" + res.Data + ")", "ScrobbleBee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

	}

}
