using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GuidoCT.Properties;
using Imaging.DDSReader;
using JRPC_Client;
using ToolSettings;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000018 RID: 24
	public partial class ScreenshotTool : XtraForm
	{
		// Token: 0x060005C0 RID: 1472 RVA: 0x000977E8 File Offset: 0x000959E8
		public ScreenshotTool()
		{
			this.timer_0 = new System.Timers.Timer(4000.0);
			this.timer_1 = new System.Windows.Forms.Timer();
			this.bool_0 = false;
			this.ini_0 = new INI("ToolSettings.ini");
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00097844 File Offset: 0x00095A44
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			try
			{
				this.ixboxConsole_0.CloseConnection(1U);
			}
			catch
			{
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00097874 File Offset: 0x00095A74
		private void ScreenshotTool_Load(object sender, EventArgs e)
		{
			if (!this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				MessageBox.Show("Failed to open Screenshot Tool, because a connection to the console could not me made!");
				base.Close();
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000978AC File Offset: 0x00095AAC
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (File.Exists("screenshot.dds"))
			{
				File.Delete("screenshot.dds");
			}
			this.ixboxConsole_0.ScreenShot("screenshot.dds");
			if (File.Exists("screenshot.dds"))
			{
				this.pictureEdit1.Image = DDS.LoadImage("screenshot.dds", true);
				File.Delete("screenshot.dds");
			}
			GC.Collect();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00097910 File Offset: 0x00095B10
		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (File.Exists("screenshot.dds"))
			{
				File.Delete("screenshot.dds");
			}
			this.ixboxConsole_0.ScreenShot("screenshot.dds");
			if (File.Exists("screenshot.dds"))
			{
				this.pictureEdit1.Image = DDS.LoadImage("screenshot.dds", true);
				File.Delete("screenshot.dds");
			}
			GC.Collect();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00097974 File Offset: 0x00095B74
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				this.timer_1.Enabled = false;
			}
			else
			{
				this.bool_0 = true;
				this.timer_1.Enabled = true;
				this.timer_1.Interval = 4000;
				this.timer_1.Tick += this.timer_1_Tick;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000979DC File Offset: 0x00095BDC
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (this.pictureEdit1.Image != null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "*Images|*.png";
				ImageFormat png = ImageFormat.Png;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.pictureEdit1.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
				}
			}
			else
			{
				XtraMessageBox.Show("No screenshot was found, so there isn't any to save!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00097A58 File Offset: 0x00095C58
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			if (this.pictureEdit1.Image == null)
			{
				XtraMessageBox.Show("No screenshot was found, so there isn't any to copy to clipboard!\nIgnore next messagebox!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				Clipboard.SetImage(this.pictureEdit1.Image);
			}
			XtraMessageBox.Show("Copied Screenshot to Clipboard!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000077C6 File Offset: 0x000059C6
		static ScreenshotTool()
		{
			
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000078F7 File Offset: 0x00005AF7
		internal static bool smethod_0()
		{
			return ScreenshotTool.screenshotTool_0 == null;
		}

		// Token: 0x04000923 RID: 2339
		private IXboxConsole ixboxConsole_0;

		// Token: 0x04000924 RID: 2340
		private System.Timers.Timer timer_0;

		// Token: 0x04000925 RID: 2341
		private System.Windows.Forms.Timer timer_1;

		// Token: 0x04000926 RID: 2342
		private bool bool_0;

		// Token: 0x04000927 RID: 2343
		private INI ini_0;

		// Token: 0x0400092E RID: 2350
		internal static ScreenshotTool screenshotTool_0;
	}
}
