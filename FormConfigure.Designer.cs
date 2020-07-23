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
			this.LayoutTable = new System.Windows.Forms.TableLayoutPanel();
			this.LabelAlbum = new System.Windows.Forms.Label();
			this.ComboBoxAlbum = new System.Windows.Forms.ComboBox();
			this.LabelArtist = new System.Windows.Forms.Label();
			this.ComboBoxArtist = new System.Windows.Forms.ComboBox();
			this.LabelApp = new System.Windows.Forms.Label();
			this.LabelKey = new System.Windows.Forms.Label();
			this.LabelSecret = new System.Windows.Forms.Label();
			this.LabelUser = new System.Windows.Forms.Label();
			this.LabelUsername = new System.Windows.Forms.Label();
			this.LabelPassword = new System.Windows.Forms.Label();
			this.LabelBee = new System.Windows.Forms.Label();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.TextBoxKey = new System.Windows.Forms.TextBox();
			this.TextBoxSecret = new System.Windows.Forms.TextBox();
			this.TextBoxUsername = new System.Windows.Forms.TextBox();
			this.TextBoxPassword = new System.Windows.Forms.TextBox();
			this.ComboBoxTitle = new System.Windows.Forms.ComboBox();
			this.ButtonSubmit = new System.Windows.Forms.Button();
			this.LabelNote = new System.Windows.Forms.Label();
			this.LayoutTable.SuspendLayout();
			this.SuspendLayout();
			// 
			// LayoutTable
			// 
			this.LayoutTable.ColumnCount = 2;
			this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this.LayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.LayoutTable.Controls.Add(this.LabelAlbum, 0, 9);
			this.LayoutTable.Controls.Add(this.ComboBoxAlbum, 0, 9);
			this.LayoutTable.Controls.Add(this.LabelArtist, 0, 8);
			this.LayoutTable.Controls.Add(this.ComboBoxArtist, 0, 8);
			this.LayoutTable.Controls.Add(this.LabelApp, 0, 0);
			this.LayoutTable.Controls.Add(this.LabelKey, 0, 1);
			this.LayoutTable.Controls.Add(this.LabelSecret, 0, 2);
			this.LayoutTable.Controls.Add(this.LabelUser, 0, 3);
			this.LayoutTable.Controls.Add(this.LabelUsername, 0, 4);
			this.LayoutTable.Controls.Add(this.LabelPassword, 0, 5);
			this.LayoutTable.Controls.Add(this.LabelBee, 0, 6);
			this.LayoutTable.Controls.Add(this.LabelTitle, 0, 7);
			this.LayoutTable.Controls.Add(this.TextBoxKey, 1, 1);
			this.LayoutTable.Controls.Add(this.TextBoxSecret, 1, 2);
			this.LayoutTable.Controls.Add(this.TextBoxUsername, 1, 4);
			this.LayoutTable.Controls.Add(this.TextBoxPassword, 1, 5);
			this.LayoutTable.Controls.Add(this.ComboBoxTitle, 1, 7);
			this.LayoutTable.Dock = System.Windows.Forms.DockStyle.Top;
			this.LayoutTable.Location = new System.Drawing.Point(0, 0);
			this.LayoutTable.Name = "LayoutTable";
			this.LayoutTable.Padding = new System.Windows.Forms.Padding(16);
			this.LayoutTable.RowCount = 10;
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.LayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.LayoutTable.Size = new System.Drawing.Size(500, 349);
			this.LayoutTable.TabIndex = 0;
			// 
			// LabelAlbum
			// 
			this.LabelAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelAlbum.Location = new System.Drawing.Point(22, 311);
			this.LabelAlbum.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelAlbum.Name = "LabelAlbum";
			this.LabelAlbum.Size = new System.Drawing.Size(122, 37);
			this.LabelAlbum.TabIndex = 18;
			this.LabelAlbum.Text = "Album";
			this.LabelAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ComboBoxAlbum
			// 
			this.ComboBoxAlbum.DisplayMember = "Text";
			this.ComboBoxAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ComboBoxAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxAlbum.FormattingEnabled = true;
			this.ComboBoxAlbum.Location = new System.Drawing.Point(152, 319);
			this.ComboBoxAlbum.Margin = new System.Windows.Forms.Padding(8);
			this.ComboBoxAlbum.Name = "ComboBoxAlbum";
			this.ComboBoxAlbum.Size = new System.Drawing.Size(324, 21);
			this.ComboBoxAlbum.TabIndex = 17;
			this.ComboBoxAlbum.ValueMember = "Value";
			this.ComboBoxAlbum.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
			// 
			// LabelArtist
			// 
			this.LabelArtist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelArtist.Location = new System.Drawing.Point(22, 274);
			this.LabelArtist.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelArtist.Name = "LabelArtist";
			this.LabelArtist.Size = new System.Drawing.Size(122, 37);
			this.LabelArtist.TabIndex = 16;
			this.LabelArtist.Text = "Artist";
			this.LabelArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ComboBoxArtist
			// 
			this.ComboBoxArtist.DisplayMember = "Text";
			this.ComboBoxArtist.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ComboBoxArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxArtist.FormattingEnabled = true;
			this.ComboBoxArtist.Location = new System.Drawing.Point(152, 282);
			this.ComboBoxArtist.Margin = new System.Windows.Forms.Padding(8);
			this.ComboBoxArtist.Name = "ComboBoxArtist";
			this.ComboBoxArtist.Size = new System.Drawing.Size(324, 21);
			this.ComboBoxArtist.TabIndex = 15;
			this.ComboBoxArtist.ValueMember = "Value";
			this.ComboBoxArtist.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
			// 
			// LabelApp
			// 
			this.LabelApp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelApp.Location = new System.Drawing.Point(22, 16);
			this.LabelApp.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelApp.Name = "LabelApp";
			this.LabelApp.Size = new System.Drawing.Size(122, 23);
			this.LabelApp.TabIndex = 0;
			this.LabelApp.Text = "Last.fm (App)";
			this.LabelApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelKey
			// 
			this.LabelKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelKey.Location = new System.Drawing.Point(22, 39);
			this.LabelKey.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelKey.Name = "LabelKey";
			this.LabelKey.Size = new System.Drawing.Size(122, 38);
			this.LabelKey.TabIndex = 1;
			this.LabelKey.Text = "Key";
			this.LabelKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelSecret
			// 
			this.LabelSecret.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSecret.Location = new System.Drawing.Point(22, 77);
			this.LabelSecret.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelSecret.Name = "LabelSecret";
			this.LabelSecret.Size = new System.Drawing.Size(122, 38);
			this.LabelSecret.TabIndex = 2;
			this.LabelSecret.Text = "Secret";
			this.LabelSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelUser
			// 
			this.LabelUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelUser.Location = new System.Drawing.Point(22, 115);
			this.LabelUser.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelUser.Name = "LabelUser";
			this.LabelUser.Size = new System.Drawing.Size(122, 23);
			this.LabelUser.TabIndex = 3;
			this.LabelUser.Text = "Last.fm (User)";
			this.LabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelUsername
			// 
			this.LabelUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelUsername.Location = new System.Drawing.Point(22, 138);
			this.LabelUsername.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelUsername.Name = "LabelUsername";
			this.LabelUsername.Size = new System.Drawing.Size(122, 38);
			this.LabelUsername.TabIndex = 4;
			this.LabelUsername.Text = "Username";
			this.LabelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelPassword
			// 
			this.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelPassword.Location = new System.Drawing.Point(22, 176);
			this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelPassword.Name = "LabelPassword";
			this.LabelPassword.Size = new System.Drawing.Size(122, 38);
			this.LabelPassword.TabIndex = 5;
			this.LabelPassword.Text = "Password";
			this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelBee
			// 
			this.LabelBee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelBee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelBee.Location = new System.Drawing.Point(22, 214);
			this.LabelBee.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelBee.Name = "LabelBee";
			this.LabelBee.Size = new System.Drawing.Size(122, 23);
			this.LabelBee.TabIndex = 6;
			this.LabelBee.Text = "MusicBee";
			this.LabelBee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LabelTitle
			// 
			this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelTitle.Location = new System.Drawing.Point(22, 237);
			this.LabelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(122, 37);
			this.LabelTitle.TabIndex = 7;
			this.LabelTitle.Text = "Title";
			this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TextBoxKey
			// 
			this.TextBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxKey.Location = new System.Drawing.Point(152, 47);
			this.TextBoxKey.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxKey.Name = "TextBoxKey";
			this.TextBoxKey.Size = new System.Drawing.Size(324, 22);
			this.TextBoxKey.TabIndex = 9;
			this.TextBoxKey.UseSystemPasswordChar = true;
			this.TextBoxKey.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.TextBoxKey.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.TextBoxKey.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// TextBoxSecret
			// 
			this.TextBoxSecret.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSecret.Location = new System.Drawing.Point(152, 85);
			this.TextBoxSecret.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxSecret.Name = "TextBoxSecret";
			this.TextBoxSecret.Size = new System.Drawing.Size(324, 22);
			this.TextBoxSecret.TabIndex = 10;
			this.TextBoxSecret.UseSystemPasswordChar = true;
			this.TextBoxSecret.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.TextBoxSecret.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
			this.TextBoxSecret.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
			// 
			// TextBoxUsername
			// 
			this.TextBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxUsername.Location = new System.Drawing.Point(152, 146);
			this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxUsername.Name = "TextBoxUsername";
			this.TextBoxUsername.Size = new System.Drawing.Size(324, 22);
			this.TextBoxUsername.TabIndex = 12;
			this.TextBoxUsername.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// TextBoxPassword
			// 
			this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxPassword.Location = new System.Drawing.Point(152, 184);
			this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(8);
			this.TextBoxPassword.Name = "TextBoxPassword";
			this.TextBoxPassword.Size = new System.Drawing.Size(324, 22);
			this.TextBoxPassword.TabIndex = 13;
			this.TextBoxPassword.UseSystemPasswordChar = true;
			this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// ComboBoxTitle
			// 
			this.ComboBoxTitle.DisplayMember = "Text";
			this.ComboBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ComboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxTitle.FormattingEnabled = true;
			this.ComboBoxTitle.Location = new System.Drawing.Point(152, 245);
			this.ComboBoxTitle.Margin = new System.Windows.Forms.Padding(8);
			this.ComboBoxTitle.Name = "ComboBoxTitle";
			this.ComboBoxTitle.Size = new System.Drawing.Size(324, 21);
			this.ComboBoxTitle.TabIndex = 14;
			this.ComboBoxTitle.ValueMember = "Value";
			this.ComboBoxTitle.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
			// 
			// ButtonSubmit
			// 
			this.ButtonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSubmit.Location = new System.Drawing.Point(23, 355);
			this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(0);
			this.ButtonSubmit.Name = "ButtonSubmit";
			this.ButtonSubmit.Padding = new System.Windows.Forms.Padding(4);
			this.ButtonSubmit.Size = new System.Drawing.Size(454, 36);
			this.ButtonSubmit.TabIndex = 17;
			this.ButtonSubmit.Text = "Save";
			this.ButtonSubmit.UseVisualStyleBackColor = true;
			this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
			// 
			// LabelNote
			// 
			this.LabelNote.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LabelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelNote.ForeColor = System.Drawing.Color.Tomato;
			this.LabelNote.Location = new System.Drawing.Point(0, 389);
			this.LabelNote.Name = "LabelNote";
			this.LabelNote.Size = new System.Drawing.Size(500, 25);
			this.LabelNote.TabIndex = 18;
			this.LabelNote.Text = "Disable MusicBee\'s built-in scrobbling!";
			this.LabelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormConfigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 414);
			this.Controls.Add(this.ButtonSubmit);
			this.Controls.Add(this.LabelNote);
			this.Controls.Add(this.LayoutTable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(516, 453);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(516, 453);
			this.Name = "FormConfigure";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ScrobbleBee";
			this.LayoutTable.ResumeLayout(false);
			this.LayoutTable.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel LayoutTable;
		private System.Windows.Forms.Label LabelApp;
		private System.Windows.Forms.Label LabelKey;
		private System.Windows.Forms.Label LabelSecret;
		private System.Windows.Forms.Label LabelUser;
		private System.Windows.Forms.Label LabelUsername;
		private System.Windows.Forms.Label LabelPassword;
		private System.Windows.Forms.Label LabelBee;
		private System.Windows.Forms.TextBox TextBoxKey;
		private System.Windows.Forms.TextBox TextBoxSecret;
		private System.Windows.Forms.TextBox TextBoxUsername;
		private System.Windows.Forms.TextBox TextBoxPassword;
		private System.Windows.Forms.Button ButtonSubmit;
		private System.Windows.Forms.ComboBox ComboBoxTitle;
		private System.Windows.Forms.Label LabelArtist;
		private System.Windows.Forms.ComboBox ComboBoxArtist;
		private System.Windows.Forms.ComboBox ComboBoxAlbum;
		private System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.Label LabelAlbum;
		private System.Windows.Forms.Label LabelNote;
	}
}