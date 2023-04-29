using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GuidoCT.Properties;
using JRPC_Client;
using ToolSettings;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x02000014 RID: 20
	public partial class ModuleLibTool : XtraForm
	{
		// Token: 0x06000592 RID: 1426 RVA: 0x000936F8 File Offset: 0x000918F8
		public ModuleLibTool()
		{
			this.string_0 = "";
			this.ini_0 = new INI("ToolSettings.ini");
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00093738 File Offset: 0x00091938
		private void ModuleLibTool_Load(object sender, EventArgs e)
		{
			if (!this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				XtraMessageBox.Show("No connection to console was found, therefore the options in the tool will not work!", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00093770 File Offset: 0x00091970
		private uint method_0(string string_1)
		{
			object[] arguments = new object[]
			{
				string_1
			};
			return this.ixboxConsole_0.Call<uint>("xam.xex", 1102, arguments);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000937A4 File Offset: 0x000919A4
		private void method_1(string string_1, bool bool_0)
		{
			uint num = this.method_0(string_1);
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

		// Token: 0x06000596 RID: 1430 RVA: 0x00093800 File Offset: 0x00091A00
		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (!(this.string_0 == ""))
			{
				this.method_1(this.string_0, true);
				this.ixboxConsole_0.XNotify("Module Unloaded : " + this.string_0);
			}
			else
			{
				XtraMessageBox.Show("No last injected module could be found.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0009385C File Offset: 0x00091A5C
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

		// Token: 0x06000598 RID: 1432 RVA: 0x0009388C File Offset: 0x00091A8C
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			ModuleConfigTool moduleConfigTool = new ModuleConfigTool();
			moduleConfigTool.Show();
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000938A8 File Offset: 0x00091AA8
		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (this.ini_0.Read("Settings", "XDKMode") == "Enabled")
			{
				XtraMessageBox.Show("Ninja V2 Engines can not be injected while using XDK Mode.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (this.comboBoxEdit1.SelectedItem.ToString() == "")
			{
				XtraMessageBox.Show("No engine selected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				string text = this.comboBoxEdit1.SelectedItem.ToString();
				this.string_0 = text;
				if (this.comboBoxEdit1.SelectedItem.ToString() == "AW.xex")
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123938432958545/AW.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "BO1.xex")
				{
					WebClient webClient2 = new WebClient();
					webClient2.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123938734932088/BO1.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "BO2.xex")
				{
					WebClient webClient3 = new WebClient();
					webClient3.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123939087274004/BO2.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "BO3.xex")
				{
					WebClient webClient4 = new WebClient();
					webClient4.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123936319021096/BO3.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "GHO.xex")
				{
					WebClient webClient5 = new WebClient();
					webClient5.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123936704888872/GHO.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "MW1.xex")
				{
					WebClient webClient6 = new WebClient();
					webClient6.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123937032065076/MW1.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "MW2.xex")
				{
					WebClient webClient7 = new WebClient();
					webClient7.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123937422118962/MW2.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "MW3.xex")
				{
					WebClient webClient8 = new WebClient();
					webClient8.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123937816379442/MW3.xex", text);
				}
				if (this.comboBoxEdit1.SelectedItem.ToString() == "WAW.xex")
				{
					WebClient webClient9 = new WebClient();
					webClient9.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014123938130960394/WAW.xex", text);
				}
				this.ixboxConsole_0.SendFile("./" + text, "Hdd:\\" + text);
				try
				{
					this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
					{
						"Hdd:\\" + text,
						8,
						0,
						0
					});
					this.ixboxConsole_0.XNotify("Injected Module : " + text);
				}
				catch
				{
					this.ixboxConsole_0.XNotify("Failed to inject module.");
				}
				File.Delete("./" + text);
				this.ixboxConsole_0.DeleteFile("Hdd:\\" + text);
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00093BC4 File Offset: 0x00091DC4
		private void simpleButton4_Click(object sender, EventArgs e)
		{
			if (!(this.comboBoxEdit2.SelectedItem.ToString() == ""))
			{
				string text = this.comboBoxEdit2.SelectedItem.ToString();
				this.string_0 = text;
				if (this.comboBoxEdit2.SelectedItem.ToString() == "BO1.ENGINE.xex")
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127718431985705/BO1.ENGINE.xex", text);
				}
				if (this.comboBoxEdit2.SelectedItem.ToString() == "BO2.ENGINE.xex")
				{
					WebClient webClient2 = new WebClient();
					webClient2.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127715839909909/BO2.ENGINE.xex", text);
				}
				if (this.comboBoxEdit2.SelectedItem.ToString() == "GHOSTS.ENGINE.xex")
				{
					WebClient webClient3 = new WebClient();
					webClient3.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127716225781800/GHOSTS.ENGINE.xex", text);
				}
				if (this.comboBoxEdit2.SelectedItem.ToString() == "MW1.ENGINE.xex")
				{
					WebClient webClient4 = new WebClient();
					webClient4.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127716842352671/MW1.ENGINE.xex", text);
				}
				if (this.comboBoxEdit2.SelectedItem.ToString() == "MW2.ENGINE.xex")
				{
					WebClient webClient5 = new WebClient();
					webClient5.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127717203054632/MW2.ENGINE.xex", text);
				}
				if (this.comboBoxEdit2.SelectedItem.ToString() == "MW3.ENGINE.xex")
				{
					WebClient webClient6 = new WebClient();
					webClient6.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127717664436284/MW3.ENGINE.xex", text);
				}
				if (this.comboBoxEdit2.SelectedItem.ToString() == "WAW.ENGINE.xex")
				{
					WebClient webClient7 = new WebClient();
					webClient7.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1014127718079660032/WAW.ENGINE.xex", text);
				}
				this.ixboxConsole_0.SendFile("./" + text, "Hdd:\\" + text);
				try
				{
					this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
					{
						"Hdd:\\" + text,
						8,
						0,
						0
					});
					this.ixboxConsole_0.XNotify("Injected Module : " + text);
				}
				catch
				{
					this.ixboxConsole_0.XNotify("Failed to inject module.");
				}
				File.Delete("./" + text);
				this.ixboxConsole_0.DeleteFile("Hdd:\\" + text);
			}
			else
			{
				XtraMessageBox.Show("No engine selected.", "Guido's Console Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00093E44 File Offset: 0x00092044
		private void simpleButton6_Click(object sender, EventArgs e)
		{
			this.string_0 = "Appendum.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992515274408468491/Appendum.xex", "./Appendum.xex");
			this.ixboxConsole_0.SendFile("./Appendum.xex", "Hdd:\\Appendum.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Appendum.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Appendum");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Appendum.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Appendum.xex");
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00093F18 File Offset: 0x00092118
		private void simpleButton5_Click(object sender, EventArgs e)
		{
			this.string_0 = "Myten_V1.2.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992516490911821864/Myten_V1.2.xex", "./Myten_V1.2.xex");
			this.ixboxConsole_0.SendFile("./Myten_V1.2.xex", "Hdd:\\Myten_V1.2.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Myten_V1.2.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Myten_V1.2");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Myten_V1.2.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Myten_V1.2.xex");
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00093FEC File Offset: 0x000921EC
		private void simpleButton8_Click(object sender, EventArgs e)
		{
			this.string_0 = "Frostbite.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992513396438212618/Frostbite.xex", "./Frostbite.xex");
			this.ixboxConsole_0.SendFile("./Frostbite.xex", "Hdd:\\Frostbite.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Frostbite.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Frostbite");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Frostbite.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Frostbite.xex");
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000940C0 File Offset: 0x000922C0
		private void simpleButton9_Click(object sender, EventArgs e)
		{
			this.string_0 = "Legacy.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992519213900111892/LegacyV1.xex", "./Legacy.xex");
			this.ixboxConsole_0.SendFile("./Legacy.xex", "Hdd:\\Legacy.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Legacy.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Legacy");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Legacy.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Legacy.xex");
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00094194 File Offset: 0x00092394
		private void simpleButton11_Click(object sender, EventArgs e)
		{
			this.string_0 = "Medaka.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992519459027820570/MedakaGhosts.xex", "./Medaka.xex");
			this.ixboxConsole_0.SendFile("./Medaka.xex", "Hdd:\\Medaka.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Medaka.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Medaka");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Medaka.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Medaka.xex");
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00094268 File Offset: 0x00092468
		private void simpleButton13_Click(object sender, EventArgs e)
		{
			this.string_0 = "Medaka.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992520331694706768/MedakaMW2.xex", "./Medaka.xex");
			this.ixboxConsole_0.SendFile("./Medaka.xex", "Hdd:\\Medaka.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Medaka.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Medaka");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Medaka.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Medaka.xex");
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0009433C File Offset: 0x0009253C
		private void simpleButton15_Click(object sender, EventArgs e)
		{
			this.string_0 = "LegacyMenu.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992520719848189963/LegacyMenu.xex", "./LegacyMenu.xex");
			this.ixboxConsole_0.SendFile("./LegacyMenu.xex", "Hdd:\\LegacyMenu.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\LegacyMenu.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : LegacyMenu");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./LegacyMenu.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\LegacyMenu.xex");
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00094410 File Offset: 0x00092610
		private void simpleButton7_Click(object sender, EventArgs e)
		{
			this.string_0 = "Bo1ShitMenu.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992518255065444433/Bo1_Shit_Menu.xex", "./Bo1ShitMenu.xex");
			this.ixboxConsole_0.SendFile("./Bo1ShitMenu.xex", "Hdd:\\Bo1ShitMenu.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Bo1ShitMenu.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Bo1ShitMenu");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Bo1ShitMenu.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Bo1ShitMenu.xex");
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000944E4 File Offset: 0x000926E4
		private void simpleButton10_Click(object sender, EventArgs e)
		{
			this.string_0 = "MW2RCE.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992515941260857464/MW2RCE.xex", "./MW2RCE.xex");
			this.ixboxConsole_0.SendFile("./MW2RCE.xex", "Hdd:\\MW2RCE.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\MW2RCE.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : MW2RCE");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./MW2RCE.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\MW2RCE.xex");
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000945B8 File Offset: 0x000927B8
		private void simpleButton12_Click(object sender, EventArgs e)
		{
			this.string_0 = "Velonia.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992520013598695594/Velonia.xex", "./Velonia.xex");
			this.ixboxConsole_0.SendFile("./Velonia.xex", "Hdd:\\Velonia.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Velonia.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Velonia");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Velonia.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Velonia.xex");
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0009468C File Offset: 0x0009288C
		private void simpleButton14_Click(object sender, EventArgs e)
		{
			this.string_0 = "Medaka.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992520489790623877/MedakaMW3.xex", "./Medaka.xex");
			this.ixboxConsole_0.SendFile("./Medaka.xex", "Hdd:\\Medaka.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Medaka.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Medaka");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Medaka.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Medaka.xex");
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00094760 File Offset: 0x00092960
		private void simpleButton16_Click(object sender, EventArgs e)
		{
			this.string_0 = "Enforcer.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/992520775502405652/Enforcer_v2.9.4.xex", "./Enforcer.xex");
			this.ixboxConsole_0.SendFile("./Enforcer.xex", "Hdd:\\Enforcer.xex");
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\Enforcer.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : Enforcer");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			File.Delete("./Enforcer.xex");
			this.ixboxConsole_0.DeleteFile("Hdd:\\Enforcer.xex");
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00094834 File Offset: 0x00092A34
		private void simpleButton17_Click(object sender, EventArgs e)
		{
			this.string_0 = "MatrixMods.xex";
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/927961141664178270/1070036877261946980/MatrixMods.xex", "./MatrixMods.xex");
			try
			{
				this.ixboxConsole_0.SendFile("./MatrixMods.xex", "Hdd:\\MatrixMods.xex");
			}
			catch (Exception)
			{
			}
			try
			{
				this.ixboxConsole_0.Call<uint>("xboxkrnl.exe", 409, new object[]
				{
					"Hdd:\\MatrixMods.xex",
					8,
					0,
					0
				});
				this.ixboxConsole_0.XNotify("Injected Module : MatrixMods");
			}
			catch
			{
				this.ixboxConsole_0.XNotify("Failed to inject module.");
			}
			this.ixboxConsole_0.DeleteFile("Hdd:\\MatrixMods.xex");
			if (this.ixboxConsole_0.XamGetCurrentTitleId().ToString("X") != "FFFE07D1")
			{
				DialogResult dialogResult = XtraMessageBox.Show("You need to be on dashboard to initialize MatrixMods. Do you want to exit to dashboard?", "Guido's Console Tool", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					this.ixboxConsole_0.Reboot(null, null, null, XboxRebootFlags.Title);
				}
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000077C6 File Offset: 0x000059C6
		static ModuleLibTool()
		{
			
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x000078C3 File Offset: 0x00005AC3
		internal static bool smethod_0()
		{
			return ModuleLibTool.moduleLibTool_0 == null;
		}

		// Token: 0x040008DF RID: 2271
		private IXboxConsole ixboxConsole_0;

		// Token: 0x040008E0 RID: 2272
		private string string_0;

		// Token: 0x040008E1 RID: 2273
		private INI ini_0;

		// Token: 0x040008FB RID: 2299
		private static ModuleLibTool moduleLibTool_0;
	}
}
