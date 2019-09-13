namespace Ticari_Otomasyon
{
    partial class FrmGiderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.CmbYil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.CmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchNotlar = new System.Windows.Forms.RichTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSu = new DevExpress.XtraEditors.TextEdit();
            this.TxtElektrik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtInternet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtEkstra = new DevExpress.XtraEditors.TextEdit();
            this.TxtMaaslar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaaslar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1477, 876);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(26, 614);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(126, 47);
            this.BtnTemizle.TabIndex = 31;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // CmbYil
            // 
            this.CmbYil.Location = new System.Drawing.Point(106, 102);
            this.CmbYil.Name = "CmbYil";
            this.CmbYil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CmbYil.Properties.Appearance.Options.UseFont = true;
            this.CmbYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbYil.Properties.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.CmbYil.Size = new System.Drawing.Size(173, 24);
            this.CmbYil.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(26, 280);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(65, 18);
            this.labelControl11.TabIndex = 29;
            this.labelControl11.Text = "Maaşlar : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 247);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 18);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "İnternet : ";
            // 
            // CmbAy
            // 
            this.CmbAy.Location = new System.Drawing.Point(106, 64);
            this.CmbAy.Name = "CmbAy";
            this.CmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.CmbAy.Properties.Appearance.Options.UseFont = true;
            this.CmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.CmbAy.Size = new System.Drawing.Size(173, 24);
            this.CmbAy.TabIndex = 2;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(193, 614);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(126, 47);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(193, 536);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(126, 47);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(26, 536);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(126, 47);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchNotlar
            // 
            this.RchNotlar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.RchNotlar.Location = new System.Drawing.Point(106, 354);
            this.RchNotlar.Name = "RchNotlar";
            this.RchNotlar.Size = new System.Drawing.Size(173, 106);
            this.RchNotlar.TabIndex = 10;
            this.RchNotlar.Text = "";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(35, 313);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 18);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Ekstra :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(32, 143);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Elektrik : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(35, 356);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 18);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Notlar : ";
            // 
            // TxtSu
            // 
            this.TxtSu.Location = new System.Drawing.Point(106, 172);
            this.TxtSu.Name = "TxtSu";
            this.TxtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtSu.Properties.Appearance.Options.UseFont = true;
            this.TxtSu.Size = new System.Drawing.Size(173, 24);
            this.TxtSu.TabIndex = 5;
            // 
            // TxtElektrik
            // 
            this.TxtElektrik.Location = new System.Drawing.Point(106, 137);
            this.TxtElektrik.Name = "TxtElektrik";
            this.TxtElektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtElektrik.Properties.Appearance.Options.UseFont = true;
            this.TxtElektrik.Size = new System.Drawing.Size(173, 24);
            this.TxtElektrik.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(17, 212);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 18);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Doğalgaz : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(60, 178);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Su : ";
            // 
            // TxtInternet
            // 
            this.TxtInternet.Location = new System.Drawing.Point(106, 244);
            this.TxtInternet.Name = "TxtInternet";
            this.TxtInternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtInternet.Properties.Appearance.Options.UseFont = true;
            this.TxtInternet.Size = new System.Drawing.Size(173, 24);
            this.TxtInternet.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(62, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Yıl : ";
            // 
            // TxtDogalgaz
            // 
            this.TxtDogalgaz.Location = new System.Drawing.Point(106, 208);
            this.TxtDogalgaz.Name = "TxtDogalgaz";
            this.TxtDogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtDogalgaz.Properties.Appearance.Options.UseFont = true;
            this.TxtDogalgaz.Size = new System.Drawing.Size(173, 24);
            this.TxtDogalgaz.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ay : ";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(106, 31);
            this.Txtid.Name = "Txtid";
            this.Txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Txtid.Properties.Appearance.Options.UseFont = true;
            this.Txtid.Size = new System.Drawing.Size(173, 24);
            this.Txtid.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtEkstra);
            this.groupControl1.Controls.Add(this.TxtMaaslar);
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.CmbYil);
            this.groupControl1.Controls.Add(this.TxtInternet);
            this.groupControl1.Controls.Add(this.TxtDogalgaz);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.CmbAy);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchNotlar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtSu);
            this.groupControl1.Controls.Add(this.TxtElektrik);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1478, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(404, 876);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "groupControl1";
            // 
            // TxtEkstra
            // 
            this.TxtEkstra.Location = new System.Drawing.Point(106, 312);
            this.TxtEkstra.Name = "TxtEkstra";
            this.TxtEkstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtEkstra.Properties.Appearance.Options.UseFont = true;
            this.TxtEkstra.Size = new System.Drawing.Size(173, 24);
            this.TxtEkstra.TabIndex = 9;
            // 
            // TxtMaaslar
            // 
            this.TxtMaaslar.Location = new System.Drawing.Point(106, 278);
            this.TxtMaaslar.Name = "TxtMaaslar";
            this.TxtMaaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMaaslar.Properties.Appearance.Options.UseFont = true;
            this.TxtMaaslar.Size = new System.Drawing.Size(173, 24);
            this.TxtMaaslar.TabIndex = 8;
            // 
            // FrmGiderler
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(1882, 878);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaaslar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
        private DevExpress.XtraEditors.ComboBoxEdit CmbYil;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit CmbAy;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSu;
        private DevExpress.XtraEditors.TextEdit TxtElektrik;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtInternet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtDogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtEkstra;
        private DevExpress.XtraEditors.TextEdit TxtMaaslar;
    }
}