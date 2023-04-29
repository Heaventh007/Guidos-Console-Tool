namespace GuidoCT
{
	// Token: 0x0200000F RID: 15
	public partial class ForceJoiner : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x0009085C File Offset: 0x0008EA5C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0009088C File Offset: 0x0008EA8C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForceJoiner));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 31);
            this.simpleButton2.TabIndex = 31;
            this.simpleButton2.Text = "Force Join Party";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 58);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(210, 20);
            this.textEdit1.TabIndex = 32;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(228, 58);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(210, 20);
            this.textEdit2.TabIndex = 34;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(228, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(210, 31);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "Force Join Session";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 122);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(335, 16);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Client Needs To Appear As Online And Or Added As Friend";
            // 
            // simpleButton10
            // 
            this.simpleButton10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.simpleButton10.Location = new System.Drawing.Point(141, 84);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(160, 31);
            this.simpleButton10.TabIndex = 36;
            this.simpleButton10.Text = "Help";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // ForceJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(443, 150);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton2);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ForceJoiner.IconOptions.Image")));
            this.Name = "ForceJoiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Force Joiner";
            this.Load += new System.EventHandler(this.ForceJoiner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400089C RID: 2204
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400089D RID: 2205
		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		// Token: 0x0400089E RID: 2206
		private global::DevExpress.XtraEditors.TextEdit textEdit1;

		// Token: 0x0400089F RID: 2207
		private global::DevExpress.XtraEditors.TextEdit textEdit2;

		// Token: 0x040008A0 RID: 2208
		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		// Token: 0x040008A1 RID: 2209
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x040008A2 RID: 2210
		private global::DevExpress.XtraEditors.SimpleButton simpleButton10;
	}
}
