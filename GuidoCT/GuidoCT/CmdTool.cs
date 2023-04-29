using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using Imaging.DDSReader;
using JRPC_Client;
using ToolSettings;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000006 RID: 6
	public partial class CmdTool : XtraForm
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00009034 File Offset: 0x00007234
		public CmdTool()
		{
			this.ini_0 = new INI("ToolSettings.ini");
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000906C File Offset: 0x0000726C
		private string method_0(string string_0)
		{
			byte[] data = new byte[8];
			this.ixboxConsole_0.SetMemory(2175409456U, data);
			this.ixboxConsole_0.CallVoid(2172820832U, new object[]
			{
				2533274907391075L,
				0,
				string_0,
				24,
				2175409456U,
				0
			});
			Thread.Sleep(1000);
			string result = BitConverter.ToString(this.ixboxConsole_0.GetMemory(2175409456U, 8U)).Replace("-", "");
			this.ixboxConsole_0.SetMemory(2175409456U, data);
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00009130 File Offset: 0x00007330
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

		// Token: 0x06000022 RID: 34 RVA: 0x00009160 File Offset: 0x00007360
		private void CmdTool_Load(object sender, EventArgs e)
		{
			if (!this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				XtraMessageBox.Show("Failed to establish a connection to your console, the tool will load disconnected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.ixboxConsole_0.XNotify("Command System Loaded!");
			}
			this.textBox1.Focus();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000091B8 File Offset: 0x000073B8
		private void simpleButton100_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text == "help" || this.textBox1.Text == "Help")
			{
				this.listBox1.Items.Add("Help Command");
				this.listBox1.Items.Add("All Available Commands: ");
				this.listBox1.Items.Add("CPUKey");
				this.listBox1.Items.Add("Change Background Color");
				this.listBox1.Items.Add("Change Text Color");
				this.listBox1.Items.Add("Clear Console");
				this.listBox1.Items.Add("DiscordRPC");
				this.listBox1.Items.Add("Gamertag");
				this.listBox1.Items.Add("Get IP Addresses");
				this.listBox1.Items.Add("Get XUID");
				this.listBox1.Items.Add("Launch Title");
				this.listBox1.Items.Add("Open Tool");
				this.listBox1.Items.Add("Plugin List");
				this.listBox1.Items.Add("Quit");
				this.listBox1.Items.Add("Re-Connect");
				this.listBox1.Items.Add("Reboot");
				this.listBox1.Items.Add("Receive File");
				this.listBox1.Items.Add("Restart");
				this.listBox1.Items.Add("Screenshot To Clipboard");
				this.listBox1.Items.Add("Shutdown");
				this.listBox1.Items.Add("Temps");
				this.listBox1.Items.Add("Title ID");
				this.listBox1.Items.Add("XNotify");
				this.listBox1.Items.Add("Do help 'command here' to see how to use the command!");
			}
			if (this.textBox1.Text == "help xnotify" || this.textBox1.Text == "Help XNotify")
			{
				this.listBox1.Items.Add("Sends XNotify To Console, usage of command: XNotify 'Hello World!'");
			}
			if (this.textBox1.Text == "help receive file" || this.textBox1.Text == "Help Receive File")
			{
				this.listBox1.Items.Add("Receives file from console to pc, usage of command: Receive File 'Hdd:\\launch.ini");
			}
			if (this.textBox1.Text == "help get ip addresses" || this.textBox1.Text == "Help Get IP Addresses")
			{
				this.listBox1.Items.Add("Retrieves all IP Addresses, MUST BE BLACK OPS 2");
			}
			if (this.textBox1.Text == "help discordrpc" || this.textBox1.Text == "Help DiscordRPC")
			{
				this.listBox1.Items.Add("Enables/Disables DiscordRPC, usage of command: DiscordRPC OFF");
			}
			if (this.textBox1.Text == "help plugin list" || this.textBox1.Text == "Help Plugin")
			{
				this.listBox1.Items.Add("Shows your plugin list");
			}
			if (this.textBox1.Text == "help screenshot to clipboard" || this.textBox1.Text == "Help Screenshot To Clipboard")
			{
				this.listBox1.Items.Add("Makes Screenshot And Copies To Clipboard");
			}
			if (this.textBox1.Text == "help change text color" || this.textBox1.Text == "Help Change Text Color")
			{
				this.listBox1.Items.Add("Changes the color of the text in the Command System Console, usage of command: Change Text Color Red");
			}
			if (this.textBox1.Text == "help change background color" || this.textBox1.Text == "Help Change Background Color")
			{
				this.listBox1.Items.Add("Changes the color of the background in the Command System Console, usage of command: Change Background Color Red");
			}
			if (this.textBox1.Text == "help open tool" || this.textBox1.Text == "Help Open Tool")
			{
				this.listBox1.Items.Add("Opens Tool From Application, usage of command: Open Tool Gamelauncher");
			}
			if (this.textBox1.Text == "help restart" || this.textBox1.Text == "Help Restart")
			{
				this.listBox1.Items.Add("Restarts Tool");
			}
			if (this.textBox1.Text == "help title id" || this.textBox1.Text == "Help Title ID")
			{
				this.listBox1.Items.Add("Shows current Title ID");
			}
			if (this.textBox1.Text == "help get xuid" || this.textBox1.Text == "Help Get XUID")
			{
				this.listBox1.Items.Add("Retrieves XUID From Gamertag, usage of command: Get XUID 'FaZe Apex'");
			}
			if (this.textBox1.Text == "help reboot" || this.textBox1.Text == "Help Reboot")
			{
				this.listBox1.Items.Add("Reboots your console.");
			}
			if (this.textBox1.Text == "help shutdown" || this.textBox1.Text == "Help Shutdown")
			{
				this.listBox1.Items.Add("Shuts your console down.");
			}
			if (this.textBox1.Text == "help quit" || this.textBox1.Text == "Help Quit")
			{
				this.listBox1.Items.Add("Exits current title to dashboard.");
			}
			if (this.textBox1.Text == "help launch title" || this.textBox1.Text == "Help Launch Title")
			{
				this.listBox1.Items.Add("Launches desired title through path, usage of command: Launch Title 'Hdd:\\Games\\Skate 3\\default.xex'");
			}
			if (this.textBox1.Text == "help re-connect" || this.textBox1.Text == "Help Re-Connect")
			{
				this.listBox1.Items.Add("Re-Connects Tool To Console");
			}
			if (this.textBox1.Text == "help cpukey" || this.textBox1.Text == "Help CPUKey")
			{
				this.listBox1.Items.Add("Shows Your CPUKey");
			}
			if (this.textBox1.Text == "help gamertag" || this.textBox1.Text == "Help Gamertag")
			{
				this.listBox1.Items.Add("Shows Your Gamertag");
			}
			if (this.textBox1.Text == "help temps" || this.textBox1.Text == "Help Temps")
			{
				this.listBox1.Items.Add("Shows Your Console Temps");
			}
			if (this.textBox1.Text == "help clear console" || this.textBox1.Text == "Help Clear Console")
			{
				this.listBox1.Items.Add("Clears Command System Console");
			}
			if (this.textBox1.Text.Contains("xnotify"))
			{
				string text = this.textBox1.Text.Split(new char[]
				{
					"xnotify".Last<char>()
				}).Last<string>();
				this.ixboxConsole_0.XNotify(text);
				this.listBox1.Items.Add("Sent Xnotify : " + text);
			}
			if (this.textBox1.Text == "reboot")
			{
				this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Cold);
				this.listBox1.Items.Add("Rebooted Console");
			}
			if (this.textBox1.Text == "shutdown")
			{
				this.ixboxConsole_0.ShutDownConsole();
				this.listBox1.Items.Add("Shut Console Down");
			}
			if (this.textBox1.Text == "quit")
			{
				this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Title);
				this.listBox1.Items.Add("Exited To Dashboard");
			}
			if (this.textBox1.Text == "get ip addresses")
			{
				this.listBox1.Items.Add("IP Adresses:");
				for (int i = 0; i < 18; i++)
				{
					string text2 = Encoding.ASCII.GetString(this.ixboxConsole_0.GetMemory((uint)(-1006386264 + 328 * i), 15U)).TrimEnd(new char[1]);
					string text3 = new IPAddress(this.ixboxConsole_0.GetMemory((uint)(-1006386148 + 328 * i), 4U)).ToString();
					string text4 = int.Parse(BitConverter.ToString(this.ixboxConsole_0.GetMemory((uint)(-1006386145 + 328 * i), 2U)).Replace("-", ""), NumberStyles.HexNumber).ToString();
					if (!(text2 == ""))
					{
						this.listBox1.Items.Add(string.Concat(new string[]
						{
							text2,
							" : ",
							text3,
							" Port : ",
							text4
						}));
					}
				}
			}
			if (this.textBox1.Text == "plugin list")
			{
				INI ini = new INI("launch.ini");
				this.ixboxConsole_0.ReceiveFile("./launch.ini", "Hdd:\\launch.ini");
				this.listBox1.Items.Add("Plugin List:");
				this.listBox1.Items.Add("Plugin 1 : " + ini.Read("Plugins", "plugin1"));
				this.listBox1.Items.Add("Plugin 2 : " + ini.Read("Plugins", "plugin2"));
				this.listBox1.Items.Add("Plugin 3 : " + ini.Read("Plugins", "plugin3"));
				this.listBox1.Items.Add("Plugin 4 : " + ini.Read("Plugins", "plugin4"));
				this.listBox1.Items.Add("Plugin 5 : " + ini.Read("Plugins", "plugin5"));
				File.Delete("./launch.ini");
			}
			if (this.textBox1.Text == "title id")
			{
				string str = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
				this.listBox1.Items.Add("Current Title ID : " + str);
			}
			if (this.textBox1.Text.Contains("receive file ") && !this.textBox1.Text.Contains("help") && !this.textBox1.Text.Contains("Help"))
			{
				string text5 = this.textBox1.Text.Split(new char[]
				{
					"receive file ".Last<char>()
				}).Last<string>();
				string str2 = text5.Split(new char[]
				{
					"\\".Last<char>()
				}).Last<string>();
				this.ixboxConsole_0.ReceiveFile("./" + str2, text5);
				this.listBox1.Items.Add("Received File : " + str2);
			}
			if (this.textBox1.Text.Contains("launch title") && !this.textBox1.Text.Contains("help") && !this.textBox1.Text.Contains("Help"))
			{
				string text6 = this.textBox1.Text.Split(new char[]
				{
					"launch title ".Last<char>()
				}).Last<string>();
				int num = text6.LastIndexOf("\\");
				if (num >= 0)
				{
					this.ixboxConsole_0.Reboot(text6, text6.Substring(0, num), null, XboxRebootFlags.Title);
				}
				this.listBox1.Items.Add("Launched Title : " + text6);
			}
			if (this.textBox1.Text.Contains("change text color") && !this.textBox1.Text.Contains("help") && !this.textBox1.Text.Contains("Help"))
			{
				string text7 = this.textBox1.Text.Split(new char[]
				{
					"change text color ".Last<char>()
				}).Last<string>();
				this.listBox1.ForeColor = Color.FromName(text7);
				this.listBox1.Items.Add("Changed Text Color To : " + text7);
			}
			if (this.textBox1.Text.Contains("change background color") && !this.textBox1.Text.Contains("help"))
			{
				string text8 = this.textBox1.Text.Split(new char[]
				{
					"change background color ".Last<char>()
				}).Last<string>();
				this.listBox1.BackColor = Color.FromName(text8);
				this.listBox1.Items.Add("Changed Background Color To : " + text8);
			}
			if (this.textBox1.Text.Contains("get xuid") && !this.textBox1.Text.Contains("help"))
			{
				string str3 = this.method_0(this.textBox1.Text.Split(new char[]
				{
					"Get XUID ".Last<char>()
				}).Last<string>());
				this.listBox1.Items.Add("XUID From Gamertag : " + this.textBox1.Text.Split(new char[]
				{
					"Get XUID ".Last<char>()
				}).Last<string>() + " = " + str3);
			}
			if (this.textBox1.Text == "cpukey")
			{
				string cpukey = this.ixboxConsole_0.GetCPUKey();
				this.listBox1.Items.Add("Your CPUKey : " + cpukey);
			}
			if (this.textBox1.Text == "discordrpc")
			{
				this.listBox1.Items.Add("DiscordRPC is currently " + this.ini_0.Read("Settings", "DiscordRPC"));
			}
			if (this.textBox1.Text == "discordrpc off")
			{
				this.listBox1.Items.Add("DiscordRPC Disabled");
				this.ini_0.Write("Settings", "DiscordRPC", "Disabled");
			}
			if (this.textBox1.Text == "discordrpc on")
			{
				this.listBox1.Items.Add("DiscordRPC Enabled");
				this.ini_0.Write("Settings", "DiscordRPC", "Enabled");
			}
			if (this.textBox1.Text == "screenshot tp clipboard")
			{
				if (File.Exists("screenshot.dds"))
				{
					File.Delete("screenshot.dds");
				}
				this.ixboxConsole_0.ScreenShot("screenshot.dds");
				if (File.Exists("screenshot.dds"))
				{
					Clipboard.SetImage(DDS.LoadImage("screenshot.dds", true));
					File.Delete("screenshot.dds");
				}
				GC.Collect();
				this.listBox1.Items.Add("Copied Screenshot To Clipboard");
			}
			if (this.textBox1.Text == "gamertag")
			{
				string str4 = Encoding.BigEndianUnicode.GetString(this.ixboxConsole_0.GetMemory(2175412476U, 30U)).Trim().Trim(new char[1]) ?? "";
				this.listBox1.Items.Add("Your Gamertag : " + str4);
			}
			if (this.textBox1.Text == "temps")
			{
				this.listBox1.Items.Add("CPU Temp : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.CPU).ToString());
				this.listBox1.Items.Add("GPU Temp : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.GPU).ToString());
				this.listBox1.Items.Add("Motherboard Temp : " + this.ixboxConsole_0.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString());
			}
			if (this.textBox1.Text == "clear console")
			{
				this.listBox1.Items.Clear();
			}
			if (this.textBox1.Text == "Restart")
			{
				Application.Restart();
			}
			if (this.textBox1.Text == "re-connect")
			{
				if (this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
				{
					this.ixboxConsole_0.XNotify("Connected!");
					this.listBox1.Items.Add("Re-Connected Tool To Console");
				}
				else
				{
					this.listBox1.Items.Add("Failed To Re-Connect Tool To Console");
				}
			}
			this.labelControl2.Text = this.textBox1.Text;
			this.textBox1.Text = "";
			this.listBox1.Items.Add("");
			this.listBox1.TopIndex = this.listBox1.Items.Count - 1;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000A4C4 File Offset: 0x000086C4
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000A4E4 File Offset: 0x000086E4
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("This is the Command System Tool! Through here you can execute commands through the tool directly to your console without having to open multiple forms! Execute help to start. You can execute commands by pressing Enter or clicking the button. All commands must be entered in lower, any capitals will be replaced with their lower.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000A504 File Offset: 0x00008704
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = this.labelControl2.Text;
			this.simpleButton100_Click(sender, null);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000A530 File Offset: 0x00008730
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.listBox1.SelectedItem.ToString());
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000077C6 File Offset: 0x000059C6
		static CmdTool()
		{

		}

		// Token: 0x0600002B RID: 43 RVA: 0x000077EB File Offset: 0x000059EB
		internal static bool smethod_0()
		{
			return CmdTool.cmdTool_0 == null;
		}

		// Token: 0x0400000C RID: 12
		private IXboxConsole ixboxConsole_0;

		// Token: 0x0400000D RID: 13
		private INI ini_0;

		// Token: 0x0400001A RID: 26
		private static CmdTool cmdTool_0;
	}
}
