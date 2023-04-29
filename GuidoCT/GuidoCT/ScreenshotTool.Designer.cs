namespace GuidoCT
{
    // Token: 0x02000018 RID: 24
    public partial class ScreenshotTool : global::DevExpress.XtraEditors.XtraForm
    {
        // Token: 0x060005C8 RID: 1480 RVA: 0x00097AB0 File Offset: 0x00095CB0
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060005C9 RID: 1481 RVA: 0x00097AE0 File Offset: 0x00095CE0
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshotTool));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(11, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(649, 361);
            this.pictureEdit1.TabIndex = 25;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(421, 379);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(174, 31);
            this.simpleButton4.TabIndex = 24;
            this.simpleButton4.Text = "Copy Screenshot to Clipboard";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(305, 379);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(110, 31);
            this.simpleButton3.TabIndex = 23;
            this.simpleButton3.Text = "Save Screenshot";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(185, 379);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(114, 31);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Screenshot Loop";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(62, 379);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 31);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Take Screenshot";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ScreenshotTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(672, 433);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ScreenshotTool.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "ScreenshotTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshot Tool";
            this.Load += new System.EventHandler(this.ScreenshotTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        // Token: 0x04000928 RID: 2344
        private global::System.ComponentModel.IContainer icontainer_0;

        // Token: 0x04000929 RID: 2345
        private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

        // Token: 0x0400092A RID: 2346
        private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

        // Token: 0x0400092B RID: 2347
        private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

        // Token: 0x0400092C RID: 2348
        private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

        // Token: 0x0400092D RID: 2349
        private global::DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}