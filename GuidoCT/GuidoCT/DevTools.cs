using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using JRPC_Client;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000008 RID: 8
	public partial class DevTools : XtraForm
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00015510 File Offset: 0x00013710
		public DevTools()
		{
			this.timer_0 = new Timer();
			this.timer_1 = new Timer();
			this.timer_2 = new Timer();
			this.string_1 = "";
			this.bool_0 = false;
			this.string_2 = "";
			this.string_3 = "";
			this.bool_1 = false;
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00015588 File Offset: 0x00013788
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

		// Token: 0x0600008B RID: 139 RVA: 0x000155B8 File Offset: 0x000137B8
		private void DevTools_Load(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				this.labelControl8.Text = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
			}
			else
			{
				XtraMessageBox.Show("No connection to console was found, therefore the options in the tool will not work!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00015618 File Offset: 0x00013818
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Cold);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00015634 File Offset: 0x00013834
		private void simpleButton7_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.textEdit_2.Text.EndsWith("U"))
				{
					string text = this.textEdit_2.Text;
					string str = uint.Parse(text).ToString("X");
					this.textEdit_2.Text = "0x" + str;
				}
				else
				{
					this.textEdit_2.Text = this.textEdit_2.Text.Remove(this.textEdit_2.Text.Length - 1, 1);
					string text2 = this.textEdit_2.Text;
					string str2 = uint.Parse(text2).ToString("X");
					this.textEdit_2.Text = "0x" + str2;
				}
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Exception Caught! Exception:\n" + ex.Message, "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00015734 File Offset: 0x00013934
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.SetMemory(Convert.ToUInt32(this.textEdit_0.Text, 16), Encoding.ASCII.GetBytes(this.textEdit5.Text));
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Exception Caught! Exception:\n" + ex.Message, "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000157AC File Offset: 0x000139AC
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.WriteFloat(Convert.ToUInt32(this.textEdit1.Text, 16), float.Parse(this.textEdit6.Text));
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Exception Caught! Exception:\n" + ex.Message, "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0001581C File Offset: 0x00013A1C
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.WriteString(Convert.ToUInt32(this.textEdit4.Text, 16), this.textEdit7.Text);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00015854 File Offset: 0x00013A54
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(Convert.ToUInt32(this.textEdit3.Text, 16), new object[]
			{
				0,
				this.textEdit8.Text
			});
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0001589C File Offset: 0x00013A9C
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.ixboxConsole_0.ReadString(Convert.ToUInt32(this.textEdit2.Text, 16), Convert.ToUInt32(this.textEdit9.Text, 16));
				this.textEdit_1.Text = text;
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show("Exception Caught! Exception:\n" + ex.Message, "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00015920 File Offset: 0x00013B20
		private void simpleButton8_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(this.ixboxConsole_0.ResolveFunction(this.textEdit_4.Text, Convert.ToUInt32(this.textEdit_3.Text)), new object[]
			{
				0
			});
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00015970 File Offset: 0x00013B70
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.listBoxControl1.Items.Clear();
			try
			{
				this.ixboxConsole_0.ReceiveFile("./Debug.txt", this.debugpath);
				foreach (string item in File.ReadAllLines("./Debug.txt"))
				{
					this.listBoxControl1.Items.Add(item);
				}
				if (this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X") != this.string_0)
				{
					this.listBoxControl1.Items.Add("Title ID Changed From " + this.string_0 + " To : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X"));
				}
				this.string_0 = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
				this.listBoxControl1.TopIndex = this.listBoxControl1.Items.Count - 1;
			}
			catch (Exception)
			{
			}
			if (File.Exists("./Debug.txt"))
			{
				File.Delete("./Debug.txt");
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00015AA8 File Offset: 0x00013CA8
		private void simpleButton9_Click(object sender, EventArgs e)
		{
			this.timer_2.Stop();
			this.timer_1.Stop();
			if (File.Exists("./Debug.txt"))
			{
				File.Delete("./Debug.txt");
			}
			if (this.textEdit_5.Text == "")
			{
				XtraMessageBox.Show("You haven't entered a path for the log file.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (!this.textEdit_5.Text.Contains(".txt") && !this.textEdit_5.Text.Contains(".log"))
			{
				XtraMessageBox.Show("The path you have entered does not contain a .log or a .txt file.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.debugpath = this.textEdit_5.Text;
				try
				{
					if (!(this.simpleButton9.Text == "Start Logging"))
					{
						this.simpleButton9.Text = "Start Logging";
						this.timer_0.Stop();
					}
					else
					{
						this.simpleButton9.Text = "Stop Logging";
						this.string_0 = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
						this.ixboxConsole_0.ReceiveFile("./Debug.txt", this.debugpath);
						this.timer_0.Interval = 5000;
						this.timer_0.Tick += this.timer_0_Tick;
						this.timer_0.Start();
					}
					if (File.Exists("./Debug.txt"))
					{
						File.Delete("./Debug.txt");
					}
				}
				catch (Exception)
				{
					XtraMessageBox.Show("An error occured when trying to start the debugger, make sure the file actually exists.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00015C58 File Offset: 0x00013E58
		private void timer_2_Tick(object sender, EventArgs e)
		{
			foreach (object obj in this.ixboxConsole_0.DebugTarget.Modules)
			{
				IXboxModule xboxModule = (IXboxModule)obj;
				if (!this.listBoxControl1.Items.Contains(xboxModule.ModuleInfo.Name))
				{
					string name = xboxModule.ModuleInfo.Name;
					this.string_1 = this.string_1 + name + ", ";
					this.bool_0 = true;
				}
			}
			if (this.bool_0)
			{
				this.string_1 = this.string_1.Remove(this.string_1.Length - 2, 1);
				this.ixboxConsole_0.XNotify("New Modules : " + this.string_1);
			}
			this.listBoxControl1.Items.Clear();
			try
			{
				foreach (object obj2 in this.ixboxConsole_0.DebugTarget.Modules)
				{
					IXboxModule xboxModule2 = (IXboxModule)obj2;
					this.listBoxControl1.Items.Add(xboxModule2.ModuleInfo.Name);
				}
			}
			catch
			{
			}
			this.listBoxControl1.SortOrder = SortOrder.Ascending;
			this.bool_0 = false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00015DFC File Offset: 0x00013FFC
		private void simpleButton10_Click(object sender, EventArgs e)
		{
			this.timer_1.Stop();
			this.timer_0.Stop();
			this.listBoxControl1.Items.Clear();
			try
			{
				if (!(this.simpleButton10.Text == "Start Module Logging"))
				{
					this.simpleButton10.Text = "Start Module Logging";
					this.timer_2.Stop();
				}
				else
				{
					this.ixboxConsole_0.DebugTarget.ConnectAsDebugger(null, XboxDebugConnectFlags.Force);
					foreach (object obj in this.ixboxConsole_0.DebugTarget.Modules)
					{
						IXboxModule xboxModule = (IXboxModule)obj;
						this.listBoxControl1.Items.Add(xboxModule.ModuleInfo.Name);
					}
					this.listBoxControl1.SortOrder = SortOrder.Ascending;
					this.simpleButton10.Text = "Stop Module Logging";
					this.timer_2.Interval = 10000;
					this.timer_2.Tick += this.timer_2_Tick;
					this.timer_2.Start();
				}
			}
			catch (Exception)
			{
				XtraMessageBox.Show("An error occured when trying to start the debugger.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00015F7C File Offset: 0x0001417C
		private void timer_1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (this.string_2 != this.string_3)
				{
					if (!(this.string_2 != "") || !(this.string_3 != ""))
					{
						if (!this.bool_1)
						{
							this.listBoxControl1.Items.Add("Title ID Debugger Started!");
							this.listBoxControl1.Items.Add("Current Title ID Is " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X"));
							this.bool_1 = true;
						}
					}
					else
					{
						this.listBoxControl1.Items.Add("Title ID Changed From " + this.string_2 + " To " + this.string_3);
					}
				}
				this.string_2 = this.string_3;
				this.string_3 = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
				this.listBoxControl1.TopIndex = this.listBoxControl1.Items.Count - 1;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000160BC File Offset: 0x000142BC
		private void simpleButton11_Click(object sender, EventArgs e)
		{
			this.timer_2.Stop();
			this.timer_0.Stop();
			this.listBoxControl1.Items.Clear();
			try
			{
				if (this.simpleButton11.Text == "Start Title ID Logging")
				{
					this.simpleButton11.Text = "Stop Title ID Logging";
					this.string_2 = this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X");
					this.timer_1.Interval = 5000;
					this.timer_1.Tick += this.timer_1_Tick;
					this.timer_1.Start();
				}
				else
				{
					this.simpleButton11.Text = "Start Title ID Logging";
					this.timer_1.Stop();
				}
			}
			catch (Exception)
			{
				XtraMessageBox.Show("An error occured when trying to start the debugger.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000161AC File Offset: 0x000143AC
		private void simpleButton12_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to spoof title id? There is no check to see the if its an existing title id. This might cause a crash for some modules. Are you sure you want to keep it enabled?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.byte_0 = this.ixboxConsole_0.GetMemory(2171470776U, 12U);
				uint num = Convert.ToUInt32(this.textEdit_6.Text, 16);
				byte[] array = new byte[12];
				Buffer.BlockCopy(BitConverter.GetBytes(1012924416U | num >> 16).Reverse<byte>().ToArray<byte>(), 0, array, 0, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(1617100800U | (num & 65535U)).Reverse<byte>().ToArray<byte>(), 0, array, 4, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(1317011488).Reverse<byte>().ToArray<byte>(), 0, array, 8, 4);
				this.ixboxConsole_0.SetMemory(2171470776U, array);
				this.ixboxConsole_0.XNotify("Spoofed To : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X"));
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000162B4 File Offset: 0x000144B4
		private void simpleButton21_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.SetMemory(2171470776U, this.byte_0);
			this.ixboxConsole_0.XNotify("Undid Spoofing!\nCurrent Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X"));
			this.textEdit_6.Text = "0x";
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000077C6 File Offset: 0x000059C6
		static DevTools()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000077FF File Offset: 0x000059FF
		internal static bool smethod_0()
		{
			return DevTools.devTools_0 == null;
		}

		// Token: 0x040000C6 RID: 198
		private IXboxConsole ixboxConsole_0;

		// Token: 0x040000C7 RID: 199
		public bool TimerEnabled;

		// Token: 0x040000C8 RID: 200
		private Timer timer_0;

		// Token: 0x040000C9 RID: 201
		private Timer timer_1;

		// Token: 0x040000CA RID: 202
		private Timer timer_2;

		// Token: 0x040000CB RID: 203
		public string debugpath;

		// Token: 0x040000CC RID: 204
		private string string_0;

		// Token: 0x040000CD RID: 205
		private string string_1;

		// Token: 0x040000CE RID: 206
		private bool bool_0;

		// Token: 0x040000CF RID: 207
		private string string_2;

		// Token: 0x040000D0 RID: 208
		private string string_3;

		// Token: 0x040000D1 RID: 209
		private bool bool_1;

		// Token: 0x040000D2 RID: 210
		private byte[] byte_0;

		// Token: 0x04000100 RID: 256
		internal static DevTools devTools_0;
	}
}
