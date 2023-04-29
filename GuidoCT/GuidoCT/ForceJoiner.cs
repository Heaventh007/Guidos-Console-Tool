using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GuidoCT.Properties;
using JRPC_Client;
using XDevkit;

namespace GuidoCT
{
	// Token: 0x0200000F RID: 15
	public partial class ForceJoiner : XtraForm
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x0009047C File Offset: 0x0008E67C
		public ForceJoiner()
		{
			this.icontainer_0 = null;
			
			this.InitializeComponent();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000904A4 File Offset: 0x0008E6A4
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

		// Token: 0x0600055F RID: 1375 RVA: 0x000904D4 File Offset: 0x0008E6D4
		private void ForceJoiner_Load(object sender, EventArgs e)
		{
			if (!this.ixboxConsole_0.Connect(out this.ixboxConsole_0, "default"))
			{
				XtraMessageBox.Show("Failed to establish a connection to your console, the tool will load disconnected.");
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00090504 File Offset: 0x0008E704
		private string method_0(string string_1)
		{
			byte[] data = new byte[8];
			this.ixboxConsole_0.SetMemory(2175409456U, data);
			this.ixboxConsole_0.CallVoid(2172820832U, new object[]
			{
				2533274907391075L,
				0,
				string_1,
				24,
				2175409456U,
				0
			});
			Thread.Sleep(1000);
			string result = BitConverter.ToString(this.ixboxConsole_0.GetMemory(2175409456U, 8U)).Replace("-", "");
			this.ixboxConsole_0.SetMemory(2175409456U, data);
			return result;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000905C8 File Offset: 0x0008E7C8
		public byte Converter2(int index)
		{
			return Convert.ToByte(this.string_0.Substring(index, 2), 16);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000905F0 File Offset: 0x0008E7F0
		private static bool smethod_0(int int_0)
		{
			return int_0 % 2 == 0;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00090604 File Offset: 0x0008E804
		private byte[] method_1(string string_1)
		{
			byte[] result;
			try
			{
				this.string_0 = this.method_0(string_1).Replace(" ", "").Replace("0x", "");
				result = Enumerable.Range(0, this.string_0.Length).Where(new Func<int, bool>(ForceJoiner.smethod_0)).Select(new Func<int, byte>(this.Converter2)).ToArray<byte>();
			}
			catch
			{
				result = new byte[1];
			}
			return result;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0009069C File Offset: 0x0008E89C
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			this.ixboxConsole_0.CallVoid(this.ixboxConsole_0.ResolveFunction("xam.xex", 2843U), new object[]
			{
				0,
				BitConverter.ToInt64(this.method_1(this.textEdit1.Text).Reverse<byte>().ToArray<byte>(), 0),
				0,
				0,
				0
			});
			this.ixboxConsole_0.XNotify("Succesfully joined party of : " + this.textEdit1.Text);
		}

        // Token: 0x06000565 RID: 1381 RVA: 0x0009073C File Offset: 0x0008E93C
        public static byte[] hexString(string HexString)
        {
            int length = HexString.Length;
            byte[] array = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                array[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return array;
        }

        // Token: 0x06000566 RID: 1382 RVA: 0x000907AC File Offset: 0x0008E9AC
        private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.string_0 = this.method_0(this.textEdit2.Text);
			this.ixboxConsole_0.CallVoid(this.ixboxConsole_0.ResolveFunction("xam.xex", 769U), new object[]
			{
				0,
				BitConverter.ToInt64(ForceJoiner.hexString(this.string_0).Reverse<byte>().ToArray<byte>(), 0)
			});
			this.ixboxConsole_0.XNotify("Succesfully found session of : " + this.textEdit2.Text);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00090844 File Offset: 0x0008EA44
		private void simpleButton10_Click(object sender, EventArgs e)
		{
			XtraMessageBox.Show("If force joining party fails, it will say that in an XNotify on your console.\n\nIf force joining session fails, it won't automatically join the session yet prompt you with a do you want to join this session messagebox, if you select yes there is a chance it will send you to internet explorer because it failed.");
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000077C6 File Offset: 0x000059C6
		static ForceJoiner()
		{
			
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000787B File Offset: 0x00005A7B
		internal static bool smethod_1()
		{
			return ForceJoiner.forceJoiner_0 == null;
		}

		// Token: 0x0400089A RID: 2202
		private IXboxConsole ixboxConsole_0;

		// Token: 0x0400089B RID: 2203
		private string string_0;

		// Token: 0x040008A3 RID: 2211
		internal static ForceJoiner forceJoiner_0;
	}
}
