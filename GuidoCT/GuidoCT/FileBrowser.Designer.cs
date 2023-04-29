namespace GuidoCT
{
    // Token: 0x02000009 RID: 9
    public partial class FileBrowser : global::DevExpress.XtraEditors.XtraForm
    {
        // Token: 0x060000B7 RID: 183 RVA: 0x0001A538 File Offset: 0x00018738
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060000B8 RID: 184 RVA: 0x0001A568 File Offset: 0x00018768
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowser));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton100 = new DevExpress.XtraEditors.SimpleButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.simpleButton14);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton100);
            this.groupControl1.Controls.Add(this.listView1);
            this.groupControl1.Location = new System.Drawing.Point(174, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(681, 536);
            this.groupControl1.TabIndex = 56;
            this.groupControl1.Text = "File Browser";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(37, 503);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(638, 20);
            this.textEdit1.TabIndex = 71;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 506);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 72;
            this.labelControl3.Text = "Path:";
            // 
            // simpleButton14
            // 
            this.simpleButton14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton14.ImageOptions.Image")));
            this.simpleButton14.Location = new System.Drawing.Point(253, 37);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(178, 31);
            this.simpleButton14.TabIndex = 70;
            this.simpleButton14.Text = "Refresh";
            this.simpleButton14.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(497, 37);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(178, 31);
            this.simpleButton2.TabIndex = 54;
            this.simpleButton2.Text = "Go Back";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton100
            // 
            this.simpleButton100.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton100.ImageOptions.Image")));
            this.simpleButton100.Location = new System.Drawing.Point(5, 37);
            this.simpleButton100.Name = "simpleButton100";
            this.simpleButton100.Size = new System.Drawing.Size(178, 31);
            this.simpleButton100.TabIndex = 53;
            this.simpleButton100.Text = "Open Folder";
            this.simpleButton100.Click += new System.EventHandler(this.simpleButton100_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0,
            this.columnHeader_1});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList_0;
            this.listView1.Location = new System.Drawing.Point(5, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 423);
            this.listView1.TabIndex = 69;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList_0
            // 
            this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // simpleButton13
            // 
            this.simpleButton13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.ImageOptions.Image")));
            this.simpleButton13.Location = new System.Drawing.Point(12, 482);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(156, 31);
            this.simpleButton13.TabIndex = 68;
            this.simpleButton13.Text = "Filter To Directories Only";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton12.ImageOptions.Image")));
            this.simpleButton12.Location = new System.Drawing.Point(12, 445);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(156, 31);
            this.simpleButton12.TabIndex = 67;
            this.simpleButton12.Text = "Filter To Files Only";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.simpleButton11.Location = new System.Drawing.Point(12, 408);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(156, 31);
            this.simpleButton11.TabIndex = 66;
            this.simpleButton11.Text = "Filter To INI Files";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.simpleButton10.Location = new System.Drawing.Point(12, 371);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(156, 31);
            this.simpleButton10.TabIndex = 65;
            this.simpleButton10.Text = "Filter To XeX Files";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(12, 271);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(156, 31);
            this.simpleButton9.TabIndex = 64;
            this.simpleButton9.Text = "Receive File";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.ImageOptions.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(12, 234);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(156, 31);
            this.simpleButton8.TabIndex = 63;
            this.simpleButton8.Text = "Inject As Module";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(12, 197);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(156, 31);
            this.simpleButton7.TabIndex = 62;
            this.simpleButton7.Text = "Run XeX";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(12, 160);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(156, 31);
            this.simpleButton6.TabIndex = 61;
            this.simpleButton6.Text = "Add To Game Launcher";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(12, 86);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(156, 31);
            this.simpleButton4.TabIndex = 59;
            this.simpleButton4.Text = "Delete File";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(12, 49);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(156, 31);
            this.simpleButton3.TabIndex = 58;
            this.simpleButton3.Text = "Send File";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(156, 31);
            this.simpleButton1.TabIndex = 57;
            this.simpleButton1.Text = "Refresh Drives";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(12, 308);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(156, 31);
            this.simpleButton5.TabIndex = 69;
            this.simpleButton5.Text = "Create Directory";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(44, 345);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(124, 20);
            this.textEdit2.TabIndex = 72;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 348);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "Name:";
            // 
            // simpleButton15
            // 
            this.simpleButton15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton15.ImageOptions.Image")));
            this.simpleButton15.Location = new System.Drawing.Point(12, 123);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(156, 31);
            this.simpleButton15.TabIndex = 74;
            this.simpleButton15.Text = "Delete Directory";
            this.simpleButton15.Click += new System.EventHandler(this.simpleButton15_Click);
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(862, 558);
            this.Controls.Add(this.simpleButton15);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton13);
            this.Controls.Add(this.simpleButton12);
            this.Controls.Add(this.simpleButton11);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FileBrowser.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "FileBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileBrowser";
            this.Load += new System.EventHandler(this.FileBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000109 RID: 265
        private global::System.ComponentModel.IContainer icontainer_0;

        // Token: 0x0400010A RID: 266
        private global::DevExpress.XtraEditors.GroupControl groupControl1;

        // Token: 0x0400010B RID: 267
        private global::DevExpress.XtraEditors.SimpleButton simpleButton100;

        // Token: 0x0400010C RID: 268
        private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

        // Token: 0x0400010D RID: 269
        private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

        // Token: 0x0400010E RID: 270
        private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

        // Token: 0x0400010F RID: 271
        private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

        // Token: 0x04000110 RID: 272
        private global::DevExpress.XtraEditors.SimpleButton simpleButton6;

        // Token: 0x04000111 RID: 273
        private global::DevExpress.XtraEditors.SimpleButton simpleButton7;

        // Token: 0x04000112 RID: 274
        private global::DevExpress.XtraEditors.SimpleButton simpleButton8;

        // Token: 0x04000113 RID: 275
        private global::DevExpress.XtraEditors.SimpleButton simpleButton9;

        // Token: 0x04000114 RID: 276
        private global::DevExpress.XtraEditors.SimpleButton simpleButton10;

        // Token: 0x04000115 RID: 277
        private global::DevExpress.XtraEditors.SimpleButton simpleButton11;

        // Token: 0x04000116 RID: 278
        private global::DevExpress.XtraEditors.SimpleButton simpleButton12;

        // Token: 0x04000117 RID: 279
        private global::DevExpress.XtraEditors.SimpleButton simpleButton13;

        // Token: 0x04000118 RID: 280
        private global::System.Windows.Forms.ListView listView1;

        // Token: 0x04000119 RID: 281
        private global::System.Windows.Forms.ImageList imageList_0;

        // Token: 0x0400011A RID: 282
        private global::DevExpress.XtraEditors.TextEdit textEdit1;

        // Token: 0x0400011B RID: 283
        private global::DevExpress.XtraEditors.LabelControl labelControl3;

        // Token: 0x0400011C RID: 284
        private global::DevExpress.XtraEditors.SimpleButton simpleButton14;

        // Token: 0x0400011D RID: 285
        private global::DevExpress.XtraEditors.SimpleButton simpleButton5;

        // Token: 0x0400011E RID: 286
        private global::DevExpress.XtraEditors.TextEdit textEdit2;

        // Token: 0x0400011F RID: 287
        private global::DevExpress.XtraEditors.LabelControl labelControl1;

        // Token: 0x04000120 RID: 288
        private global::DevExpress.XtraEditors.SimpleButton simpleButton15;

        // Token: 0x04000121 RID: 289
        private global::System.Windows.Forms.ColumnHeader columnHeader_0;

        // Token: 0x04000122 RID: 290
        private global::System.Windows.Forms.ColumnHeader columnHeader_1;
        private System.ComponentModel.IContainer components;
    }
}