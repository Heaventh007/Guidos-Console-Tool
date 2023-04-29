using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using ToolSettings;

namespace GuidoCT
{
	// Token: 0x02000019 RID: 25
	public partial class Settings : XtraForm
	{
		// Token: 0x060005CC RID: 1484 RVA: 0x00097EF8 File Offset: 0x000960F8
		public Settings()
		{
			this.ini_0 = new INI("ToolSettings.ini");
			this.ini_1 = new INI("Login.ini");
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00097F40 File Offset: 0x00096140
		private void Settings_Load(object sender, EventArgs e)
		{
			if (!(this.ini_0.Read("Settings", "DiscordRPC") == "Disabled"))
			{
				this.simpleButton2.Text = "Discord RPC [ON]";
			}
			else
			{
				this.simpleButton2.Text = "Discord RPC [OFF]";
			}
			if (this.ini_0.Read("Settings", "HidePrivateInfo") == "Enabled")
			{
				this.simpleButton3.Text = "Hide Private Info [ON]";
			}
			else
			{
				this.simpleButton3.Text = "Hide Private Info [OFF]";
			}
			if (!(this.ini_0.Read("Settings", "CustomConnectionXnotifyStatus") == "Enabled"))
			{
				this.simpleButton37.Text = "Custom Connection Xnotify [OFF]";
			}
			else
			{
				this.simpleButton37.Text = "Custom Connection Xnotify [ON]";
			}
			if (!(this.ini_1.Read("Login", "Auto Login") == "true"))
			{
				this.simpleButton4.Text = "Auto Login [OFF]";
			}
			else
			{
				this.simpleButton4.Text = "Auto Login [ON]";
			}
			Form1 form = new Form1();
			this.labelControl3.Text = form.labelControl3.Text;
			this.textEdit_0.Text = this.ini_0.Read("Settings", "CustomConnectionXnotifyMessage");
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00098098 File Offset: 0x00096298
		private void simpleButton37_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton37.Text == "Custom Connection Xnotify [OFF]"))
			{
				this.simpleButton37.Text = "Custom Connection Xnotify [OFF]";
				this.ini_0.Write("Settings", "CustomConnectionXnotifyStatus", "Disabled");
				this.ini_0.Write("Settings", "CustomConnectionXnotifyMessage", "");
			}
			else
			{
				this.simpleButton37.Text = "Custom Connection Xnotify [ON]";
				if (this.textEdit_0.Text == "")
				{
					XtraMessageBox.Show("Connection Xnotify Cannot Be Empty", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.simpleButton37.Text = "Custom Connection Xnotify [OFF]";
				}
				else
				{
					this.ini_0.Write("Settings", "CustomConnectionXnotifyStatus", "Enabled");
					this.ini_0.Write("Settings", "CustomConnectionXnotifyMessage", this.textEdit_0.Text);
				}
			}
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0009818C File Offset: 0x0009638C
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			Application.Restart();
			Environment.Exit(0);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000981A4 File Offset: 0x000963A4
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			File.Delete("./ToolSettings.ini");
			XtraMessageBox.Show("Reset settings! Restarting tool to initialize changes.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Application.Restart();
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x000981D4 File Offset: 0x000963D4
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton2.Text == "DiscordRPC [ON]"))
			{
				this.simpleButton2.Text = "Discord RPC [ON]";
				this.ini_0.Write("Settings", "DiscordRPC", "Enabled");
				XtraMessageBox.Show("DiscordRPC has been enabled! Restart Tool to apply changes!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.simpleButton2.Text = "Discord RPC [OFF]";
				this.ini_0.Write("Settings", "DiscordRPC", "Disabled");
				XtraMessageBox.Show("DiscordRPC has been disabled! Restart Tool to apply changes!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00098274 File Offset: 0x00096474
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton3.Text == "Hide Private Info [OFF]"))
			{
				this.simpleButton3.Text = "Hide Private Info [OFF]";
				this.ini_0.Write("Settings", "HidePrivateInfo", "Disabled");
			}
			else
			{
				this.simpleButton3.Text = "Hide Private Info [ON]";
				this.ini_0.Write("Settings", "HidePrivateInfo", "Enabled");
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000982F0 File Offset: 0x000964F0
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			foreach (string text in Directory.GetFiles("./"))
			{
				if (text.Contains(".ini") || text.Contains(".txt"))
				{
					File.Delete(text);
				}
			}
			XtraMessageBox.Show("All ini and txt files have been successfully deleted!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0009835C File Offset: 0x0009655C
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			if (this.simpleButton4.Text == "Auto Login [OFF]")
			{
				this.simpleButton4.Text = "Auto Login [ON]";
				this.ini_1.Write("Login", "Auto Login", "true");
			}
			else
			{
				this.simpleButton4.Text = "Auto Login [OFF]";
				this.ini_1.Write("Login", "Auto Login", "false");
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000077C6 File Offset: 0x000059C6
		static Settings()
		{
			
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00007901 File Offset: 0x00005B01
		internal static bool smethod_0()
		{
			return Settings.settings_0 == null;
		}

		// Token: 0x0400092F RID: 2351
		private INI ini_0;

		// Token: 0x04000930 RID: 2352
		private INI ini_1;

		// Token: 0x0400093F RID: 2367
		internal static Settings settings_0;
	}
}
