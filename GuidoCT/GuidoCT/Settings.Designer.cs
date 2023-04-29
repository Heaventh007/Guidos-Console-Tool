namespace GuidoCT
{
    // Token: 0x02000019 RID: 25
    public partial class Settings : global::DevExpress.XtraEditors.XtraForm
    {
        // Token: 0x060005D5 RID: 1493 RVA: 0x000983F4 File Offset: 0x000965F4
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060005D6 RID: 1494 RVA: 0x00098424 File Offset: 0x00096624
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton37 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_0 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_0.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton37);
            this.groupControl1.Controls.Add(this.textEdit_0);
            this.groupControl1.Controls.Add(this.simpleButton6);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Location = new System.Drawing.Point(12, 105);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(457, 187);
            this.groupControl1.TabIndex = 56;
            this.groupControl1.Text = "Tool Settings";
            // 
            // simpleButton37
            // 
            this.simpleButton37.Location = new System.Drawing.Point(76, 141);
            this.simpleButton37.Name = "simpleButton37";
            this.simpleButton37.Size = new System.Drawing.Size(301, 31);
            this.simpleButton37.TabIndex = 63;
            this.simpleButton37.Text = "Custom Connection XNotify [OFF]";
            this.simpleButton37.Click += new System.EventHandler(this.simpleButton37_Click);
            // 
            // textEdit_0
            // 
            this.textEdit_0.Location = new System.Drawing.Point(76, 112);
            this.textEdit_0.Name = "textEdit_0";
            this.textEdit_0.Size = new System.Drawing.Size(301, 20);
            this.textEdit_0.TabIndex = 64;
            this.textEdit_0.ToolTipTitle = "Example: default_mp.xex or default.xex";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(76, 71);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(177, 31);
            this.simpleButton6.TabIndex = 62;
            this.simpleButton6.Text = "Delete All Tool Created INI";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(259, 71);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(118, 31);
            this.simpleButton4.TabIndex = 61;
            this.simpleButton4.Text = "Auto Login [OFF]";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(208, 34);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(169, 31);
            this.simpleButton3.TabIndex = 60;
            this.simpleButton3.Text = "Hide Private Info [OFF]";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(76, 34);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(126, 31);
            this.simpleButton2.TabIndex = 59;
            this.simpleButton2.Text = "Discord RPC [ON]";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(177, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "3.4";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(107, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Build Version:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(106, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 31);
            this.simpleButton1.TabIndex = 57;
            this.simpleButton1.Text = "Restart Tool";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(107, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 13);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Guido\'s Console Tool";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(210, 60);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(259, 31);
            this.simpleButton5.TabIndex = 62;
            this.simpleButton5.Text = "Restore Settings to Default";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Settings.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_0.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000931 RID: 2353
        private global::System.ComponentModel.IContainer icontainer_0;

        // Token: 0x04000932 RID: 2354
        private global::DevExpress.XtraEditors.GroupControl groupControl1;

        // Token: 0x04000933 RID: 2355
        private global::DevExpress.XtraEditors.LabelControl labelControl3;

        // Token: 0x04000934 RID: 2356
        private global::DevExpress.XtraEditors.LabelControl labelControl4;

        // Token: 0x04000935 RID: 2357
        private global::System.Windows.Forms.PictureBox pictureBox1;

        // Token: 0x04000936 RID: 2358
        private global::DevExpress.XtraEditors.SimpleButton simpleButton6;

        // Token: 0x04000937 RID: 2359
        private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

        // Token: 0x04000938 RID: 2360
        private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

        // Token: 0x04000939 RID: 2361
        private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

        // Token: 0x0400093A RID: 2362
        private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

        // Token: 0x0400093B RID: 2363
        private global::DevExpress.XtraEditors.LabelControl labelControl1;

        // Token: 0x0400093C RID: 2364
        private global::DevExpress.XtraEditors.SimpleButton simpleButton5;

        // Token: 0x0400093D RID: 2365
        private global::DevExpress.XtraEditors.SimpleButton simpleButton37;

        // Token: 0x0400093E RID: 2366
        private global::DevExpress.XtraEditors.TextEdit textEdit_0;
    }
}