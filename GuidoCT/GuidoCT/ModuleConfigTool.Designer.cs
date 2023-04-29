namespace GuidoCT
{
    // Token: 0x02000013 RID: 19
    public partial class ModuleConfigTool : global::DevExpress.XtraEditors.XtraForm
    {
        // Token: 0x0600058E RID: 1422 RVA: 0x0009296C File Offset: 0x00090B6C
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600058F RID: 1423 RVA: 0x0009299C File Offset: 0x00090B9C
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleConfigTool));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(623, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(134, 13);
            this.labelControl1.TabIndex = 142;
            this.labelControl1.Text = "Amount of Loaded Modules:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(623, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 13);
            this.labelControl2.TabIndex = 143;
            this.labelControl2.Text = "Last Loaded Module:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(623, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(109, 13);
            this.labelControl3.TabIndex = 144;
            this.labelControl3.Text = "Last Unloaded Module:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(623, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 13);
            this.labelControl4.TabIndex = 145;
            this.labelControl4.Text = "Last Reloaded Module:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(738, 55);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 146;
            this.labelControl5.Text = "Unknown";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(738, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 147;
            this.labelControl6.Text = "Unknown";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(728, 17);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 13);
            this.labelControl7.TabIndex = 148;
            this.labelControl7.Text = "Unknown";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(763, 74);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 149;
            this.labelControl8.Text = "Unknown";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(778, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(151, 13);
            this.labelControl9.TabIndex = 158;
            this.labelControl9.Text = "Example: Hdd:\\MatrixMods.xex";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleName,
            this.Addy,
            this.Size});
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 235);
            this.dataGridView1.TabIndex = 160;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ModuleName
            // 
            this.ModuleName.HeaderText = "Module Name";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Width = 180;
            // 
            // Addy
            // 
            this.Addy.HeaderText = "Base Address";
            this.Addy.Name = "Addy";
            this.Addy.Width = 180;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.Width = 180;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(623, 271);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Spoof As Dashboard";
            this.checkEdit1.Size = new System.Drawing.Size(184, 18);
            this.checkEdit1.TabIndex = 162;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(439, 8);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(149, 31);
            this.simpleButton6.TabIndex = 159;
            this.simpleButton6.Text = "Clear Module List";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(778, 234);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(176, 31);
            this.simpleButton5.TabIndex = 157;
            this.simpleButton5.Text = "Refresh Modules";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "Hdd:\\";
            this.textEdit3.Location = new System.Drawing.Point(778, 129);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(176, 20);
            this.textEdit3.TabIndex = 156;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "Hdd:\\";
            this.textEdit2.Location = new System.Drawing.Point(778, 203);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(176, 20);
            this.textEdit2.TabIndex = 155;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Hdd:\\";
            this.textEdit1.Location = new System.Drawing.Point(778, 166);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(176, 20);
            this.textEdit1.TabIndex = 154;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(623, 234);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(149, 31);
            this.simpleButton4.TabIndex = 153;
            this.simpleButton4.Text = "Inject Module From PC";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(623, 197);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(149, 31);
            this.simpleButton3.TabIndex = 152;
            this.simpleButton3.Text = "Reload Module";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(623, 160);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(149, 31);
            this.simpleButton2.TabIndex = 151;
            this.simpleButton2.Text = "Unload Module";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(623, 123);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 31);
            this.simpleButton1.TabIndex = 150;
            this.simpleButton1.Text = "Inject Module";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ModuleConfigTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(974, 298);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ModuleConfigTool.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "ModuleConfigTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module Configurator";
            this.Load += new System.EventHandler(this.ModuleConfigTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x040008C6 RID: 2246
        private global::System.ComponentModel.IContainer icontainer_0;

        // Token: 0x040008C7 RID: 2247
        private global::DevExpress.XtraEditors.LabelControl labelControl1;

        // Token: 0x040008C8 RID: 2248
        private global::DevExpress.XtraEditors.LabelControl labelControl2;

        // Token: 0x040008C9 RID: 2249
        private global::DevExpress.XtraEditors.LabelControl labelControl3;

        // Token: 0x040008CA RID: 2250
        private global::DevExpress.XtraEditors.LabelControl labelControl4;

        // Token: 0x040008CB RID: 2251
        private global::DevExpress.XtraEditors.LabelControl labelControl5;

        // Token: 0x040008CC RID: 2252
        private global::DevExpress.XtraEditors.LabelControl labelControl6;

        // Token: 0x040008CD RID: 2253
        private global::DevExpress.XtraEditors.LabelControl labelControl7;

        // Token: 0x040008CE RID: 2254
        private global::DevExpress.XtraEditors.LabelControl labelControl8;

        // Token: 0x040008CF RID: 2255
        private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

        // Token: 0x040008D0 RID: 2256
        private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

        // Token: 0x040008D1 RID: 2257
        private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

        // Token: 0x040008D2 RID: 2258
        private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

        // Token: 0x040008D3 RID: 2259
        private global::DevExpress.XtraEditors.TextEdit textEdit1;

        // Token: 0x040008D4 RID: 2260
        private global::DevExpress.XtraEditors.TextEdit textEdit2;

        // Token: 0x040008D5 RID: 2261
        private global::DevExpress.XtraEditors.TextEdit textEdit3;

        // Token: 0x040008D6 RID: 2262
        private global::DevExpress.XtraEditors.SimpleButton simpleButton5;

        // Token: 0x040008D7 RID: 2263
        private global::DevExpress.XtraEditors.LabelControl labelControl9;

        // Token: 0x040008D8 RID: 2264
        private global::DevExpress.XtraEditors.SimpleButton simpleButton6;

        // Token: 0x040008D9 RID: 2265
        private global::System.Windows.Forms.DataGridView dataGridView1;

        // Token: 0x040008DA RID: 2266
        private global::System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;

        // Token: 0x040008DB RID: 2267
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Addy;

        // Token: 0x040008DC RID: 2268
        private new global::System.Windows.Forms.DataGridViewTextBoxColumn Size;

        // Token: 0x040008DD RID: 2269
        private global::DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}