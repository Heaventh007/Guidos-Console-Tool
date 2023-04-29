using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using JRPC_Client;
using ToolSettings;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000009 RID: 9
	public partial class FileBrowser : XtraForm
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00017E64 File Offset: 0x00016064
		public FileBrowser()
		{
			this.bool_0 = false;
			this.list_0 = new List<string>();
			this.ini_0 = new INI("ToolSettings.ini");
			this.ini_1 = new INI("GameLauncher.ini");
			this.string_1 = "";
			this.icontainer_0 = null;
			
			this.InitializeComponent();
			this.listView1.MouseDoubleClick += this.listView1_MouseDoubleClick;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00017EE0 File Offset: 0x000160E0
		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.string_1.Contains(".xex"))
			{
				string text = this.textEdit1.Text;
				int num = text.LastIndexOf("\\");
				if (num >= 0)
				{
					this.ixboxConsole_0.Reboot(this.textEdit1.Text, this.textEdit1.Text.Substring(0, num), null, XboxRebootFlags.Title);
				}
			}
			else if (this.string_1.Contains("."))
			{
				XtraMessageBox.Show("Can't open a file.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.listView1.SuspendLayout();
				try
				{
					this.listView1.Items.Clear();
					this.imageList_0.ImageSize = new Size(55, 55);
					if (this.bool_0)
					{
						if (this.textEdit1.Text.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>().Contains("."))
						{
							this.textEdit1.Text = this.textEdit1.Text.Replace(this.textEdit1.Text.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), "");
						}
						this.textEdit1.Text = this.textEdit1.Text + this.string_1 + "\\";
					}
					if (this.textEdit1.Text.EndsWith(":\\"))
					{
						this.bool_0 = true;
					}
					IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
					foreach (object obj in xboxFiles)
					{
						IXboxFile xboxFile = (IXboxFile)obj;
						if (!xboxFile.Name.Contains("."))
						{
							if (!xboxFile.IsDirectory)
							{
								this.imageList_0.Images.Add(Resources.nothingimage);
								this.listView1.Items.Add(xboxFile.Name.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>(), this.imageList_0.Images.Count - 1);
							}
							else
							{
								this.imageList_0.Images.Add(Resources.folderimage);
								this.listView1.Items.Add(xboxFile.Name.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>(), this.imageList_0.Images.Count - 1);
							}
						}
						if (xboxFile.Name.Contains(".xex"))
						{
							this.imageList_0.Images.Add(Resources.xeximage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
						if (xboxFile.Name.Contains(".txt") || xboxFile.Name.Contains(".log"))
						{
							this.imageList_0.Images.Add(Resources.txtorlog);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
						if (xboxFile.Name.Contains(".ini"))
						{
							this.imageList_0.Images.Add(Resources.iniimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
						if (xboxFile.Name.Contains(".webm"))
						{
							this.imageList_0.Images.Add(Resources.webmimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
						if (!xboxFile.Name.Contains(".xex") && !xboxFile.Name.Contains(".txt") && !xboxFile.Name.Contains(".log") && !xboxFile.Name.Contains(".ini") && !xboxFile.Name.Contains(".webm") && xboxFile.Name.Contains("."))
						{
							this.imageList_0.Images.Add(Resources.nothingimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
					}
					this.listView1.Sorting = SortOrder.Ascending;
				}
				catch (Exception)
				{
				}
				this.listView1.ResumeLayout();
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000184A8 File Offset: 0x000166A8
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

		// Token: 0x060000A3 RID: 163 RVA: 0x000184D8 File Offset: 0x000166D8
		private void FileBrowser_Load(object sender, EventArgs e)
		{
			if (this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				this.textEdit1.Text = "";
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				foreach (string fileName in this.ixboxConsole_0.Drives.Split(new char[]
				{
					",".Last<char>()
				}))
				{
					this.imageList_0.Images.Add(Resources.driverimage);
					FileInfo fileInfo = new FileInfo(fileName);
					this.listView1.Items.Add(fileInfo.Name + ":\\", this.imageList_0.Images.Count - 1);
				}
			}
			else
			{
				XtraMessageBox.Show("No connection to console was found, therefore the options in the tool will not work!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000185DC File Offset: 0x000167DC
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.textEdit1.Text = "";
			this.listView1.Items.Clear();
			this.imageList_0.ImageSize = new Size(55, 55);
			this.listView1.SuspendLayout();
			foreach (string fileName in this.ixboxConsole_0.Drives.Split(new char[]
			{
				",".Last<char>()
			}))
			{
				this.imageList_0.Images.Add(Resources.driverimage);
				FileInfo fileInfo = new FileInfo(fileName);
				this.listView1.Items.Add(fileInfo.Name + ":\\", this.imageList_0.Images.Count - 1);
			}
			this.listView1.ResumeLayout();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000186CC File Offset: 0x000168CC
		private void method_0()
		{
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (!xboxFile.Name.Contains("."))
					{
						if (!xboxFile.IsDirectory)
						{
							this.imageList_0.Images.Add(Resources.nothingimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
						else
						{
							this.imageList_0.Images.Add(Resources.folderimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
					}
					if (xboxFile.Name.Contains(".xex"))
					{
						this.imageList_0.Images.Add(Resources.xeximage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".txt") || xboxFile.Name.Contains(".log"))
					{
						this.imageList_0.Images.Add(Resources.txtorlog);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".ini"))
					{
						this.imageList_0.Images.Add(Resources.iniimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".webm"))
					{
						this.imageList_0.Images.Add(Resources.webmimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (!xboxFile.Name.Contains(".xex") && !xboxFile.Name.Contains(".txt") && !xboxFile.Name.Contains(".log") && !xboxFile.Name.Contains(".ini") && !xboxFile.Name.Contains(".webm") && xboxFile.Name.Contains("."))
					{
						this.imageList_0.Images.Add(Resources.nothingimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.ResumeLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00018B34 File Offset: 0x00016D34
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			string text = "*" + Path.GetExtension(openFileDialog.FileName);
			openFileDialog.Filter = text + "|" + text;
			openFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (this.textEdit1.Text.Split(new char[]
				{
					"\\".Last<char>()
				}).Last<string>().Contains("."))
				{
					XtraMessageBox.Show("You cant' send a file to a file, make sure a folder is selected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.ixboxConsole_0.SendFile(openFileDialog.FileName, this.textEdit1.Text + Path.GetFileName(openFileDialog.FileName));
				}
			}
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (!xboxFile.Name.Contains("."))
					{
						this.imageList_0.Images.Add(Resources.folderimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".xex"))
					{
						this.imageList_0.Images.Add(Resources.xeximage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".txt") || xboxFile.Name.Contains(".log"))
					{
						this.imageList_0.Images.Add(Resources.txtorlog);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".ini"))
					{
						this.imageList_0.Images.Add(Resources.iniimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".webm"))
					{
						this.imageList_0.Images.Add(Resources.webmimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (!xboxFile.Name.Contains(".xex") && !xboxFile.Name.Contains(".txt") && !xboxFile.Name.Contains(".log") && !xboxFile.Name.Contains(".ini") && !xboxFile.Name.Contains(".webm") && xboxFile.Name.Contains("."))
					{
						this.imageList_0.Images.Add(Resources.nothingimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.ResumeLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00018FFC File Offset: 0x000171FC
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to delete this file?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult != DialogResult.Yes)
			{
				if (dialogResult != DialogResult.No)
				{
				}
			}
			else if (this.string_1.Contains("."))
			{
				this.ixboxConsole_0.DeleteFile(this.textEdit1.Text);
				string text = this.textEdit1.Text;
				int num = text.LastIndexOf("\\");
				if (num >= 0)
				{
					this.textEdit1.Text = this.textEdit1.Text.Substring(0, num);
				}
				if (!this.textEdit1.Text.Contains("\\"))
				{
					this.textEdit1.Text = this.textEdit1.Text + "\\";
				}
				this.method_0();
			}
			else
			{
				XtraMessageBox.Show("This is not a file.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000190F8 File Offset: 0x000172F8
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			string str = this.textEdit1.Text.Split(new char[]
			{
				'\\'
			}).Last<string>();
			new Form1();
			if (!this.string_1.Contains("."))
			{
				XtraMessageBox.Show("Selected item is not a file so can not be copied to game launcher!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				string text = this.textEdit1.Text;
				int num = text.LastIndexOf("\\");
				if (num >= 0)
				{
					this.string_0 = this.textEdit1.Text.Substring(0, num);
				}
				string str2 = this.string_0.Split(new char[]
				{
					"\\".Last<char>()
				}).Last<string>();
				this.ini_1.Write(str2 + "p1", "Path1", this.textEdit1.Text.Substring(0, num) + "\\" + str);
				this.ini_1.Write(str2 + "p2", "Path2", this.textEdit1.Text.Substring(0, num));
				string contents = str2 + Environment.NewLine;
				File.AppendAllText("GameNames.txt", contents);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00019240 File Offset: 0x00017440
		private void simpleButton7_Click(object sender, EventArgs e)
		{
			string text = this.textEdit1.Text;
			int num = text.LastIndexOf("\\");
			if (num >= 0)
			{
				if (this.string_1.Contains(".xex"))
				{
					this.ixboxConsole_0.Reboot(this.textEdit1.Text, this.textEdit1.Text.Substring(0, num), null, XboxRebootFlags.Title);
				}
				else
				{
					MessageBox.Show("Selected file is not an xex file!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000192C4 File Offset: 0x000174C4
		private void simpleButton8_Click(object sender, EventArgs e)
		{
			try
			{
				if (!this.string_1.Contains("."))
				{
					XtraMessageBox.Show("Selected item is not a file!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
					{
						this.textEdit1.Text,
						8,
						0,
						0
					});
					this.ixboxConsole_0.XNotify("Succesfully injected module!");
				}
			}
			catch
			{
				XtraMessageBox.Show("Failed to inject module, maybe the module you want to inject does not support it.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0001937C File Offset: 0x0001757C
		private void simpleButton9_Click(object sender, EventArgs e)
		{
			string str = this.textEdit1.Text.Split(new char[]
			{
				'\\'
			}).Last<string>();
			if (!this.string_1.Contains("."))
			{
				XtraMessageBox.Show("Selected item is not a file!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.ixboxConsole_0.ReceiveFile("./" + str, this.textEdit1.Text);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000193F4 File Offset: 0x000175F4
		private void simpleButton10_Click(object sender, EventArgs e)
		{
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (xboxFile.Name.Contains(".xex"))
					{
						this.imageList_0.Images.Add(Resources.xeximage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.ResumeLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00019548 File Offset: 0x00017748
		private void simpleButton11_Click(object sender, EventArgs e)
		{
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (xboxFile.Name.Contains(".ini"))
					{
						this.imageList_0.Images.Add(Resources.iniimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.ResumeLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0001969C File Offset: 0x0001789C
		private void simpleButton12_Click(object sender, EventArgs e)
		{
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (xboxFile.Name.Contains(".xex"))
					{
						this.imageList_0.Images.Add(Resources.xeximage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".txt") || xboxFile.Name.Contains(".log"))
					{
						this.imageList_0.Images.Add(Resources.txtorlog);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".ini"))
					{
						this.imageList_0.Images.Add(Resources.iniimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".webm"))
					{
						this.imageList_0.Images.Add(Resources.webmimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (!xboxFile.Name.Contains(".xex") && !xboxFile.Name.Contains(".txt") && !xboxFile.Name.Contains(".log") && !xboxFile.Name.Contains(".ini") && !xboxFile.Name.Contains(".webm") && xboxFile.Name.Contains("."))
					{
						this.imageList_0.Images.Add(Resources.nothingimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.ResumeLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00019A28 File Offset: 0x00017C28
		private void simpleButton13_Click(object sender, EventArgs e)
		{
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (!xboxFile.Name.Contains("."))
					{
						this.imageList_0.Images.Add(Resources.folderimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.ResumeLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00019B80 File Offset: 0x00017D80
		private void simpleButton100_Click(object sender, EventArgs e)
		{
			try
			{
				this.listView1.Items.Clear();
				this.imageList_0.ImageSize = new Size(55, 55);
				if (this.bool_0)
				{
					this.textEdit1.Text = this.textEdit1.Text + this.string_1 + "\\";
				}
				if (this.textEdit1.Text.EndsWith(":\\"))
				{
					this.bool_0 = true;
				}
				this.listView1.SuspendLayout();
				IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(this.textEdit1.Text);
				foreach (object obj in xboxFiles)
				{
					IXboxFile xboxFile = (IXboxFile)obj;
					if (!xboxFile.Name.Contains("."))
					{
						if (!xboxFile.IsDirectory)
						{
							this.imageList_0.Images.Add(Resources.nothingimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
						else
						{
							this.imageList_0.Images.Add(Resources.folderimage);
							this.listView1.Items.Add(xboxFile.Name.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>(), this.imageList_0.Images.Count - 1);
						}
					}
					if (xboxFile.Name.Contains(".xex"))
					{
						this.imageList_0.Images.Add(Resources.xeximage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".txt") || xboxFile.Name.Contains(".log"))
					{
						this.imageList_0.Images.Add(Resources.txtorlog);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".ini"))
					{
						this.imageList_0.Images.Add(Resources.iniimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (xboxFile.Name.Contains(".webm"))
					{
						this.imageList_0.Images.Add(Resources.webmimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
					if (!xboxFile.Name.Contains(".xex") || !xboxFile.Name.Contains(".txt") || !xboxFile.Name.Contains(".log") || !xboxFile.Name.Contains(".ini") || !xboxFile.Name.Contains(".webm"))
					{
						this.imageList_0.Images.Add(Resources.nothingimage);
						this.listView1.Items.Add(xboxFile.Name.Split(new char[]
						{
							"\\".Last<char>()
						}).Last<string>(), this.imageList_0.Images.Count - 1);
					}
				}
				this.listView1.Sorting = SortOrder.Ascending;
				this.listView1.SuspendLayout();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0001A020 File Offset: 0x00018220
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (this.textEdit1.Text.EndsWith("\\"))
			{
				this.textEdit1.Text = this.textEdit1.Text.Remove(this.textEdit1.Text.Length - 1);
			}
			string text = this.textEdit1.Text;
			int num = text.LastIndexOf("\\");
			if (num >= 0)
			{
				this.textEdit1.Text = this.textEdit1.Text.Substring(0, num);
			}
			if (!this.textEdit1.Text.Contains("\\"))
			{
				this.textEdit1.Text = this.textEdit1.Text + "\\";
			}
			try
			{
				if (!this.string_1.Contains("."))
				{
					this.method_0();
				}
			}
			catch (Exception)
			{
			}
			if (!this.textEdit1.Text.EndsWith("\\"))
			{
				this.textEdit1.Text = this.textEdit1.Text + "\\";
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0001A15C File Offset: 0x0001835C
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedIndices.Count > 0)
				{
					int num = this.listView1.SelectedIndices[0];
					if (num >= 0)
					{
						string text = this.listView1.Items[num].Text;
						this.string_1 = text;
						if (this.string_1.EndsWith(":\\"))
						{
							this.textEdit1.Text = this.string_1;
						}
						if (this.string_1.Contains("."))
						{
							if (this.textEdit1.Text.Split(new char[]
							{
								"\\".Last<char>()
							}).Last<string>().Contains("."))
							{
								string oldValue = this.textEdit1.Text.Split(new char[]
								{
									"\\".Last<char>()
								}).Last<string>();
								this.textEdit1.Text = this.textEdit1.Text.Replace(oldValue, this.string_1);
							}
							else
							{
								this.textEdit1.Text = this.textEdit1.Text + this.string_1;
							}
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0001A2C8 File Offset: 0x000184C8
		private void simpleButton14_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0001A2DC File Offset: 0x000184DC
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			if (this.textEdit2.Text.Contains("\\") || this.textEdit2.Text.Contains("."))
			{
				XtraMessageBox.Show("Invalid directory name.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				if (!this.textEdit1.Text.Split(new char[]
				{
					"\\".Last<char>()
				}).Last<string>().Contains("."))
				{
					try
					{
						string str = this.textEdit1.Text;
						if (!this.textEdit1.Text.EndsWith("\\"))
						{
							str = this.textEdit1.Text + "\\";
						}
						this.ixboxConsole_0.MakeDirectory(str + this.textEdit2.Text);
						this.method_0();
						return;
					}
					catch (Exception)
					{
						return;
					}
				}
				XtraMessageBox.Show("A file can not be selected when creating a directory.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.simpleButton2_Click(sender, null);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0001A3F8 File Offset: 0x000185F8
		private void simpleButton15_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = XtraMessageBox.Show("Are you sure you want to delete this directory?", "Warning", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (!this.textEdit1.Text.Split(new char[]
				{
					"\\".Last<char>()
				}).Last<string>().Contains("."))
				{
					this.method_1(this.textEdit1.Text + this.string_1);
					this.method_0();
				}
				else
				{
					XtraMessageBox.Show("A file can not be selected when removing a directory.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this.simpleButton2_Click(sender, null);
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0001A494 File Offset: 0x00018694
		private void method_1(string string_2)
		{
			IXboxFiles xboxFiles = this.ixboxConsole_0.DirectoryFiles(string_2);
			foreach (object obj in xboxFiles)
			{
				IXboxFile xboxFile = (IXboxFile)obj;
				if (!xboxFile.IsDirectory)
				{
					this.ixboxConsole_0.DeleteFile(xboxFile.Name);
				}
				else
				{
					this.method_1(xboxFile.Name);
				}
			}
			this.ixboxConsole_0.RemoveDirectory(string_2);
			this.method_0();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000077C6 File Offset: 0x000059C6
		static FileBrowser()
		{
			
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007809 File Offset: 0x00005A09
		internal static bool smethod_0()
		{
			return FileBrowser.fileBrowser_0 == null;
		}

		// Token: 0x04000101 RID: 257
		private bool bool_0;

		// Token: 0x04000102 RID: 258
		private IXboxConsole ixboxConsole_0;

		// Token: 0x04000103 RID: 259
		private List<string> list_0;

		// Token: 0x04000104 RID: 260
		private INI ini_0;

		// Token: 0x04000105 RID: 261
		private INI ini_1;

		// Token: 0x04000106 RID: 262
		private string string_0;

		// Token: 0x04000107 RID: 263
		public string path;

		// Token: 0x04000108 RID: 264
		private string string_1;

		// Token: 0x04000123 RID: 291
		internal static FileBrowser fileBrowser_0;
	}
}
