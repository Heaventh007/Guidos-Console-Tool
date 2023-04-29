using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GuidoCT.Properties;
using JRPC_Client;
using ToolSettings;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000007 RID: 7
	public partial class DashEditor : XtraForm
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000ACE4 File Offset: 0x00008EE4
		public DashEditor()
		{
			this.ini_0 = new INI("./launch.ini");
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000AD1C File Offset: 0x00008F1C
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (File.Exists("./launch.ini"))
			{
				File.Delete("./launch.ini");
			}
			try
			{
				this.ixboxConsole_0.CloseConnection(1U);
			}
			catch
			{
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000AD64 File Offset: 0x00008F64
		private void DashEditor_Load(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				try
				{
					this.ixboxConsole_0.ReceiveFile("./launch.ini", "Hdd:\\launch.ini");
				}
				catch (Exception)
				{
					XtraMessageBox.Show("Failed to pull launch.ini from Hdd at load, set the drive to pull from manually.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
				this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
				this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
				this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
				this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
				this.textEdit_5.Text = this.ini_0.Read("Paths", "BUT_A");
				this.textEdit9.Text = this.ini_0.Read("Paths", "BUT_B");
				this.textEdit8.Text = this.ini_0.Read("Paths", "BUT_X");
				this.textEdit7.Text = this.ini_0.Read("Paths", "BUT_Y");
				this.textEdit6.Text = this.ini_0.Read("Paths", "Start");
				this.textEdit_0.Text = this.ini_0.Read("Paths", "Back");
				this.textEdit_2.Text = this.ini_0.Read("Paths", "LBump");
				this.textEdit_1.Text = this.ini_0.Read("Paths", "RThumb");
				this.textEdit_3.Text = this.ini_0.Read("Paths", "LThumb");
				this.textEdit_4.Text = this.ini_0.Read("Paths", "Default");
				this.textEdit_6.Text = this.ini_0.Read("Externals", "ftpport");
				if (this.ini_0.Read("Externals", "ftpserv") == "true")
				{
					this.simpleButton2.Text = "ftpserv [ON]";
				}
				if (this.ini_0.Read("Externals", "updserv") == "true")
				{
					this.simpleButton3.Text = "updserv [ON]";
				}
				if (this.ini_0.Read("Externals", "calaunch") == "true")
				{
					this.simpleButton7.Text = "calaunch [ON]";
				}
				if (this.ini_0.Read("Externals", "fahrenheit") == "true")
				{
					this.simpleButton8.Text = "fahrenheit [ON]";
				}
				if (this.ini_0.Read("Settings", "contpatch") == "true")
				{
					this.simpleButton20.Text = "contpatch [ON]";
				}
				if (this.ini_0.Read("Settings", "xblapatch") == "true")
				{
					this.simpleButton19.Text = "xblapatch [ON]";
				}
				if (this.ini_0.Read("Settings", "licpatch") == "true")
				{
					this.simpleButton16.Text = "licpatch [ON]";
				}
				if (this.ini_0.Read("Settings", "nxemini") == "true")
				{
					this.simpleButton15.Text = "nxemini [ON]";
				}
				if (this.ini_0.Read("Settings", "dvdexitdash") == "true")
				{
					this.simpleButton21.Text = "dvdexitdash [ON]";
				}
				if (this.ini_0.Read("Settings", "xblaexitdash") == "true")
				{
					this.simpleButton31.Text = "xblaexitdash [ON]";
				}
				if (this.ini_0.Read("Settings", "nosysexit") == "true")
				{
					this.simpleButton30.Text = "nosysexit [ON]";
				}
				if (this.ini_0.Read("Settings", "nohud") == "true")
				{
					this.simpleButton27.Text = "nohud [ON]";
				}
				if (this.ini_0.Read("Settings", "nohealth") == "true")
				{
					this.simpleButton26.Text = "nohealth [ON]";
				}
				if (this.ini_0.Read("Settings", "nooobe") == "true")
				{
					this.simpleButton23.Text = "nooobe [ON]";
				}
				if (this.ini_0.Read("Settings", "autoswap") == "true")
				{
					this.simpleButton41.Text = "autoswap [ON]";
				}
				if (this.ini_0.Read("Settings", "regionspoof") == "true")
				{
					this.simpleButton40.Text = "regionspoof [ON]";
				}
				if (this.ini_0.Read("Settings", "autoshut") == "true")
				{
					this.simpleButton37.Text = "autoshut [ON]";
				}
				if (this.ini_0.Read("Settings", "autooff") == "true")
				{
					this.simpleButton36.Text = "autooff [ON]";
				}
				if (this.ini_0.Read("Settings", "shuttemps") == "true")
				{
					this.simpleButton33.Text = "shuttemps [ON]";
				}
				if (this.ini_0.Read("Settings", "fatalreboot") == "true")
				{
					this.simpleButton45.Text = "fatalreboot [ON]";
				}
				if (this.ini_0.Read("Settings", "fatalfreeze") == "true")
				{
					this.simpleButton43.Text = "fatalfreeze [ON]";
				}
				if (this.ini_0.Read("Settings", "safereboot") == "true")
				{
					this.simpleButton49.Text = "safereboot [ON]";
				}
				if (this.ini_0.Read("Settings", "exchandler") == "true")
				{
					this.simpleButton47.Text = "exchandler [ON]";
				}
				if (this.ini_0.Read("Settings", "debugout") == "true")
				{
					this.simpleButton53.Text = "debugout [ON]";
				}
				if (this.ini_0.Read("Settings", "passlaunch") == "true")
				{
					this.simpleButton51.Text = "passlaunch [ON]";
				}
				if (this.ini_0.Read("Settings", "noupdater") == "true")
				{
					this.simpleButton55.Text = "noupdater [ON]";
				}
				if (this.ini_0.Read("Settings", "remotenxe") == "true")
				{
					this.simpleButton57.Text = "remotenxe [ON]";
				}
				this.textEdit_16.Text = this.ini_0.Read("Settings", "autofake0");
				this.textEdit_15.Text = this.ini_0.Read("Settings", "autofake1");
				this.textEdit_14.Text = this.ini_0.Read("Settings", "autofake2");
				this.textEdit_13.Text = this.ini_0.Read("Settings", "autofake3");
				this.textEdit_12.Text = this.ini_0.Read("Settings", "autofake4");
				this.textEdit_7.Text = this.ini_0.Read("Settings", "autofake5");
				this.textEdit_9.Text = this.ini_0.Read("Settings", "autofake6");
				this.textEdit_8.Text = this.ini_0.Read("Settings", "autofake7");
				this.textEdit_10.Text = this.ini_0.Read("Settings", "autofake8");
				this.textEdit_11.Text = this.ini_0.Read("Settings", "autofake9");
				if (this.ini_0.Read("Settings", "pingpatch") == "true")
				{
					this.simpleButton61.Text = "pingpatch [ON]";
				}
				if (this.ini_0.Read("Settings", "signnotice") == "true")
				{
					this.simpleButton65.Text = "signnotice [ON]";
				}
				if (this.ini_0.Read("Settings", "liveblock") == "true")
				{
					this.simpleButton63.Text = "liveblock [ON]";
				}
				if (this.ini_0.Read("Settings", "livestrong") == "true")
				{
					this.simpleButton73.Text = "livestrong [ON]";
				}
				if (this.ini_0.Read("Settings", "xhttp") == "true")
				{
					this.simpleButton71.Text = "xhttp [ON]";
				}
				if (this.ini_0.Read("Settings", "nonetrestore") == "true")
				{
					this.simpleButton69.Text = "nonetrestore [ON]";
				}
				if (this.ini_0.Read("Settings", "devlink") == "true")
				{
					this.simpleButton67.Text = "devlink [ON]";
				}
				if (this.ini_0.Read("Settings", "sockpatch") == "true")
				{
					this.simpleButton81.Text = "sockpatch [ON]";
				}
				if (this.ini_0.Read("Settings", "fakelive") == "true")
				{
					this.simpleButton79.Text = "fakelive [ON]";
				}
				if (this.ini_0.Read("Settings", "autofake") == "true")
				{
					this.simpleButton77.Text = "autofake [ON]";
				}
				if (this.ini_0.Read("Settings", "autocont") == "true")
				{
					this.simpleButton58.Text = "autocont [ON]";
				}
				if (this.ini_0.Read("Settings", "tempbcast") == "true")
				{
					this.simpleButton83.Text = "tempbcast [ON]";
				}
				if (this.ini_0.Read("Settings", "hddalive") == "true")
				{
					this.simpleButton75.Text = "hddalive [ON]";
				}
				this.textEdit_19.Text = this.ini_0.Read("Settings", "hddtimer");
				this.textEdit_18.Text = this.ini_0.Read("Settings", "temptime");
				this.textEdit_17.Text = this.ini_0.Read("Settings", "tempport");
			}
			else
			{
				XtraMessageBox.Show("Failed to establish a connection to your console, the tool will load disconnected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000B928 File Offset: 0x00009B28
		private void simpleButton84_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.ReceiveFile("./launch.ini", this.comboBoxEdit1.Text + "launch.ini");
			this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
			this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
			this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
			this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
			this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
			this.textEdit_5.Text = this.ini_0.Read("Paths", "BUT_A");
			this.textEdit9.Text = this.ini_0.Read("Paths", "BUT_B");
			this.textEdit8.Text = this.ini_0.Read("Paths", "BUT_X");
			this.textEdit7.Text = this.ini_0.Read("Paths", "BUT_Y");
			this.textEdit6.Text = this.ini_0.Read("Paths", "Start");
			this.textEdit_0.Text = this.ini_0.Read("Paths", "Back");
			this.textEdit_2.Text = this.ini_0.Read("Paths", "LBump");
			this.textEdit_1.Text = this.ini_0.Read("Paths", "RThumb");
			this.textEdit_3.Text = this.ini_0.Read("Paths", "LThumb");
			this.textEdit_4.Text = this.ini_0.Read("Paths", "Default");
			this.textEdit_6.Text = this.ini_0.Read("Externals", "ftpport");
			if (this.ini_0.Read("Externals", "ftpserv") == "true")
			{
				this.simpleButton2.Text = "ftpserv [ON]";
			}
			if (this.ini_0.Read("Externals", "updserv") == "true")
			{
				this.simpleButton3.Text = "updserv [ON]";
			}
			if (this.ini_0.Read("Externals", "calaunch") == "true")
			{
				this.simpleButton7.Text = "calaunch [ON]";
			}
			if (this.ini_0.Read("Externals", "fahrenheit") == "true")
			{
				this.simpleButton8.Text = "fahrenheit [ON]";
			}
			if (this.ini_0.Read("Settings", "contpatch") == "true")
			{
				this.simpleButton20.Text = "contpatch [ON]";
			}
			if (this.ini_0.Read("Settings", "xblapatch") == "true")
			{
				this.simpleButton19.Text = "xblapatch [ON]";
			}
			if (this.ini_0.Read("Settings", "licpatch") == "true")
			{
				this.simpleButton16.Text = "licpatch [ON]";
			}
			if (this.ini_0.Read("Settings", "nxemini") == "true")
			{
				this.simpleButton15.Text = "nxemini [ON]";
			}
			if (this.ini_0.Read("Settings", "dvdexitdash") == "true")
			{
				this.simpleButton21.Text = "dvdexitdash [ON]";
			}
			if (this.ini_0.Read("Settings", "xblaexitdash") == "true")
			{
				this.simpleButton31.Text = "xblaexitdash [ON]";
			}
			if (this.ini_0.Read("Settings", "nosysexit") == "true")
			{
				this.simpleButton30.Text = "nosysexit [ON]";
			}
			if (this.ini_0.Read("Settings", "nohud") == "true")
			{
				this.simpleButton27.Text = "nohud [ON]";
			}
			if (this.ini_0.Read("Settings", "nohealth") == "true")
			{
				this.simpleButton26.Text = "nohealth [ON]";
			}
			if (this.ini_0.Read("Settings", "nooobe") == "true")
			{
				this.simpleButton23.Text = "nooobe [ON]";
			}
			if (this.ini_0.Read("Settings", "autoswap") == "true")
			{
				this.simpleButton41.Text = "autoswap [ON]";
			}
			if (this.ini_0.Read("Settings", "regionspoof") == "true")
			{
				this.simpleButton40.Text = "regionspoof [ON]";
			}
			if (this.ini_0.Read("Settings", "autoshut") == "true")
			{
				this.simpleButton37.Text = "autoshut [ON]";
			}
			if (this.ini_0.Read("Settings", "autooff") == "true")
			{
				this.simpleButton36.Text = "autooff [ON]";
			}
			if (this.ini_0.Read("Settings", "shuttemps") == "true")
			{
				this.simpleButton33.Text = "shuttemps [ON]";
			}
			if (this.ini_0.Read("Settings", "fatalreboot") == "true")
			{
				this.simpleButton45.Text = "fatalreboot [ON]";
			}
			if (this.ini_0.Read("Settings", "fatalfreeze") == "true")
			{
				this.simpleButton43.Text = "fatalfreeze [ON]";
			}
			if (this.ini_0.Read("Settings", "safereboot") == "true")
			{
				this.simpleButton49.Text = "safereboot [ON]";
			}
			if (this.ini_0.Read("Settings", "exchandler") == "true")
			{
				this.simpleButton47.Text = "exchandler [ON]";
			}
			if (this.ini_0.Read("Settings", "debugout") == "true")
			{
				this.simpleButton53.Text = "debugout [ON]";
			}
			if (this.ini_0.Read("Settings", "passlaunch") == "true")
			{
				this.simpleButton51.Text = "passlaunch [ON]";
			}
			if (this.ini_0.Read("Settings", "noupdater") == "true")
			{
				this.simpleButton55.Text = "noupdater [ON]";
			}
			if (this.ini_0.Read("Settings", "remotenxe") == "true")
			{
				this.simpleButton57.Text = "remotenxe [ON]";
			}
			this.textEdit_16.Text = this.ini_0.Read("Settings", "autofake0");
			this.textEdit_15.Text = this.ini_0.Read("Settings", "autofake1");
			this.textEdit_14.Text = this.ini_0.Read("Settings", "autofake2");
			this.textEdit_13.Text = this.ini_0.Read("Settings", "autofake3");
			this.textEdit_12.Text = this.ini_0.Read("Settings", "autofake4");
			this.textEdit_7.Text = this.ini_0.Read("Settings", "autofake5");
			this.textEdit_9.Text = this.ini_0.Read("Settings", "autofake6");
			this.textEdit_8.Text = this.ini_0.Read("Settings", "autofake7");
			this.textEdit_10.Text = this.ini_0.Read("Settings", "autofake8");
			this.textEdit_11.Text = this.ini_0.Read("Settings", "autofake9");
			if (this.ini_0.Read("Settings", "pingpatch") == "true")
			{
				this.simpleButton61.Text = "pingpatch [ON]";
			}
			if (this.ini_0.Read("Settings", "signnotice") == "true")
			{
				this.simpleButton65.Text = "signnotice [ON]";
			}
			if (this.ini_0.Read("Settings", "liveblock") == "true")
			{
				this.simpleButton63.Text = "liveblock [ON]";
			}
			if (this.ini_0.Read("Settings", "livestrong") == "true")
			{
				this.simpleButton73.Text = "livestrong [ON]";
			}
			if (this.ini_0.Read("Settings", "xhttp") == "true")
			{
				this.simpleButton71.Text = "xhttp [ON]";
			}
			if (this.ini_0.Read("Settings", "nonetrestore") == "true")
			{
				this.simpleButton69.Text = "nonetrestore [ON]";
			}
			if (this.ini_0.Read("Settings", "devlink") == "true")
			{
				this.simpleButton67.Text = "devlink [ON]";
			}
			if (this.ini_0.Read("Settings", "sockpatch") == "true")
			{
				this.simpleButton81.Text = "sockpatch [ON]";
			}
			if (this.ini_0.Read("Settings", "fakelive") == "true")
			{
				this.simpleButton79.Text = "fakelive [ON]";
			}
			if (this.ini_0.Read("Settings", "autofake") == "true")
			{
				this.simpleButton77.Text = "autofake [ON]";
			}
			if (this.ini_0.Read("Settings", "autocont") == "true")
			{
				this.simpleButton58.Text = "autocont [ON]";
			}
			if (this.ini_0.Read("Settings", "tempbcast") == "true")
			{
				this.simpleButton83.Text = "tempbcast [ON]";
			}
			if (this.ini_0.Read("Settings", "hddalive") == "true")
			{
				this.simpleButton75.Text = "hddalive [ON]";
			}
			this.textEdit_19.Text = this.ini_0.Read("Settings", "hddtimer");
			this.textEdit_18.Text = this.ini_0.Read("Settings", "temptime");
			this.textEdit_17.Text = this.ini_0.Read("Settings", "tempport");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		private void simpleButton19_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton19.Text == "xblapatch [OFF]"))
			{
				this.simpleButton19.Text = "xblapatch [OFF]";
			}
			else
			{
				this.simpleButton19.Text = "xblapatch [ON]";
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		private void simpleButton86_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("This will re-pull the launch.ini from selected drive, are you sure you want to discard all changes? ", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (!(this.comboBoxEdit1.Text == ""))
				{
					this.ixboxConsole_0.ReceiveFile("./launch.ini", this.comboBoxEdit1.Text + "launch.ini");
					this.textEdit1.Text = this.ini_0.Read("Plugins", "plugin1");
					this.textEdit2.Text = this.ini_0.Read("Plugins", "plugin2");
					this.textEdit3.Text = this.ini_0.Read("Plugins", "plugin3");
					this.textEdit4.Text = this.ini_0.Read("Plugins", "plugin4");
					this.textEdit5.Text = this.ini_0.Read("Plugins", "plugin5");
					this.textEdit_5.Text = this.ini_0.Read("Paths", "BUT_A");
					this.textEdit9.Text = this.ini_0.Read("Paths", "BUT_B");
					this.textEdit8.Text = this.ini_0.Read("Paths", "BUT_X");
					this.textEdit7.Text = this.ini_0.Read("Paths", "BUT_Y");
					this.textEdit6.Text = this.ini_0.Read("Paths", "Start");
					this.textEdit_0.Text = this.ini_0.Read("Paths", "Back");
					this.textEdit_2.Text = this.ini_0.Read("Paths", "LBump");
					this.textEdit_1.Text = this.ini_0.Read("Paths", "RThumb");
					this.textEdit_3.Text = this.ini_0.Read("Paths", "LThumb");
					this.textEdit_4.Text = this.ini_0.Read("Paths", "Default");
					this.textEdit_6.Text = this.ini_0.Read("Externals", "ftpport");
					if (this.ini_0.Read("Externals", "ftpserv") == "true")
					{
						this.simpleButton2.Text = "ftpserv [ON]";
					}
					if (this.ini_0.Read("Externals", "updserv") == "true")
					{
						this.simpleButton3.Text = "updserv [ON]";
					}
					if (this.ini_0.Read("Externals", "calaunch") == "true")
					{
						this.simpleButton7.Text = "calaunch [ON]";
					}
					if (this.ini_0.Read("Externals", "fahrenheit") == "true")
					{
						this.simpleButton8.Text = "fahrenheit [ON]";
					}
					if (this.ini_0.Read("Settings", "contpatch") == "true")
					{
						this.simpleButton20.Text = "contpatch [ON]";
					}
					if (this.ini_0.Read("Settings", "xblapatch") == "true")
					{
						this.simpleButton19.Text = "xblapatch [ON]";
					}
					if (this.ini_0.Read("Settings", "licpatch") == "true")
					{
						this.simpleButton16.Text = "licpatch [ON]";
					}
					if (this.ini_0.Read("Settings", "nxemini") == "true")
					{
						this.simpleButton15.Text = "nxemini [ON]";
					}
					if (this.ini_0.Read("Settings", "dvdexitdash") == "true")
					{
						this.simpleButton21.Text = "dvdexitdash [ON]";
					}
					if (this.ini_0.Read("Settings", "xblaexitdash") == "true")
					{
						this.simpleButton31.Text = "xblaexitdash [ON]";
					}
					if (this.ini_0.Read("Settings", "nosysexit") == "true")
					{
						this.simpleButton30.Text = "nosysexit [ON]";
					}
					if (this.ini_0.Read("Settings", "nohud") == "true")
					{
						this.simpleButton27.Text = "nohud [ON]";
					}
					if (this.ini_0.Read("Settings", "nohealth") == "true")
					{
						this.simpleButton26.Text = "nohealth [ON]";
					}
					if (this.ini_0.Read("Settings", "nooobe") == "true")
					{
						this.simpleButton23.Text = "nooobe [ON]";
					}
					if (this.ini_0.Read("Settings", "autoswap") == "true")
					{
						this.simpleButton41.Text = "autoswap [ON]";
					}
					if (this.ini_0.Read("Settings", "regionspoof") == "true")
					{
						this.simpleButton40.Text = "regionspoof [ON]";
					}
					if (this.ini_0.Read("Settings", "autoshut") == "true")
					{
						this.simpleButton37.Text = "autoshut [ON]";
					}
					if (this.ini_0.Read("Settings", "autooff") == "true")
					{
						this.simpleButton36.Text = "autooff [ON]";
					}
					if (this.ini_0.Read("Settings", "shuttemps") == "true")
					{
						this.simpleButton33.Text = "shuttemps [ON]";
					}
					if (this.ini_0.Read("Settings", "fatalreboot") == "true")
					{
						this.simpleButton45.Text = "fatalreboot [ON]";
					}
					if (this.ini_0.Read("Settings", "fatalfreeze") == "true")
					{
						this.simpleButton43.Text = "fatalfreeze [ON]";
					}
					if (this.ini_0.Read("Settings", "safereboot") == "true")
					{
						this.simpleButton49.Text = "safereboot [ON]";
					}
					if (this.ini_0.Read("Settings", "exchandler") == "true")
					{
						this.simpleButton47.Text = "exchandler [ON]";
					}
					if (this.ini_0.Read("Settings", "debugout") == "true")
					{
						this.simpleButton53.Text = "debugout [ON]";
					}
					if (this.ini_0.Read("Settings", "passlaunch") == "true")
					{
						this.simpleButton51.Text = "passlaunch [ON]";
					}
					if (this.ini_0.Read("Settings", "noupdater") == "true")
					{
						this.simpleButton55.Text = "noupdater [ON]";
					}
					if (this.ini_0.Read("Settings", "remotenxe") == "true")
					{
						this.simpleButton57.Text = "remotenxe [ON]";
					}
					this.textEdit_16.Text = this.ini_0.Read("Settings", "autofake0");
					this.textEdit_15.Text = this.ini_0.Read("Settings", "autofake1");
					this.textEdit_14.Text = this.ini_0.Read("Settings", "autofake2");
					this.textEdit_13.Text = this.ini_0.Read("Settings", "autofake3");
					this.textEdit_12.Text = this.ini_0.Read("Settings", "autofake4");
					this.textEdit_7.Text = this.ini_0.Read("Settings", "autofake5");
					this.textEdit_9.Text = this.ini_0.Read("Settings", "autofake6");
					this.textEdit_8.Text = this.ini_0.Read("Settings", "autofake7");
					this.textEdit_10.Text = this.ini_0.Read("Settings", "autofake8");
					this.textEdit_11.Text = this.ini_0.Read("Settings", "autofake9");
					if (this.ini_0.Read("Settings", "pingpatch") == "true")
					{
						this.simpleButton61.Text = "pingpatch [ON]";
					}
					if (this.ini_0.Read("Settings", "signnotice") == "true")
					{
						this.simpleButton65.Text = "signnotice [ON]";
					}
					if (this.ini_0.Read("Settings", "liveblock") == "true")
					{
						this.simpleButton63.Text = "liveblock [ON]";
					}
					if (this.ini_0.Read("Settings", "livestrong") == "true")
					{
						this.simpleButton73.Text = "livestrong [ON]";
					}
					if (this.ini_0.Read("Settings", "xhttp") == "true")
					{
						this.simpleButton71.Text = "xhttp [ON]";
					}
					if (this.ini_0.Read("Settings", "nonetrestore") == "true")
					{
						this.simpleButton69.Text = "nonetrestore [ON]";
					}
					if (this.ini_0.Read("Settings", "devlink") == "true")
					{
						this.simpleButton67.Text = "devlink [ON]";
					}
					if (this.ini_0.Read("Settings", "sockpatch") == "true")
					{
						this.simpleButton81.Text = "sockpatch [ON]";
					}
					if (this.ini_0.Read("Settings", "fakelive") == "true")
					{
						this.simpleButton79.Text = "fakelive [ON]";
					}
					if (this.ini_0.Read("Settings", "autofake") == "true")
					{
						this.simpleButton77.Text = "autofake [ON]";
					}
					if (this.ini_0.Read("Settings", "autocont") == "true")
					{
						this.simpleButton58.Text = "autocont [ON]";
					}
					if (this.ini_0.Read("Settings", "tempbcast") == "true")
					{
						this.simpleButton83.Text = "tempbcast [ON]";
					}
					if (this.ini_0.Read("Settings", "hddalive") == "true")
					{
						this.simpleButton75.Text = "hddalive [ON]";
					}
					this.textEdit_19.Text = this.ini_0.Read("Settings", "hddtimer");
					this.textEdit_18.Text = this.ini_0.Read("Settings", "temptime");
					this.textEdit_17.Text = this.ini_0.Read("Settings", "tempport");
				}
				else
				{
					XtraMessageBox.Show("You haven't yet selected a drive to save the changes to! Do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			this.ini_0.Write("Plugins", "plugin1", this.textEdit1.Text);
			this.ini_0.Write("Plugins", "plugin2", this.textEdit2.Text);
			this.ini_0.Write("Plugins", "plugin3", this.textEdit3.Text);
			this.ini_0.Write("Plugins", "plugin4", this.textEdit4.Text);
			this.ini_0.Write("Plugins", "plugin5", this.textEdit5.Text);
			DialogResult dialogResult = XtraMessageBox.Show("This will send the launch.ini back with all plug-in changes, are you sure you want to save the changes?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (this.comboBoxEdit1.Text == "")
				{
					XtraMessageBox.Show("You haven't yet selected a drive to save the changes to! Do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.ixboxConsole_0.SendFile("./launch.ini", this.comboBoxEdit1.Text + "launch.ini");
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.ini_0.Write("Paths", "BUT_A", this.textEdit_5.Text);
			this.ini_0.Write("Paths", "BUT_B", this.textEdit9.Text);
			this.ini_0.Write("Paths", "BUT_X", this.textEdit8.Text);
			this.ini_0.Write("Paths", "BUT_Y", this.textEdit7.Text);
			this.ini_0.Write("Paths", "Start", this.textEdit6.Text);
			this.ini_0.Write("Paths", "Back", this.textEdit_0.Text);
			this.ini_0.Write("Paths", "LBump", this.textEdit_2.Text);
			this.ini_0.Write("Paths", "RThumb", this.textEdit_1.Text);
			this.ini_0.Write("Paths", "LThumb", this.textEdit_3.Text);
			this.ini_0.Write("Paths", "Default", this.textEdit_4.Text);
			DialogResult dialogResult = XtraMessageBox.Show("This will send the launch.ini back with all Paths changes, are you sure you want to save the changes?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (this.comboBoxEdit1.Text == "")
				{
					XtraMessageBox.Show("You haven't yet selected a drive to save the changes to! Do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.ixboxConsole_0.SendFile("./launch.ini", this.comboBoxEdit1.Text + "launch.ini");
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000D384 File Offset: 0x0000B584
		private void simpleButton85_Click(object sender, EventArgs e)
		{
			this.ini_0.Write("Plugins", "plugin1", " " + this.textEdit1.Text);
			this.ini_0.Write("Plugins", "plugin2", " " + this.textEdit2.Text);
			this.ini_0.Write("Plugins", "plugin3", " " + this.textEdit3.Text);
			this.ini_0.Write("Plugins", "plugin4", " " + this.textEdit4.Text);
			this.ini_0.Write("Plugins", "plugin5", " " + this.textEdit5.Text);
			this.ini_0.Write("Paths", "BUT_A", this.textEdit_5.Text);
			this.ini_0.Write("Paths", "BUT_B", this.textEdit9.Text);
			this.ini_0.Write("Paths", "BUT_X", this.textEdit8.Text);
			this.ini_0.Write("Paths", "BUT_Y", this.textEdit7.Text);
			this.ini_0.Write("Paths", "Start", this.textEdit6.Text);
			this.ini_0.Write("Paths", "Back", this.textEdit_0.Text);
			this.ini_0.Write("Paths", "LBump", this.textEdit_2.Text);
			this.ini_0.Write("Paths", "RThumb", this.textEdit_1.Text);
			this.ini_0.Write("Paths", "LThumb", this.textEdit_3.Text);
			this.ini_0.Write("Paths", "Default", this.textEdit_4.Text);
			this.ini_0.Write("Externals", "ftpport", " " + this.textEdit_6.Text);
			this.ini_0.Write("Settings", "hddtimer", " " + this.textEdit_19.Text);
			this.ini_0.Write("Settings", "temptime", " " + this.textEdit_18.Text);
			this.ini_0.Write("Settings", "tempport", " " + this.textEdit_17.Text);
			this.ini_0.Write("Settings", "autofake0", " " + this.textEdit_16.Text);
			this.ini_0.Write("Settings", "autofake1", " " + this.textEdit_15.Text);
			this.ini_0.Write("Settings", "autofake2", " " + this.textEdit_14.Text);
			this.ini_0.Write("Settings", "autofake3", " " + this.textEdit_13.Text);
			this.ini_0.Write("Settings", "autofake4", " " + this.textEdit_12.Text);
			this.ini_0.Write("Settings", "autofake5", " " + this.textEdit_7.Text);
			this.ini_0.Write("Settings", "autofake6", " " + this.textEdit_9.Text);
			this.ini_0.Write("Settings", "autofake7", " " + this.textEdit_8.Text);
			this.ini_0.Write("Settings", "autofake8", " " + this.textEdit_10.Text);
			this.ini_0.Write("Settings", "autofake9", " " + this.textEdit_11.Text);
			foreach (Button button in this.groupControl3.Controls.OfType<Button>())
			{
				if (button.Text.Contains("[OFF]"))
				{
					string key = button.Text.Split(new char[]
					{
						"[OFF]".First<char>()
					}).First<string>();
					this.ini_0.Write("Externals", key, " false");
				}
				if (button.Text.Contains("[ON]"))
				{
					string key2 = button.Text.Split(new char[]
					{
						"[ON]".First<char>()
					}).First<string>();
					this.ini_0.Write("Externals", key2, " true");
				}
			}
			foreach (Button button2 in this.groupControl4.Controls.OfType<Button>())
			{
				if (button2.Text.Contains("[OFF]"))
				{
					string key3 = button2.Text.Split(new char[]
					{
						"[OFF]".First<char>()
					}).First<string>();
					this.ini_0.Write("Settings", key3, " false");
				}
				if (button2.Text.Contains("[ON]"))
				{
					string key4 = button2.Text.Split(new char[]
					{
						"[ON]".First<char>()
					}).First<string>();
					this.ini_0.Write("Settings", key4, " true");
				}
			}
			foreach (Button button3 in this.groupControl5.Controls.OfType<Button>())
			{
				if (button3.Text.Contains("[OFF]"))
				{
					string key5 = button3.Text.Split(new char[]
					{
						"[OFF]".First<char>()
					}).First<string>();
					this.ini_0.Write("Settings", key5, " false");
				}
				if (button3.Text.Contains("[ON]"))
				{
					string key6 = button3.Text.Split(new char[]
					{
						"[ON]".First<char>()
					}).First<string>();
					this.ini_0.Write("Settings", key6, " true");
				}
			}
			foreach (Button button4 in this.groupControl6.Controls.OfType<Button>())
			{
				if (button4.Text.Contains("[OFF]"))
				{
					string key7 = button4.Text.Split(new char[]
					{
						"[OFF]".First<char>()
					}).First<string>();
					this.ini_0.Write("Settings", key7, " false");
				}
				if (button4.Text.Contains("[ON]"))
				{
					string key8 = button4.Text.Split(new char[]
					{
						"[ON]".First<char>()
					}).First<string>();
					this.ini_0.Write("Settings", key8, " true");
				}
			}
			DialogResult dialogResult = XtraMessageBox.Show("This will send the launch.ini back with all changes made, are you sure you want to save the changes?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (!(this.comboBoxEdit1.Text == ""))
				{
					this.ixboxConsole_0.SendFile("./launch.ini", this.comboBoxEdit1.Text + "launch.ini");
					DialogResult dialogResult2 = XtraMessageBox.Show("Changes applied successfully! Do you want to reboot to finalize?", "Warning", MessageBoxButtons.YesNo);
					if (dialogResult2 == DialogResult.Yes)
					{
						this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Cold);
					}
				}
				else
				{
					XtraMessageBox.Show("You haven't yet selected a drive to save the changes to! Do that first.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000DC38 File Offset: 0x0000BE38
		private void simpleButton20_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton20.Text == "contpatch [OFF]"))
			{
				this.simpleButton20.Text = "contpatch [OFF]";
			}
			else
			{
				this.simpleButton20.Text = "contpatch [ON]";
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000DC80 File Offset: 0x0000BE80
		private void simpleButton16_Click(object sender, EventArgs e)
		{
			if (this.simpleButton16.Text == "licpatch [OFF]")
			{
				this.simpleButton16.Text = "licpatch [ON]";
			}
			else
			{
				this.simpleButton16.Text = "licpatch [OFF]";
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		private void simpleButton15_Click(object sender, EventArgs e)
		{
			if (this.simpleButton15.Text == "nxemini [OFF]")
			{
				this.simpleButton15.Text = "nxemini [ON]";
			}
			else
			{
				this.simpleButton15.Text = "nxemini [OFF]";
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000DD10 File Offset: 0x0000BF10
		private void simpleButton21_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton21.Text == "dvdexitdash [OFF]"))
			{
				this.simpleButton21.Text = "dvdexitdash [OFF]";
			}
			else
			{
				this.simpleButton21.Text = "dvdexitdash [ON]";
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000DD58 File Offset: 0x0000BF58
		private void simpleButton53_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton53.Text == "debugout [OFF]"))
			{
				this.simpleButton53.Text = "debugout [OFF]";
			}
			else
			{
				this.simpleButton53.Text = "debugout [ON]";
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		private void simpleButton51_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton51.Text == "passlaunch [OFF]"))
			{
				this.simpleButton51.Text = "passlaunch [OFF]";
			}
			else
			{
				this.simpleButton51.Text = "passlaunch [ON]";
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		private void simpleButton55_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton55.Text == "noupdater [OFF]"))
			{
				this.simpleButton55.Text = "noupdater [OFF]";
			}
			else
			{
				this.simpleButton55.Text = "noupdater [ON]";
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000DE30 File Offset: 0x0000C030
		private void simpleButton31_Click(object sender, EventArgs e)
		{
			if (this.simpleButton31.Text == "xblaexitdash [OFF]")
			{
				this.simpleButton31.Text = "xblaexitdash [ON]";
			}
			else
			{
				this.simpleButton31.Text = "xblaexitdash [OFF]";
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000DE78 File Offset: 0x0000C078
		private void simpleButton30_Click(object sender, EventArgs e)
		{
			if (this.simpleButton30.Text == "nosysexit [OFF]")
			{
				this.simpleButton30.Text = "nosysexit [ON]";
			}
			else
			{
				this.simpleButton30.Text = "nosysexit [OFF]";
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		private void simpleButton27_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton27.Text == "nohud [OFF]"))
			{
				this.simpleButton27.Text = "nohud [OFF]";
			}
			else
			{
				this.simpleButton27.Text = "nohud [ON]";
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000DF08 File Offset: 0x0000C108
		private void simpleButton26_Click(object sender, EventArgs e)
		{
			if (this.simpleButton26.Text == "nohealth [OFF]")
			{
				this.simpleButton26.Text = "nohealth [ON]";
			}
			else
			{
				this.simpleButton26.Text = "nohealth [OFF]";
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000DF50 File Offset: 0x0000C150
		private void simpleButton23_Click(object sender, EventArgs e)
		{
			if (this.simpleButton23.Text == "nooobe [OFF]")
			{
				this.simpleButton23.Text = "nooobe [ON]";
			}
			else
			{
				this.simpleButton23.Text = "nooobe [OFF]";
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000DF98 File Offset: 0x0000C198
		private void simpleButton49_Click(object sender, EventArgs e)
		{
			if (this.simpleButton49.Text == "safereboot [OFF]")
			{
				this.simpleButton49.Text = "safereboot [ON]";
			}
			else
			{
				this.simpleButton49.Text = "safereboot [OFF]";
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		private void simpleButton47_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton47.Text == "exchandler [OFF]"))
			{
				this.simpleButton47.Text = "exchandler [OFF]";
			}
			else
			{
				this.simpleButton47.Text = "exchandler [ON]";
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000E028 File Offset: 0x0000C228
		private void simpleButton57_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton57.Text == "remotenxe [OFF]"))
			{
				this.simpleButton57.Text = "remotenxe [OFF]";
			}
			else
			{
				this.simpleButton57.Text = "remotenxe [ON]";
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000E070 File Offset: 0x0000C270
		private void simpleButton41_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton41.Text == "autoswap [OFF]"))
			{
				this.simpleButton41.Text = "autoswap [OFF]";
			}
			else
			{
				this.simpleButton41.Text = "autoswap [ON]";
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		private void simpleButton40_Click(object sender, EventArgs e)
		{
			if (this.simpleButton40.Text == "regionspoof [OFF]")
			{
				this.simpleButton40.Text = "regionspoof [ON]";
			}
			else
			{
				this.simpleButton40.Text = "regionspoof [OFF]";
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000E100 File Offset: 0x0000C300
		private void simpleButton37_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton37.Text == "autoshut [OFF]"))
			{
				this.simpleButton37.Text = "autoshut [OFF]";
			}
			else
			{
				this.simpleButton37.Text = "autoshut [ON]";
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000E148 File Offset: 0x0000C348
		private void simpleButton36_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton36.Text == "autooff [OFF]"))
			{
				this.simpleButton36.Text = "autooff [OFF]";
			}
			else
			{
				this.simpleButton36.Text = "autooff [ON]";
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000E190 File Offset: 0x0000C390
		private void simpleButton33_Click(object sender, EventArgs e)
		{
			if (this.simpleButton33.Text == "shuttemps [OFF]")
			{
				this.simpleButton33.Text = "shuttemps [ON]";
			}
			else
			{
				this.simpleButton33.Text = "shuttemps [OFF]";
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		private void simpleButton45_Click(object sender, EventArgs e)
		{
			if (this.simpleButton45.Text == "fatalreboot [OFF]")
			{
				this.simpleButton45.Text = "fatalreboot [ON]";
			}
			else
			{
				this.simpleButton45.Text = "fatalreboot [OFF]";
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000E220 File Offset: 0x0000C420
		private void simpleButton43_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton43.Text == "fatalfreeze [OFF]"))
			{
				this.simpleButton43.Text = "fatalfreeze [OFF]";
			}
			else
			{
				this.simpleButton43.Text = "fatalfreeze [ON]";
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000E268 File Offset: 0x0000C468
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton2.Text == "ftpserv [OFF]"))
			{
				this.simpleButton2.Text = "ftpserv [OFF]";
			}
			else
			{
				this.simpleButton2.Text = "ftpserv [ON]";
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (this.simpleButton3.Text == "updserv [OFF]")
			{
				this.simpleButton3.Text = "updserv [ON]";
			}
			else
			{
				this.simpleButton3.Text = "updserv [OFF]";
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		private void simpleButton7_Click(object sender, EventArgs e)
		{
			if (this.simpleButton7.Text == "calaunch [OFF]")
			{
				this.simpleButton7.Text = "calaunch [ON]";
			}
			else
			{
				this.simpleButton7.Text = "calaunch [OFF]";
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000E340 File Offset: 0x0000C540
		private void simpleButton8_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton8.Text == "fahrenheit [OFF]"))
			{
				this.simpleButton8.Text = "fahrenheit [OFF]";
			}
			else
			{
				this.simpleButton8.Text = "fahrenheit [ON]";
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000E388 File Offset: 0x0000C588
		private void simpleButton58_Click(object sender, EventArgs e)
		{
			if (this.simpleButton58.Text == "autocont [OFF]")
			{
				this.simpleButton58.Text = "autocont [ON]";
			}
			else
			{
				this.simpleButton58.Text = "autocont [OFF]";
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		private void simpleButton61_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton61.Text == "pingpatch [OFF]"))
			{
				this.simpleButton61.Text = "pingpatch [OFF]";
			}
			else
			{
				this.simpleButton61.Text = "pingpatch [ON]";
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000E418 File Offset: 0x0000C618
		private void simpleButton65_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton65.Text == "signnotice [OFF]"))
			{
				this.simpleButton65.Text = "signnotice [OFF]";
			}
			else
			{
				this.simpleButton65.Text = "signnotice [ON]";
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000E460 File Offset: 0x0000C660
		private void simpleButton73_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton73.Text == "livestrong [OFF]"))
			{
				this.simpleButton73.Text = "livestrong [OFF]";
			}
			else
			{
				this.simpleButton73.Text = "livestrong [ON]";
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		private void simpleButton71_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton71.Text == "xhttp [OFF]"))
			{
				this.simpleButton71.Text = "xhttp [OFF]";
			}
			else
			{
				this.simpleButton71.Text = "xhttp [ON]";
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		private void simpleButton69_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton69.Text == "nonetrestore [OFF]"))
			{
				this.simpleButton69.Text = "nonetrestore [OFF]";
			}
			else
			{
				this.simpleButton69.Text = "nonetrestore [ON]";
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000E538 File Offset: 0x0000C738
		private void simpleButton81_Click(object sender, EventArgs e)
		{
			if (this.simpleButton81.Text == "sockpatch [OFF]")
			{
				this.simpleButton81.Text = "sockpatch [ON]";
			}
			else
			{
				this.simpleButton81.Text = "sockpatch [OFF]";
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000E580 File Offset: 0x0000C780
		private void simpleButton79_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton79.Text == "fakelive [OFF]"))
			{
				this.simpleButton79.Text = "fakelive [OFF]";
			}
			else
			{
				this.simpleButton79.Text = "fakelive [ON]";
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		private void simpleButton77_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton77.Text == "autofake [OFF]"))
			{
				this.simpleButton77.Text = "autofake [OFF]";
			}
			else
			{
				this.simpleButton77.Text = "autofake [ON]";
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000E610 File Offset: 0x0000C810
		private void simpleButton63_Click(object sender, EventArgs e)
		{
			if (this.simpleButton63.Text == "liveblock [OFF]")
			{
				this.simpleButton63.Text = "liveblock [ON]";
			}
			else
			{
				this.simpleButton63.Text = "liveblock [OFF]";
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000E658 File Offset: 0x0000C858
		private void simpleButton67_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton67.Text == "devlink [OFF]"))
			{
				this.simpleButton67.Text = "devlink [OFF]";
			}
			else
			{
				this.simpleButton67.Text = "devlink [ON]";
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		private void simpleButton75_Click(object sender, EventArgs e)
		{
			if (this.simpleButton75.Text == "hddalive [OFF]")
			{
				this.simpleButton75.Text = "hddalive [ON]";
			}
			else
			{
				this.simpleButton75.Text = "hddalive [OFF]";
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		private void simpleButton83_Click(object sender, EventArgs e)
		{
			if (!(this.simpleButton83.Text == "tempbcast [OFF]"))
			{
				this.simpleButton83.Text = "tempbcast [OFF]";
			}
			else
			{
				this.simpleButton83.Text = "tempbcast [ON]";
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000E730 File Offset: 0x0000C930
		private void simpleButton18_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled addon and DLC content license info will be soft patched when accessed", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000E750 File Offset: 0x0000C950
		private void simpleButton17_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled XBLA content license info will be soft patched when accessed", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000E770 File Offset: 0x0000C970
		private void simpleButton14_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled replies from Xam License Mask function will be spoofed (usually required for extracted XBLA)", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000E790 File Offset: 0x0000C990
		private void simpleButton13_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled pressing Y in miniblades while in official dash will cause a launch event", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		private void simpleButton12_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled ejecting a game or DVD video will return to official dash", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000E7D0 File Offset: 0x0000C9D0
		private void simpleButton52_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled debug prints are rerouted to UART", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		private void simpleButton50_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled Dashlaunch will not clean up launchdata", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000E810 File Offset: 0x0000CA10
		private void simpleButton54_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled XAM is patched to look for updates at $$ystemUpdate", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000E830 File Offset: 0x0000CA30
		private void simpleButton29_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled exiting a XBLA game through its own menu will return you to official dash", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000E850 File Offset: 0x0000CA50
		private void simpleButton28_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled system options in miniblades will not exit to official dash", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000E870 File Offset: 0x0000CA70
		private void simpleButton25_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled the miniblades are made inaccessible", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000E890 File Offset: 0x0000CA90
		private void simpleButton24_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled kinect health pseudo video at game launch will not be shown", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		private void simpleButton22_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled dash locale setup screens when settings already exist will not be shown when dash starts", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		private void simpleButton48_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled console will soft reboot on fatal crashes (not jtag friendly)", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		private void simpleButton46_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled non-fatal crashes will exit instead of crash the console", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000E910 File Offset: 0x0000CB10
		private void simpleButton56_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled powering on the console with IR remote power button will go to official dash (one time)", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000E930 File Offset: 0x0000CB30
		private void simpleButton39_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled dash launch will perform automatic disk swapping\nWARNING!! do not enable if you use FSD or swap.xex for this!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000E950 File Offset: 0x0000CB50
		private void simpleButton38_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled holding RB during title launch will cause the region to be spoofed to the title for it's duration", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000E970 File Offset: 0x0000CB70
		private void simpleButton35_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled holding guide button will have 'shutdown' selected, toggling affects autooff", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000E990 File Offset: 0x0000CB90
		private void simpleButton34_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled holding Guide button will cause the console to shut down instead of display shutdown options, toggling affects autoshut", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		private void simpleButton32_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled a snapshot of the system temperature data will be displayed on the shutdown screen that appears when you hold guide button (enabling will disable autooff", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		private void simpleButton44_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled console will hard reboot on fatal crashes - does nothing if fatalfreeze is enabled", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
		private void simpleButton42_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled crash events will freeze the console", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000EA10 File Offset: 0x0000CC10
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled the installer will start it's FTP server\n!! only runs while installer is running !!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000EA30 File Offset: 0x0000CC30
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled the xebuild update server will be started\n!! only runs while installer is running !!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000EA50 File Offset: 0x0000CC50
		private void simpleButton10_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled installer will start to the launch menu instead of options", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000EA70 File Offset: 0x0000CC70
		private void simpleButton9_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled temps in installer and in guide (shuttemps option) will be\nshown in fahrenheit instead of celcius.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000EA90 File Offset: 0x0000CC90
		private void simpleButton11_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Sets the port for the installer FTP server", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		private void simpleButton59_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When autofake is enabled, whenever a community game is launched contpatch will be temporarily enabled. Enabling this option will enable autofake", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		private void simpleButton60_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled ping limit will be removed from system link play", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		private void simpleButton64_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled Dashlaunch will attempt to dismiss annoying signin notice messages", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000EB10 File Offset: 0x0000CD10
		private void simpleButton72_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Has no effect when liveblock is disabled. When enabled with liveblock a more extensive list of domaisn are blocked than with liveblock alone", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000EB30 File Offset: 0x0000CD30
		private void simpleButton70_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled XHttp is patched in XAM to allow insecure access", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000EB50 File Offset: 0x0000CD50
		private void simpleButton68_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled cloud storage should not show up in disk selection dialogs", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000EB70 File Offset: 0x0000CD70
		private void simpleButton80_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Don't enable this if you don't know what it does.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000EB90 File Offset: 0x0000CD90
		private void simpleButton78_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("Fakes being signed into xbox live allowing you to go into places where you would otherwise require to be signed into Xbox Live for. Don't enable this if you don't know what it does", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		private void simpleButton76_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled fakelive functionality will be automatically enabled only for official dash and indie game sessions. Disabling this option also disables autocont", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		private void simpleButton62_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled DNS resolver blocks LIVE sites", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		private void simpleButton66_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled system link data will be encrypted for communication with devkits", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000EC10 File Offset: 0x0000CE10
		private void simpleButton74_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If enabled, any USB drive with the file 'alive.txt' in it's root directory will be polled at hddtimer intervals", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000EC30 File Offset: 0x0000CE30
		private void simpleButton82_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("When enabled and a network connection is provided, temperature data will be broadcasted at temptime intervals to tempport", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000077C6 File Offset: 0x000059C6
		static DashEditor()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000077F5 File Offset: 0x000059F5
		internal static bool smethod_0()
		{
			return DashEditor.dashEditor_0 == null;
		}

		// Token: 0x0400001B RID: 27
		private IXboxConsole ixboxConsole_0;

		// Token: 0x0400001C RID: 28
		private INI ini_0;

		// Token: 0x040000C5 RID: 197
		internal static DashEditor dashEditor_0;
	}
}
