namespace Ticari_Otomasyon
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtHitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.MskSaat);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchDetay);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.TxtBaslik);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtOlusturan);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtHitap);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.MskTarih);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1478, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(404, 876);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(63, 462);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(126, 47);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskSaat.Location = new System.Drawing.Point(109, 84);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(173, 25);
            this.MskSaat.TabIndex = 3;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(207, 462);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(126, 47);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(207, 386);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(126, 47);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(63, 386);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(126, 47);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchDetay
            // 
            this.RchDetay.Font = new System.Drawing.Font("Tahoma", 12F);
            this.RchDetay.Location = new System.Drawing.Point(109, 236);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(173, 106);
            this.RchDetay.TabIndex = 7;
            this.RchDetay.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(17, 156);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(77, 18);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Oluşturan : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(44, 118);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Başlık : ";
            // 
            // TxtBaslik
            // 
            this.TxtBaslik.Location = new System.Drawing.Point(109, 115);
            this.TxtBaslik.Name = "TxtBaslik";
            this.TxtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtBaslik.Properties.Appearance.Options.UseFont = true;
            this.TxtBaslik.Size = new System.Drawing.Size(173, 24);
            this.TxtBaslik.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(40, 236);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 18);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Detay : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(46, 198);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Hitap : ";
            // 
            // TxtOlusturan
            // 
            this.TxtOlusturan.Location = new System.Drawing.Point(109, 153);
            this.TxtOlusturan.Name = "TxtOlusturan";
            this.TxtOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtOlusturan.Properties.Appearance.Options.UseFont = true;
            this.TxtOlusturan.Size = new System.Drawing.Size(173, 24);
            this.TxtOlusturan.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(49, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Saat :";
            // 
            // txtHitap
            // 
            this.txtHitap.Location = new System.Drawing.Point(109, 195);
            this.txtHitap.Name = "txtHitap";
            this.txtHitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtHitap.Properties.Appearance.Options.UseFont = true;
            this.txtHitap.Size = new System.Drawing.Size(173, 24);
            this.txtHitap.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tarih : ";
            // 
            // MskTarih
            // 
            this.MskTarih.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskTarih.Location = new System.Drawing.Point(109, 50);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(173, 25);
            this.MskTarih.TabIndex = 2;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(109, 13);
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
            this.labelControl1.Location = new System.Drawing.Point(63, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1477, 876);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FrmNotlar
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(1882, 878);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmNotlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit TxtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtOlusturan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtHitap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}