using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using JRPC_Client;
using PluginList;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000012 RID: 18
	public partial class INIEditorTool : XtraForm
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x00090D18 File Offset: 0x0008EF18
		public INIEditorTool()
		{
			this.string_0 = Path.GetDirectoryName(Application.ExecutablePath) + "/temp.ini";
			this.ini_0 = new INI("temp.ini");
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00090D68 File Offset: 0x0008EF68
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (File.Exists("./temp.ini"))
			{
				File.Delete("./temp.ini");
			}
			try
			{
				this.ixboxConsole_0.CloseConnection(1U);
			}
			catch
			{
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00090DB0 File Offset: 0x0008EFB0
		private void INIEditorTool_Load(object sender, EventArgs e)
		{
			if (!this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				XtraMessageBox.Show("No connection to console was found, therefore the options in the tool will not work!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00090DE8 File Offset: 0x0008EFE8
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.ReceiveFile(this.string_0, this.textEdit_0.Text ?? "");
			this.richTextBox1.Text = File.ReadAllText(this.string_0);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00090E30 File Offset: 0x0008F030
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.ReceiveFile(this.string_0, "Hdd:\\launch.ini");
				this.richTextBox1.Text = File.ReadAllText(this.string_0);
				this.textEdit_0.Text = "Hdd:\\launch.ini";
			}
			catch (Exception)
			{
				this.ixboxConsole_0.ReceiveFile(this.string_0, "Usb:\\launch.ini");
				this.richTextBox1.Text = File.ReadAllText(this.string_0);
				this.textEdit_0.Text = "Usb:\\launch.ini";
			}
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00090ECC File Offset: 0x0008F0CC
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			File.WriteAllText(this.string_0, this.richTextBox1.Text);
			this.ixboxConsole_0.SendFile(this.string_0, this.textEdit_0.Text ?? "");
			XtraMessageBox.Show("Successfully saved changes!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00090F28 File Offset: 0x0008F128
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.DeleteFile(this.textEdit_0.Text);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00090F4C File Offset: 0x0008F14C
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.ReceiveFile(this.string_0, "Hdd:\\launch.ini");
				this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
				this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
				this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
				this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
				this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
				File.Delete("temp.ini");
			}
			catch
			{
				this.ixboxConsole_0.ReceiveFile(this.string_0, "Usb:\\launch.ini");
				this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
				this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
				this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
				this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
				this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
				File.Delete("temp.ini");
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000910F4 File Offset: 0x0008F2F4
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.ReceiveFile(this.string_0, "Hdd:\\launch.ini");
				this.ini_0.Write("Plugins", "plugin1", "");
				this.ini_0.Write("Plugins", "plugin2", "");
				this.ini_0.Write("Plugins", "plugin3", "");
				this.ini_0.Write("Plugins", "plugin4", "");
				this.ini_0.Write("Plugins", "plugin5", "");
				this.ixboxConsole_0.SendFile(this.string_0, "Hdd:\\launch.ini");
				this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
				this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
				this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
				this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
				this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
				File.Delete("temp.ini");
				this.ixboxConsole_0.XNotify("Cleared plugin list, rebooting!");
				Thread.Sleep(3000);
				this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Warm);
			}
			catch (Exception)
			{
				this.ixboxConsole_0.ReceiveFile(this.string_0, "Usb:\\launch.ini");
				this.ini_0.Write("Plugins", "plugin2", "");
				this.ini_0.Write("Plugins", "plugin3", "");
				this.ini_0.Write("Plugins", "plugin4", "");
				this.ini_0.Write("Plugins", "plugin5", "");
				this.ixboxConsole_0.SendFile(this.string_0, "Usb:\\launch.ini");
				this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
				this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
				this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
				this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
				this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
				File.Delete("temp.ini");
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000077C6 File Offset: 0x000059C6
		static INIEditorTool()
		{
			
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000078AF File Offset: 0x00005AAF
		internal static bool smethod_0()
		{
			return INIEditorTool.inieditorTool_0 == null;
		}

		// Token: 0x040008A9 RID: 2217
		private IXboxConsole ixboxConsole_0;

		// Token: 0x040008AA RID: 2218
		private string string_0;

		// Token: 0x040008AB RID: 2219
		private INI ini_0;

		// Token: 0x040008C2 RID: 2242
		internal static INIEditorTool inieditorTool_0;
	}
}
