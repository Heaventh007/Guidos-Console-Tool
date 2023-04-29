using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using JRPC_Client;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000013 RID: 19
	public partial class ModuleConfigTool : XtraForm
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x00092150 File Offset: 0x00090350
		public ModuleConfigTool()
		{
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00092178 File Offset: 0x00090378
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

		// Token: 0x06000583 RID: 1411 RVA: 0x000921A8 File Offset: 0x000903A8
		private void ModuleConfigTool_Load(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				try
				{
					this.ixboxConsole_0.DebugTarget.ConnectAsDebugger("jtag", XboxDebugConnectFlags.Force);
					this.simpleButton5_Click(sender, null);
				}
				catch (Exception)
				{
					XtraMessageBox.Show("No connection to your console was found!\nTherefore the tool can not be loaded!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					base.Close();
				}
			}
			this.dataGridView1.BackgroundColor = Color.FromArgb(50, 50, 50);
			this.dataGridView1.ForeColor = Color.Black;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00092240 File Offset: 0x00090440
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00092260 File Offset: 0x00090460
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
			foreach (object obj in this.ixboxConsole_0.DebugTarget.Modules)
			{
				IXboxModule xboxModule = (IXboxModule)obj;
				string name = xboxModule.ModuleInfo.Name;
				string str = "0x";
				XBOX_MODULE_INFO moduleInfo = xboxModule.ModuleInfo;
				string text = str + moduleInfo.BaseAddress.ToString("X");
				string str2 = "0x";
				moduleInfo = xboxModule.ModuleInfo;
				string text2 = str2 + moduleInfo.Size.ToString("X");
				DataGridViewRowCollection rows = this.dataGridView1.Rows;
				object[] array = new object[4];
				array[0] = name;
				array[1] = text;
				array[2] = text2;
				rows.Add(array);
			}
			this.dataGridView1.Sort(this.dataGridView1.Columns[1], ListSortDirection.Ascending);
			this.labelControl8.Text = this.dataGridView1.Rows.Count.ToString();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000923B4 File Offset: 0x000905B4
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					this.textEdit3.Text,
					8,
					0,
					0
				});
				this.simpleButton5_Click(sender, null);
				this.labelControl8.Text = this.dataGridView1.Rows.Count.ToString();
				this.labelControl7.Text = this.textEdit3.Text;
				this.ixboxConsole_0.XNotify("Succesfully injected module!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to inject module, maybe the module you want to inject does not support it.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00092484 File Offset: 0x00090684
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			this.textEdit1.Text = this.dataGridView1.CurrentCell.Value.ToString();
			this.textEdit2.Text = this.dataGridView1.CurrentCell.Value.ToString();
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000924D4 File Offset: 0x000906D4
		private void method_0(string string_0, bool bool_0)
		{
			uint num = this.method_1(string_0);
			if (num > 0U)
			{
				if (bool_0)
				{
					this.ixboxConsole_0.WriteInt16(num + 64U, 1);
				}
				object[] arguments = new object[]
				{
					num
				};
				this.ixboxConsole_0.CallVoid("xboxkrnl.exe", 417, arguments);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00092530 File Offset: 0x00090730
		private uint method_1(string string_0)
		{
			object[] arguments = new object[]
			{
				string_0
			};
			return this.ixboxConsole_0.Call<uint>("xam.xex", 1102, arguments);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00092564 File Offset: 0x00090764
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			try
			{
				this.method_0(this.textEdit1.Text, true);
				this.simpleButton5_Click(sender, null);
				this.labelControl8.Text = this.dataGridView1.Rows.Count.ToString();
				this.labelControl6.Text = this.textEdit1.Text;
				this.ixboxConsole_0.XNotify("Succesfully unloaded module!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to unload module, maybe the module you want to unload does not support it.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00092600 File Offset: 0x00090800
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			try
			{
				this.method_0(this.textEdit2.Text, true);
				Thread.Sleep(100);
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					this.textEdit2.Text,
					8,
					0,
					0
				});
				this.simpleButton5_Click(sender, null);
				this.labelControl8.Text = this.dataGridView1.Rows.Count.ToString();
				this.labelControl5.Text = this.textEdit2.Text;
				this.ixboxConsole_0.XNotify("Successfully reloaded module!");
			}
			catch (Exception)
			{
				XtraMessageBox.Show("Failed to reload module, maybe the module you want to reload does not support it.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000926E8 File Offset: 0x000908E8
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string text = "*" + Path.GetExtension(openFileDialog.FileName);
			openFileDialog.Filter = text + "|" + text;
			openFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.ixboxConsole_0.SendFile(openFileDialog.FileName, "Hdd:\\" + Path.GetFileName(openFileDialog.FileName));
				try
				{
					this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
					{
						"Hdd:\\" + Path.GetFileName(openFileDialog.FileName),
						8,
						0,
						0
					});
					this.simpleButton5_Click(sender, null);
					this.labelControl8.Text = this.dataGridView1.Rows.Count.ToString();
					this.labelControl7.Text = this.textEdit3.Text;
					this.ixboxConsole_0.XNotify("Succesfully injected module!");
				}
				catch (Exception)
				{
					XtraMessageBox.Show("Failed to inject module, maybe the module you want to inject does not support it.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00092840 File Offset: 0x00090A40
		private void checkEdit1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkEdit1.Checked)
			{
				DialogResult dialogResult = XtraMessageBox.Show("This spoofs your current title id to dashboard to allow some modules to load in-game even though they would normally only load on dashboard. This might cause a crash for some modules. Are you sure you want to keep it enabled?", "Warning", MessageBoxButtons.YesNo);
				if (dialogResult != DialogResult.No)
				{
					this.byte_0 = this.ixboxConsole_0.GetMemory(2171470776U, 12U);
					byte[] array = new byte[12];
					Buffer.BlockCopy(BitConverter.GetBytes(1012989950U).Reverse<byte>().ToArray<byte>(), 0, array, 0, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(1617102801U).Reverse<byte>().ToArray<byte>(), 0, array, 4, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(1317011488).Reverse<byte>().ToArray<byte>(), 0, array, 8, 4);
					this.ixboxConsole_0.SetMemory(2171470776U, array);
					this.ixboxConsole_0.XNotify("Spoofed As Dashboard!");
				}
				else
				{
					this.checkEdit1.Checked = false;
				}
			}
			else
			{
				this.ixboxConsole_0.SetMemory(2171470776U, this.byte_0);
				this.ixboxConsole_0.XNotify("Undid Spoofing!\nCurrent Title ID : " + this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X"));
			}
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000936D4 File Offset: 0x000918D4
		static ModuleConfigTool()
		{
			ModuleConfigTool.GrabbedClients = new List<Form1>();
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000078B9 File Offset: 0x00005AB9
		internal static bool smethod_0()
		{
			return ModuleConfigTool.moduleConfigTool_0 == null;
		}

		// Token: 0x040008C3 RID: 2243
		private IXboxConsole ixboxConsole_0;

		// Token: 0x040008C4 RID: 2244
		public static List<Form1> GrabbedClients;

		// Token: 0x040008C5 RID: 2245
		private byte[] byte_0;

		// Token: 0x040008DE RID: 2270
		internal static ModuleConfigTool moduleConfigTool_0;
	}
}
