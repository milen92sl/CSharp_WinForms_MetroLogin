
namespace MetroLoginApp
{
	partial class frmLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.chkRememberMe = new MetroFramework.Controls.MetroCheckBox();
			this.txtUserName = new MetroFramework.Controls.MetroTextBox();
			this.txtPassword = new MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MetroLoginApp.Properties.Resources.user_login_icon_31;
			this.pictureBox1.Location = new System.Drawing.Point(23, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 136);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// chkRememberMe
			// 
			this.chkRememberMe.AutoSize = true;
			this.chkRememberMe.Location = new System.Drawing.Point(204, 145);
			this.chkRememberMe.Name = "chkRememberMe";
			this.chkRememberMe.Size = new System.Drawing.Size(110, 17);
			this.chkRememberMe.TabIndex = 2;
			this.chkRememberMe.Text = "Remember me";
			this.chkRememberMe.UseSelectable = true;
			this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
			// 
			// txtUserName
			// 
			// 
			// 
			// 
			this.txtUserName.CustomButton.Image = null;
			this.txtUserName.CustomButton.Location = new System.Drawing.Point(386, 1);
			this.txtUserName.CustomButton.Name = "";
			this.txtUserName.CustomButton.Size = new System.Drawing.Size(33, 33);
			this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUserName.CustomButton.TabIndex = 1;
			this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUserName.CustomButton.UseSelectable = true;
			this.txtUserName.CustomButton.Visible = false;
			this.txtUserName.DisplayIcon = true;
			this.txtUserName.Icon = global::MetroLoginApp.Properties.Resources.icons8_username_20;
			this.txtUserName.Lines = new string[0];
			this.txtUserName.Location = new System.Drawing.Point(204, 63);
			this.txtUserName.MaxLength = 32767;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.PasswordChar = '\0';
			this.txtUserName.PromptText = "Enter your user name";
			this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUserName.SelectedText = "";
			this.txtUserName.SelectionLength = 0;
			this.txtUserName.SelectionStart = 0;
			this.txtUserName.ShortcutsEnabled = true;
			this.txtUserName.Size = new System.Drawing.Size(420, 35);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.UseSelectable = true;
			this.txtUserName.WaterMark = "Enter your user name";
			this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Click += new System.EventHandler(this.metroTextBox1_Click_1);
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.CustomButton.Image = null;
			this.txtPassword.CustomButton.Location = new System.Drawing.Point(386, 1);
			this.txtPassword.CustomButton.Name = "";
			this.txtPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
			this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPassword.CustomButton.TabIndex = 1;
			this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPassword.CustomButton.UseSelectable = true;
			this.txtPassword.CustomButton.Visible = false;
			this.txtPassword.DisplayIcon = true;
			this.txtPassword.Icon = global::MetroLoginApp.Properties.Resources.icons8_sign_in_form_password_20;
			this.txtPassword.Lines = new string[0];
			this.txtPassword.Location = new System.Drawing.Point(204, 104);
			this.txtPassword.MaxLength = 32767;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PromptText = "Enter your password";
			this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPassword.SelectedText = "";
			this.txtPassword.SelectionLength = 0;
			this.txtPassword.SelectionStart = 0;
			this.txtPassword.ShortcutsEnabled = true;
			this.txtPassword.Size = new System.Drawing.Size(420, 35);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSelectable = true;
			this.txtPassword.WaterMark = "Enter your password";
			this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Click += new System.EventHandler(this.metroTextBox2_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.metroButton1.Location = new System.Drawing.Point(510, 162);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(114, 37);
			this.metroButton1.TabIndex = 3;
			this.metroButton1.Text = "Login";
			this.metroButton1.UseCustomForeColor = true;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroStyleManager1
			// 
			this.metroStyleManager1.Owner = null;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 237);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.chkRememberMe);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroCheckBox chkRememberMe;
		private MetroFramework.Controls.MetroTextBox txtUserName;
		private MetroFramework.Controls.MetroTextBox txtPassword;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Components.MetroStyleManager metroStyleManager1;
	}
}

