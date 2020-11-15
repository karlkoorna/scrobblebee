using System;
using System.Drawing;
using System.Windows.Forms;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin {
	
	partial class FormConfigure : Form {

		public FormConfigure() {
			InitializeComponent();
			
			TextBoxKey.Text = Settings.Key;
			TextBoxSecret.Text = Settings.Secret;

			if (Settings.GetTag("ScrobbleBee-Title", MetaDataType.TrackTitle) != MetaDataType.TrackTitle) LabelTitle.BackColor = Color.DarkSeaGreen;
			if (Settings.GetTag("ScrobbleBee-Artist", MetaDataType.Artist) != MetaDataType.Artist) LabelArtist.BackColor = Color.DarkSeaGreen;
			if (Settings.GetTag("ScrobbleBee-Album", MetaDataType.Album) != MetaDataType.Album) LabelAlbum.BackColor = Color.DarkSeaGreen;
			if (Settings.GetTag("ScrobbleBee-AlbumArtist", MetaDataType.AlbumArtist) != MetaDataType.AlbumArtist) LabelAlbumArtist.BackColor = Color.DarkSeaGreen;
		}

		private void TextBox_MouseEnter(object sender, EventArgs e) {
			((TextBox) sender).UseSystemPasswordChar = false;
		}

		private void TextBox_MouseLeave(object sender, EventArgs e) {
			((TextBox) sender).UseSystemPasswordChar = true;
		}

		private async void ButtonSubmit_Click(object sender, EventArgs e) {
			var res = await LastFm.Login(TextBoxKey.Text, TextBoxSecret.Text, TextBoxUsername.Text, TextBoxPassword.Text);
			
			string msg = null;
			switch (res.Code) {
				case LastFm.ApiCode.Auth:
					msg = "Login failed!";
					break;
				case LastFm.ApiCode.Values:
					msg = "Missing values!";
					break;
				case LastFm.ApiCode.Key:
					msg = "Invalid key!";
					break;
				case LastFm.ApiCode.Secret:
					msg = "Invalid secret!";
					break;
			}
			
			if (msg != null) {
				MessageBox.Show(msg, "ScrobbleBee", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Settings.Session = res.Data;
			Settings.Key = TextBoxKey.Text;
			Settings.Secret = TextBoxSecret.Text;
			Settings.Save();
			Close();
		}

	}

}
