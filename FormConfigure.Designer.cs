namespace MusicBeePlugin {
	partial class FormConfigure {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.LabelApp = new System.Windows.Forms.Label();
			this.LabelKey = new System.Windows.Forms.Label();
			this.LabelSecret = new System.Windows.Forms.Label();
			this.LabelUser = new System.Windows.Forms.Label();
			this.LabelPassword = new System.Windows.Forms.Label();
			this.LabelUsername = new System.Windows.Forms.Label();
			this.TextBoxKey = new System.Windows.Forms.TextBox();
			this.TextBoxSecret = new System.Windows.Forms.TextBox();
			this.TextBoxUsername = new System.Windows.Forms.TextBox();
			this.TextBoxPassword = new System.Windows.Forms.TextBox();
			this.ButtonLogin = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.LabelArtist = new System.Windows.Forms.Label();
			this.LabelAlbum = new System.Windows.Forms.Label();
			this.LabelAlbumArtist = new System.Windows.Forms.Label();
			this.PanelSeparator = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// LabelApp
			// 
			this.LabelApp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelApp.Location = new System.Drawing.Point(0, 3);
			this.LabelApp.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelApp.Name = "LabelApp";
			this.LabelApp.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.LabelApp.Size = new System.Drawing.Size(483, 32);
			this.LabelApp.TabIndex = 0;
			this.LabelApp.Text = "Last.fm (App)";
			this.LabelApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelKey
			// 
			this.LabelKey.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelKey.Location = new System.Drawing.Point(0, 38);
			this.LabelKey.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelKey.Name = "LabelKey";
			this.LabelKey.Size = new System.Drawing.Size(100, 32);
			this.LabelKey.TabIndex = 1;
			this.LabelKey.Text = "Key";
			this.LabelKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LabelSecret
			// 
			this.LabelSecret.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSecret.Location = new System.Drawing.Point(0, 73);
			this.LabelSecret.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelSecret.Name = "LabelSecret";
			this.LabelSecret.Size = new System.Drawing.Size(100, 32);
			this.LabelSecret.TabIndex = 2;
			this.LabelSecret.Text = "Secret";
			this.LabelSecret.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LabelUser
			// 
			this.LabelUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelUser.Location = new System.Drawing.Point(0, 108);
			this.LabelUser.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelUser.Name = "LabelUser";
			this.LabelUser.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.LabelUser.Size = new System.Drawing.Size(483, 32);
			this.LabelUser.TabIndex = 3;
			this.LabelUser.Text = "Last.fm (User)";
			this.LabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelPassword
			// 
			this.LabelPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelPassword.Location = new System.Drawing.Point(0, 178);
			this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelPassword.Name = "LabelPassword";
			this.LabelPassword.Size = new System.Drawing.Size(100, 32);
			this.LabelPassword.TabIndex = 4;
			this.LabelPassword.Text = "Password";
			this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LabelUsername
			// 
			this.LabelUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelUsername.Location = new System.Drawing.Point(0, 143);
			this.LabelUsername.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelUsername.Name = "LabelUsername";
			this.LabelUsername.Size = new System.Drawing.Size(100, 32);
			this.LabelUsername.TabIndex = 5;
			this.LabelUsername.Text = "Username";
			this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TextBoxKey
			// 
			this.TextBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxKey.Location = new System.Drawing.Point(108, 44);
			this.TextBoxKey.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxKey.Name = "TextBoxKey";
			this.TextBoxKey.Size = new System.Drawing.Size(359, 22);
			this.TextBoxKey.TabIndex = 9;
			this.TextBoxKey.UseSystemPasswordChar = true;
			this.TextBoxKey.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.TextBoxKey.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// TextBoxSecret
			// 
			this.TextBoxSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSecret.Location = new System.Drawing.Point(108, 79);
			this.TextBoxSecret.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxSecret.Name = "TextBoxSecret";
			this.TextBoxSecret.Size = new System.Drawing.Size(359, 22);
			this.TextBoxSecret.TabIndex = 10;
			this.TextBoxSecret.UseSystemPasswordChar = true;
			this.TextBoxSecret.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.TextBoxSecret.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// TextBoxUsername
			// 
			this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxUsername.Location = new System.Drawing.Point(108, 149);
			this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxUsername.Name = "TextBoxUsername";
			this.TextBoxUsername.Size = new System.Drawing.Size(359, 22);
			this.TextBoxUsername.TabIndex = 12;
			// 
			// TextBoxPassword
			// 
			this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxPassword.Location = new System.Drawing.Point(108, 184);
			this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxPassword.Name = "TextBoxPassword";
			this.TextBoxPassword.Size = new System.Drawing.Size(359, 22);
			this.TextBoxPassword.TabIndex = 13;
			this.TextBoxPassword.UseSystemPasswordChar = true;
			this.TextBoxPassword.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.TextBoxPassword.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// ButtonLogin
			// 
			this.ButtonLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonLogin.Location = new System.Drawing.Point(107, 218);
			this.ButtonLogin.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonLogin.Name = "ButtonLogin";
			this.ButtonLogin.Padding = new System.Windows.Forms.Padding(4);
			this.ButtonLogin.Size = new System.Drawing.Size(361, 33);
			this.ButtonLogin.TabIndex = 17;
			this.ButtonLogin.Text = "Login";
			this.ButtonLogin.UseVisualStyleBackColor = true;
			this.ButtonLogin.Click += new System.EventHandler(this.ButtonSubmit_Click);
			// 
			// LabelTitle
			// 
			this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelTitle.AutoSize = true;
			this.LabelTitle.BackColor = System.Drawing.SystemColors.Control;
			this.LabelTitle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTitle.ForeColor = System.Drawing.Color.Black;
			this.LabelTitle.Location = new System.Drawing.Point(0, 268);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
			this.LabelTitle.Size = new System.Drawing.Size(104, 20);
			this.LabelTitle.TabIndex = 18;
			this.LabelTitle.Text = "ScrobbleBee-Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelArtist
			// 
			this.LabelArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelArtist.AutoSize = true;
			this.LabelArtist.BackColor = System.Drawing.SystemColors.Control;
			this.LabelArtist.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelArtist.ForeColor = System.Drawing.Color.Black;
			this.LabelArtist.Location = new System.Drawing.Point(108, 268);
			this.LabelArtist.Name = "LabelArtist";
			this.LabelArtist.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
			this.LabelArtist.Size = new System.Drawing.Size(110, 20);
			this.LabelArtist.TabIndex = 19;
			this.LabelArtist.Text = "ScrobbleBee-Artist";
			this.LabelArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelAlbum
			// 
			this.LabelAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelAlbum.AutoSize = true;
			this.LabelAlbum.BackColor = System.Drawing.SystemColors.Control;
			this.LabelAlbum.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelAlbum.ForeColor = System.Drawing.Color.Black;
			this.LabelAlbum.Location = new System.Drawing.Point(222, 268);
			this.LabelAlbum.Name = "LabelAlbum";
			this.LabelAlbum.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
			this.LabelAlbum.Size = new System.Drawing.Size(115, 20);
			this.LabelAlbum.TabIndex = 20;
			this.LabelAlbum.Text = "ScrobbleBee-Album";
			this.LabelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelAlbumArtist
			// 
			this.LabelAlbumArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LabelAlbumArtist.AutoSize = true;
			this.LabelAlbumArtist.BackColor = System.Drawing.SystemColors.Control;
			this.LabelAlbumArtist.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelAlbumArtist.ForeColor = System.Drawing.Color.Black;
			this.LabelAlbumArtist.Location = new System.Drawing.Point(341, 268);
			this.LabelAlbumArtist.Name = "LabelAlbumArtist";
			this.LabelAlbumArtist.Padding = new System.Windows.Forms.Padding(1, 1, 1, 3);
			this.LabelAlbumArtist.Size = new System.Drawing.Size(143, 20);
			this.LabelAlbumArtist.TabIndex = 21;
			this.LabelAlbumArtist.Text = "ScrobbleBee-AlbumArtist";
			this.LabelAlbumArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PanelSeparator
			// 
			this.PanelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.PanelSeparator.BackColor = System.Drawing.Color.DarkGray;
			this.PanelSeparator.Location = new System.Drawing.Point(-6, 267);
			this.PanelSeparator.Name = "PanelSeparator";
			this.PanelSeparator.Size = new System.Drawing.Size(498, 1);
			this.PanelSeparator.TabIndex = 22;
			// 
			// FormConfigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 288);
			this.Controls.Add(this.PanelSeparator);
			this.Controls.Add(this.LabelTitle);
			this.Controls.Add(this.LabelAlbumArtist);
			this.Controls.Add(this.LabelArtist);
			this.Controls.Add(this.LabelApp);
			this.Controls.Add(this.LabelAlbum);
			this.Controls.Add(this.LabelKey);
			this.Controls.Add(this.LabelSecret);
			this.Controls.Add(this.TextBoxSecret);
			this.Controls.Add(this.TextBoxPassword);
			this.Controls.Add(this.LabelUser);
			this.Controls.Add(this.TextBoxUsername);
			this.Controls.Add(this.LabelPassword);
			this.Controls.Add(this.TextBoxKey);
			this.Controls.Add(this.LabelUsername);
			this.Controls.Add(this.ButtonLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 327);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 327);
			this.Name = "FormConfigure";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ScrobbleBee";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label LabelApp;
		private System.Windows.Forms.Label LabelKey;
		private System.Windows.Forms.Label LabelSecret;
		private System.Windows.Forms.Label LabelUser;
		private System.Windows.Forms.Label LabelPassword;
		private System.Windows.Forms.Label LabelUsername;
		private System.Windows.Forms.TextBox TextBoxKey;
		private System.Windows.Forms.TextBox TextBoxSecret;
		private System.Windows.Forms.TextBox TextBoxUsername;
		private System.Windows.Forms.TextBox TextBoxPassword;
		private System.Windows.Forms.Button ButtonLogin;
		private System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.Label LabelArtist;
		private System.Windows.Forms.Label LabelAlbum;
		private System.Windows.Forms.Label LabelAlbumArtist;
		private System.Windows.Forms.Panel PanelSeparator;
	}
}