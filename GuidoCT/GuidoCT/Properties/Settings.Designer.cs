using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GuidoCT.Properties
{
	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000991E4 File Offset: 0x000973E4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000991FC File Offset: 0x000973FC
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00099220 File Offset: 0x00097420
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Auto Login (OFF)")]
		public string AutoLogin
		{
			get
			{
				return (string)this["AutoLogin"];
			}
			set
			{
				this["AutoLogin"] = value;
			}
		}

		// Token: 0x04000943 RID: 2371
		private static Settings defaultInstance;
	}
}
