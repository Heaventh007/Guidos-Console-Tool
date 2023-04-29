namespace GuidoCT
{
	// Token: 0x02000006 RID: 6
	public partial class CmdTool : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000028 RID: 40 RVA: 0x0000A554 File Offset: 0x00008754
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000A584 File Offset: 0x00008784
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmdTool));
            this.listBox1 = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton100 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(5, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(362, 234);
            this.listBox1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton100);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.listBox1);
            this.groupControl1.Location = new System.Drawing.Point(12, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 303);
            this.groupControl1.TabIndex = 55;
            this.groupControl1.Text = "Execute A Command";
            // 
            // simpleButton100
            // 
            this.simpleButton100.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton100.ImageOptions.Image")));
            this.simpleButton100.Location = new System.Drawing.Point(5, 26);
            this.simpleButton100.Name = "simpleButton100";
            this.simpleButton100.Size = new System.Drawing.Size(120, 31);
            this.simpleButton100.TabIndex = 53;
            this.simpleButton100.Text = "Execute Command";
            this.simpleButton100.Click += new System.EventHandler(this.simpleButton100_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 54;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(12, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(161, 24);
            this.labelControl9.TabIndex = 56;
            this.labelControl9.Text = "Command System";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 13);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Last Executed Command:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(142, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 59;
            this.labelControl2.Text = "None";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(201, 402);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(183, 31);
            this.simpleButton3.TabIndex = 55;
            this.simpleButton3.Text = "Re-Execute Command";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(138, 402);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(57, 31);
            this.simpleButton2.TabIndex = 57;
            this.simpleButton2.Text = "Help";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 402);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(120, 31);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "Clear Console";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(12, 439);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(372, 31);
            this.simpleButton4.TabIndex = 60;
            this.simpleButton4.Text = "Copy Selected Row To Clipboard";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // CmdTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(395, 480);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CmdTool.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "CmdTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command System";
            this.Load += new System.EventHandler(this.CmdTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400000F RID: 15
		private global::DevExpress.XtraEditors.ListBoxControl listBox1;

		// Token: 0x04000010 RID: 16
		private global::DevExpress.XtraEditors.TextEdit textBox1;

		// Token: 0x04000011 RID: 17
		private global::DevExpress.XtraEditors.SimpleButton simpleButton100;

		// Token: 0x04000012 RID: 18
		private global::DevExpress.XtraEditors.GroupControl groupControl1;

		// Token: 0x04000013 RID: 19
		private global::DevExpress.XtraEditors.LabelControl labelControl9;

		// Token: 0x04000014 RID: 20
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x04000015 RID: 21
		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		// Token: 0x04000016 RID: 22
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x04000017 RID: 23
		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		// Token: 0x04000018 RID: 24
		private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

		// Token: 0x04000019 RID: 25
		private global::DevExpress.XtraEditors.SimpleButton simpleButton4;
	}
}
