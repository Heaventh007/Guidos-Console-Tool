using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ToolSettings
{
	// Token: 0x02000003 RID: 3
	public class INI
	{
		// Token: 0x0600000A RID: 10
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string string_0, string string_1, string string_2, string string_3);

		// Token: 0x0600000B RID: 11
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, int int_0, string string_3);

		// Token: 0x0600000C RID: 12 RVA: 0x00008E90 File Offset: 0x00007090
		public INI(string FileName)
		{	
			this.path = Directory.GetCurrentDirectory() + "\\" + FileName;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00008EC0 File Offset: 0x000070C0
		public void Write(string Section, string Key, string Value)
		{
			INI.WritePrivateProfileString(Section, Key, Value, this.path);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00008EDC File Offset: 0x000070DC
		public string Read(string Section, string Key)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			INI.GetPrivateProfileString(Section, Key, "", stringBuilder, 255, this.path);
			return stringBuilder.ToString();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000077C6 File Offset: 0x000059C6
		static INI()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000077CD File Offset: 0x000059CD
		internal static bool smethod_0()
		{
			return INI.ini_0 == null;
		}

		// Token: 0x04000006 RID: 6
		public string path;

		// Token: 0x04000007 RID: 7
		private static INI ini_0;
	}
}
