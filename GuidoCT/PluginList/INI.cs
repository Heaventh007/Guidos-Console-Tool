using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace PluginList
{
	// Token: 0x02000005 RID: 5
	public class INI
	{
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public INI(string FileName) => path = Directory.GetCurrentDirectory() + "\\" + FileName;
        public void Write(string Section, string Key, string Value) => INI.WritePrivateProfileString(Section, Key, Value, path);
        public string Read(string Section, string Key)
        {
            StringBuilder stringBuilder = new StringBuilder(255);
            INI.GetPrivateProfileString(Section, Key, "", stringBuilder, 255, path);
            return stringBuilder.ToString();
        }
        public string path;
    }

}
