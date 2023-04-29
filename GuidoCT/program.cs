using System;
using System.Windows.Forms;
using GuidoCT;

// Token: 0x02000015 RID: 21
internal static class Program
{
	// Token: 0x060005AC RID: 1452 RVA: 0x00095B30 File Offset: 0x00093D30
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Form1());
	}

}
