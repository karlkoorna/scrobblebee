using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin {
	
	partial class FormConfigure : Form {
		
		private class ComboBoxItem {
			
			public string Text { get; set; }
			public MetaDataType Value { get; set; }

			public ComboBoxItem(MetaDataType value, string text) {
				Text = text;
				Value = value;
			}
			
		}

		private bool shouldLogin = false;

		public FormConfigure() {
			InitializeComponent();

			List<ComboBoxItem> tags = new List<ComboBoxItem>();
			foreach (MetaDataType tag in Settings.Tags) if (Settings.IsTag(tag)) tags.Add(new ComboBoxItem(tag, Api.Setting_GetFieldName(tag)));
			
			List<ComboBoxItem> titleTags = new List<ComboBoxItem>() { new ComboBoxItem(MetaDataType.TrackTitle, "Title"), new ComboBoxItem(MetaDataType.TrackTitle, "") };
			titleTags.AddRange(tags);
			ComboBoxTitle.DataSource = titleTags;

			List<ComboBoxItem> artistTags = new List<ComboBoxItem>() { new ComboBoxItem(MetaDataType.Artist, "Artist"), new ComboBoxItem(MetaDataType.Artist, "") };
			artistTags.AddRange(tags);
			ComboBoxArtist.DataSource = artistTags;

			List<ComboBoxItem> albumTags = new List<ComboBoxItem>() { new ComboBoxItem(MetaDataType.Album, "Album"), new ComboBoxItem(MetaDataType.Album, "") };
			albumTags.AddRange(tags);
			ComboBoxAlbum.DataSource = albumTags;

			TextBoxKey.Text = Settings.Key;
			TextBoxSecret.Text = Settings.Secret;
			ComboBoxTitle.SelectedValue = Settings.Title;
			ComboBoxArtist.SelectedValue = Settings.Artist;
			ComboBoxAlbum.SelectedValue = Settings.Album;
		}

		// Require login when Last.fm data is changed.
		private void TextBox_TextChanged(object sender, EventArgs e) {
			TextBox textBox = (TextBox) sender;
			
			string value = "";
			if (textBox.Name == "TextBoxKey") value = Settings.Key;
			else if (textBox.Name == "TextBoxSecret") value = Settings.Secret;

			ButtonSubmit.Text = (shouldLogin = textBox.Text != value) ? "Login" : "Save";
		}

		// Make separator item not selectable.
		private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e) {
			ComboBox comboBox = (ComboBox) sender;
			if (comboBox.SelectedIndex == 1) comboBox.SelectedIndex = 0;
		}

		// Reveal sensitive fields.
		private void TextBox_MouseEnter(object sender, EventArgs e) {
			((TextBox) sender).UseSystemPasswordChar = false;
		}

		// Hide sensitive fields.
		private void TextBox_MouseLeave(object sender, EventArgs e) {
			((TextBox) sender).UseSystemPasswordChar = true;
		}

		private async void ButtonSubmit_Click(object sender, EventArgs e) {
			if (shouldLogin) {
				LastFM.Response res = await LastFM.Login(TextBoxKey.Text, TextBoxSecret.Text, TextBoxUsername.Text, TextBoxPassword.Text);
				
				if (res.Code > 0) {
					string msg = "";
					switch (res.Code) {
						case 4:
							msg = "Wrong username or password!";
							break;
						case 6:
							msg = "Missing values!";
							break;
						case 10:
							msg = "Invalid key!";
							break;
						case 13:
							msg = "Invalid secret!";
							break;
					}
					
					MessageBox.Show(msg, "ScrobbleBee", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Settings.Session = res.Data;
			}

			Settings.Key = TextBoxKey.Text;
			Settings.Secret = TextBoxSecret.Text;
			Settings.Title = (MetaDataType) ComboBoxTitle.SelectedValue;
			Settings.Artist = (MetaDataType) ComboBoxArtist.SelectedValue;
			Settings.Album = (MetaDataType) ComboBoxAlbum.SelectedValue;
			Settings.Save();
			Close();
		}

	}

}
