namespace GuidoCT
{
    // Token: 0x02000012 RID: 18
    public partial class INIEditorTool : global::DevExpress.XtraEditors.XtraForm
    {
        // Token: 0x0600057D RID: 1405 RVA: 0x000913E8 File Offset: 0x0008F5E8
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600057E RID: 1406 RVA: 0x00091418 File Offset: 0x0008F618
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INIEditorTool));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_0 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_0.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(12, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(614, 459);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.separatorControl1);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.simpleButton6);
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(632, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(246, 307);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "Plugin List";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(5, 56);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(236, 23);
            this.separatorControl1.TabIndex = 44;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(56, 30);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(135, 24);
            this.labelControl9.TabIndex = 43;
            this.labelControl9.Text = "Current Plugins";
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(20, 263);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(206, 31);
            this.simpleButton6.TabIndex = 42;
            this.simpleButton6.Text = "Clear Plugins and Reboot";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(20, 226);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(206, 31);
            this.simpleButton5.TabIndex = 34;
            this.simpleButton5.Text = "Refresh Plugin List";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 194);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "Plugin 5:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Plugin 4:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 142);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Plugin 3:";
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "";
            this.textEdit5.Location = new System.Drawing.Point(67, 191);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(159, 20);
            this.textEdit5.TabIndex = 38;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "";
            this.textEdit4.Location = new System.Drawing.Point(67, 165);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(159, 20);
            this.textEdit4.TabIndex = 37;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "";
            this.textEdit3.Location = new System.Drawing.Point(67, 139);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(159, 20);
            this.textEdit3.TabIndex = 36;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(67, 113);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(159, 20);
            this.textEdit2.TabIndex = 35;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(67, 87);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(159, 20);
            this.textEdit1.TabIndex = 34;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Plugin 2:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Plugin 1:";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(481, 42);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(145, 31);
            this.simpleButton4.TabIndex = 32;
            this.simpleButton4.Text = "Deleted Pulled INI";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(481, 5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(145, 31);
            this.simpleButton3.TabIndex = 31;
            this.simpleButton3.Text = "Save Changes to INI";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 42);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 31);
            this.simpleButton2.TabIndex = 30;
            this.simpleButton2.Text = "Pull launch.ini From Console";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit_0
            // 
            this.textEdit_0.EditValue = "Hdd:\\";
            this.textEdit_0.Location = new System.Drawing.Point(228, 11);
            this.textEdit_0.Name = "textEdit_0";
            this.textEdit_0.Size = new System.Drawing.Size(247, 20);
            this.textEdit_0.TabIndex = 29;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(210, 31);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Pull INI From Console";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // INIEditorTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(887, 549);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.textEdit_0);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("INIEditorTool.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "INIEditorTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INI Editor";
            this.Load += new System.EventHandler(this.INIEditorTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_0.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x040008AC RID: 2220
        private global::System.ComponentModel.IContainer icontainer_0;

        // Token: 0x040008AD RID: 2221
        private global::System.Windows.Forms.RichTextBox richTextBox1;

        // Token: 0x040008AE RID: 2222
        private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

        // Token: 0x040008AF RID: 2223
        private global::DevExpress.XtraEditors.TextEdit textEdit_0;

        // Token: 0x040008B0 RID: 2224
        private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

        // Token: 0x040008B1 RID: 2225
        private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

        // Token: 0x040008B2 RID: 2226
        private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

        // Token: 0x040008B3 RID: 2227
        private global::DevExpress.XtraEditors.GroupControl groupControl1;

        // Token: 0x040008B4 RID: 2228
        private global::DevExpress.XtraEditors.SimpleButton simpleButton6;

        // Token: 0x040008B5 RID: 2229
        private global::DevExpress.XtraEditors.SimpleButton simpleButton5;

        // Token: 0x040008B6 RID: 2230
        private global::DevExpress.XtraEditors.LabelControl labelControl5;

        // Token: 0x040008B7 RID: 2231
        private global::DevExpress.XtraEditors.LabelControl labelControl4;

        // Token: 0x040008B8 RID: 2232
        private global::DevExpress.XtraEditors.LabelControl labelControl3;

        // Token: 0x040008B9 RID: 2233
        private global::DevExpress.XtraEditors.TextEdit textEdit5;

        // Token: 0x040008BA RID: 2234
        private global::DevExpress.XtraEditors.TextEdit textEdit4;

        // Token: 0x040008BB RID: 2235
        private global::DevExpress.XtraEditors.TextEdit textEdit3;

        // Token: 0x040008BC RID: 2236
        private global::DevExpress.XtraEditors.TextEdit textEdit2;

        // Token: 0x040008BD RID: 2237
        private global::DevExpress.XtraEditors.TextEdit textEdit1;

        // Token: 0x040008BE RID: 2238
        private global::DevExpress.XtraEditors.LabelControl labelControl2;

        // Token: 0x040008BF RID: 2239
        private global::DevExpress.XtraEditors.LabelControl labelControl1;

        // Token: 0x040008C0 RID: 2240
        private global::DevExpress.XtraEditors.SeparatorControl separatorControl1;

        // Token: 0x040008C1 RID: 2241
        private global::DevExpress.XtraEditors.LabelControl labelControl9;
    }
}