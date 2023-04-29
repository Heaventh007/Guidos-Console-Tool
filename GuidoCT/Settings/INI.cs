using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Settings
{
	// Token: 0x02000004 RID: 4
	public class INI
	{
		// Token: 0x06000011 RID: 17
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string string_0, string string_1, string string_2, string string_3);

		// Token: 0x06000012 RID: 18
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string string_0, string string_1, string string_2, StringBuilder stringBuilder_0, int int_0, string string_3);

		// Token: 0x06000013 RID: 19 RVA: 0x00008F1C File Offset: 0x0000711C
		public INI(string FileName)
		{
			
			this.path = Directory.GetCurrentDirectory() + "\\" + FileName;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00008F4C File Offset: 0x0000714C
		public void Write(string Section, string Key, string Value)
		{
			INI.WritePrivateProfileString(Section, Key, Value, this.path);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00008F68 File Offset: 0x00007168
		public string Read(string Section, string Key)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			INI.GetPrivateProfileString(Section, Key, "", stringBuilder, 255, this.path);
			return stringBuilder.ToString();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000077C6 File Offset: 0x000059C6
		static INI()
		{
			
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000077D7 File Offset: 0x000059D7
		internal static bool smethod_0()
		{
			return INI.ini_0 == null;
		}

		// Token: 0x04000008 RID: 8
		public string path;

		// Token: 0x04000009 RID: 9
		internal static INI ini_0;
	}
}
