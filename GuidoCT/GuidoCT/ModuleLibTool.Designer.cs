namespace GuidoCT
{
    // Token: 0x02000014 RID: 20
    public partial class ModuleLibTool : global::DevExpress.XtraEditors.XtraForm
    {
        // Token: 0x060005A8 RID: 1448 RVA: 0x0009495C File Offset: 0x00092B5C
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.icontainer_0 != null)
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060005A9 RID: 1449 RVA: 0x0009498C File Offset: 0x00092B8C
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleLibTool));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEdit2);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Location = new System.Drawing.Point(12, 118);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(423, 99);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "NiNJA Engine Modules";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(237, 32);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "BO1.ENGINE.xex",
            "BO2.ENGINE.xex",
            "GHOSTS.ENGINE.xex",
            "MW1.ENGINE.xex",
            "MW2.ENGINE.xex",
            "MW3.ENGINE.xex",
            "WAW.ENGINE.xex"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(181, 20);
            this.comboBoxEdit2.TabIndex = 7;
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(237, 58);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(181, 31);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "NiNJA V1 Engine [ALL COD]";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(5, 32);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "AW.xex",
            "BO1.xex",
            "BO2.xex",
            "BO3.xex",
            "GHO.xex",
            "MW1.xex",
            "MW2.xex",
            "MW3.xex",
            "WAW.xex"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(181, 20);
            this.comboBoxEdit1.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(5, 58);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(181, 31);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "NiNJA V2 Engine [ALL COD]";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton17);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton6);
            this.groupControl2.Location = new System.Drawing.Point(12, 223);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(423, 104);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "All COD Modules";
            // 
            // simpleButton17
            // 
            this.simpleButton17.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton17.ImageOptions.Image")));
            this.simpleButton17.Location = new System.Drawing.Point(5, 67);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(181, 31);
            this.simpleButton17.TabIndex = 7;
            this.simpleButton17.Text = "MatrixMods";
            this.simpleButton17.Click += new System.EventHandler(this.simpleButton17_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(237, 30);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(181, 31);
            this.simpleButton5.TabIndex = 6;
            this.simpleButton5.Text = "Myten";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(5, 30);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(181, 31);
            this.simpleButton6.TabIndex = 4;
            this.simpleButton6.Text = "Appendum";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton16);
            this.groupControl3.Controls.Add(this.simpleButton15);
            this.groupControl3.Controls.Add(this.simpleButton14);
            this.groupControl3.Controls.Add(this.simpleButton13);
            this.groupControl3.Controls.Add(this.simpleButton12);
            this.groupControl3.Controls.Add(this.simpleButton11);
            this.groupControl3.Controls.Add(this.simpleButton10);
            this.groupControl3.Controls.Add(this.simpleButton9);
            this.groupControl3.Controls.Add(this.simpleButton7);
            this.groupControl3.Controls.Add(this.simpleButton8);
            this.groupControl3.Location = new System.Drawing.Point(12, 333);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(423, 219);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Individual Game Modules";
            // 
            // simpleButton16
            // 
            this.simpleButton16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton16.ImageOptions.Image")));
            this.simpleButton16.Location = new System.Drawing.Point(237, 178);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(181, 31);
            this.simpleButton16.TabIndex = 14;
            this.simpleButton16.Text = "Enforcer [GTA V]";
            this.simpleButton16.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // simpleButton15
            // 
            this.simpleButton15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton15.ImageOptions.Image")));
            this.simpleButton15.Location = new System.Drawing.Point(5, 178);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(181, 31);
            this.simpleButton15.TabIndex = 13;
            this.simpleButton15.Text = "Legacy Menu [GTA V]";
            this.simpleButton15.Click += new System.EventHandler(this.simpleButton15_Click);
            // 
            // simpleButton14
            // 
            this.simpleButton14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton14.ImageOptions.Image")));
            this.simpleButton14.Location = new System.Drawing.Point(237, 141);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(181, 31);
            this.simpleButton14.TabIndex = 12;
            this.simpleButton14.Text = "Medaka [MW3]";
            this.simpleButton14.Click += new System.EventHandler(this.simpleButton14_Click);
            // 
            // simpleButton13
            // 
            this.simpleButton13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.ImageOptions.Image")));
            this.simpleButton13.Location = new System.Drawing.Point(5, 141);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(181, 31);
            this.simpleButton13.TabIndex = 11;
            this.simpleButton13.Text = "Medaka [MW2]";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton13_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton12.ImageOptions.Image")));
            this.simpleButton12.Location = new System.Drawing.Point(237, 104);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(181, 31);
            this.simpleButton12.TabIndex = 10;
            this.simpleButton12.Text = "Velonia [GHOSTS]";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.simpleButton11.Location = new System.Drawing.Point(5, 104);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(181, 31);
            this.simpleButton11.TabIndex = 9;
            this.simpleButton11.Text = "Medaka [GHOSTS]";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton10.ImageOptions.Image")));
            this.simpleButton10.Location = new System.Drawing.Point(237, 67);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(181, 31);
            this.simpleButton10.TabIndex = 8;
            this.simpleButton10.Text = "MW2 RCE [MW2]";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton9.ImageOptions.Image")));
            this.simpleButton9.Location = new System.Drawing.Point(5, 67);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(181, 31);
            this.simpleButton9.TabIndex = 7;
            this.simpleButton9.Text = "Legacy [GHOSTS]";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.Location = new System.Drawing.Point(237, 30);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(181, 31);
            this.simpleButton7.TabIndex = 6;
            this.simpleButton7.Text = "BO1 Shit Menu [BO1]";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.ImageOptions.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(5, 30);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(181, 31);
            this.simpleButton8.TabIndex = 4;
            this.simpleButton8.Text = "Frostbite [GTA V]";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 58);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(423, 23);
            this.separatorControl1.TabIndex = 37;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(159, 87);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(131, 24);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "Module Loader";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(228, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(207, 31);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Open Module Configurator Tool";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(210, 31);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Unload Last Module";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ModuleLibTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(447, 564);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ModuleLibTool.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "ModuleLibTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module Library";
            this.Load += new System.EventHandler(this.ModuleLibTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x040008E2 RID: 2274
        private global::System.ComponentModel.IContainer icontainer_0;

        // Token: 0x040008E3 RID: 2275
        private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

        // Token: 0x040008E4 RID: 2276
        private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

        // Token: 0x040008E5 RID: 2277
        private global::DevExpress.XtraEditors.GroupControl groupControl1;

        // Token: 0x040008E6 RID: 2278
        private global::DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;

        // Token: 0x040008E7 RID: 2279
        private global::DevExpress.XtraEditors.SimpleButton simpleButton3;

        // Token: 0x040008E8 RID: 2280
        private global::DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;

        // Token: 0x040008E9 RID: 2281
        private global::DevExpress.XtraEditors.SimpleButton simpleButton4;

        // Token: 0x040008EA RID: 2282
        private global::DevExpress.XtraEditors.GroupControl groupControl2;

        // Token: 0x040008EB RID: 2283
        private global::DevExpress.XtraEditors.SimpleButton simpleButton5;

        // Token: 0x040008EC RID: 2284
        private global::DevExpress.XtraEditors.SimpleButton simpleButton6;

        // Token: 0x040008ED RID: 2285
        private global::DevExpress.XtraEditors.GroupControl groupControl3;

        // Token: 0x040008EE RID: 2286
        private global::DevExpress.XtraEditors.SimpleButton simpleButton16;

        // Token: 0x040008EF RID: 2287
        private global::DevExpress.XtraEditors.SimpleButton simpleButton15;

        // Token: 0x040008F0 RID: 2288
        private global::DevExpress.XtraEditors.SimpleButton simpleButton14;

        // Token: 0x040008F1 RID: 2289
        private global::DevExpress.XtraEditors.SimpleButton simpleButton13;

        // Token: 0x040008F2 RID: 2290
        private global::DevExpress.XtraEditors.SimpleButton simpleButton12;

        // Token: 0x040008F3 RID: 2291
        private global::DevExpress.XtraEditors.SimpleButton simpleButton11;

        // Token: 0x040008F4 RID: 2292
        private global::DevExpress.XtraEditors.SimpleButton simpleButton10;

        // Token: 0x040008F5 RID: 2293
        private global::DevExpress.XtraEditors.SimpleButton simpleButton9;

        // Token: 0x040008F6 RID: 2294
        private global::DevExpress.XtraEditors.SimpleButton simpleButton7;

        // Token: 0x040008F7 RID: 2295
        private global::DevExpress.XtraEditors.SimpleButton simpleButton8;

        // Token: 0x040008F8 RID: 2296
        private global::DevExpress.XtraEditors.SeparatorControl separatorControl1;

        // Token: 0x040008F9 RID: 2297
        private global::DevExpress.XtraEditors.LabelControl labelControl9;

        // Token: 0x040008FA RID: 2298
        private global::DevExpress.XtraEditors.SimpleButton simpleButton17;
    }
}