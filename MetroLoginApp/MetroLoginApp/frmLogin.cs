using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Dapper;

namespace MetroLoginApp
{
	public partial class frmLogin : MetroFramework.Forms.MetroForm
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			this.StyleManager = metroStyleManager1;
			metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
			metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;

			if (Properties.Settings.Default.Remember)
			{
				txtUserName.Text = Properties.Settings.Default.UserName;
				txtPassword.Text = Properties.Settings.Default.Password;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox1_Click(object sender, EventArgs e)
		{

		}

		private void metroTextBox1_Click_1(object sender, EventArgs e)
		{

		}

		private void metroTextBox2_Click(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserName.Text)) 
			{
				MetroFramework.MetroMessageBox.Show(this, "Please enter your username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtUserName.Focus();
				return;
			}
			try
			{
				using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection-DESKTOP-JQSTP26"].ConnectionString))
				{
					if (db.State == ConnectionState.Closed)
					{
						db.Open();
						User obj = db.Query<User>($"select *from Users where UserName = '{txtUserName.Text}'", commandType: CommandType.Text).SingleOrDefault();
						if (obj != null)
						{
							if (obj.Password == txtPassword.Text)
							{
								using(frmMain frm = new frmMain())
								{
									this.Hide();
									frm.ShowDialog();
								}
							}
							else
							{
								MetroFramework.MetroMessageBox.Show(this, "Your username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
						else
						{
							MetroFramework.MetroMessageBox.Show(this, "Your username and password don't match.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
			catch (Exception ex)
			{

				MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRememberMe.Checked)
			{
				Properties.Settings.Default.UserName = txtUserName.Text;
				Properties.Settings.Default.Password = txtPassword.Text;
			}
			else
			{
				Properties.Settings.Default.UserName = null;
				Properties.Settings.Default.Password = null;
			}
			Properties.Settings.Default.Remember = chkRememberMe.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
