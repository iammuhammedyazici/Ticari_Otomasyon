namespace Ticari_Otomasyon
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.NudAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSatis = new DevExpress.XtraEditors.TextEdit();
            this.TxtAlis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.MskYil = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1475, 878);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchDetay);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TxtModel);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.NudAdet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtSatis);
            this.groupControl1.Controls.Add(this.TxtAlis);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtMarka);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.MskYil);
            this.groupControl1.Controls.Add(this.Txtid);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1477, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(404, 878);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnTemizle.Appearance.Options.UseFont = true;
            this.BtnTemizle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(40, 606);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(126, 47);
            this.BtnTemizle.TabIndex = 44;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(196, 606);
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
            this.BtnSil.Location = new System.Drawing.Point(196, 525);
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
            this.BtnKaydet.Location = new System.Drawing.Point(40, 525);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(126, 47);
            this.BtnKaydet.TabIndex = 22;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchDetay
            // 
            this.RchDetay.Font = new System.Drawing.Font("Tahoma", 11F);
            this.RchDetay.Location = new System.Drawing.Point(105, 366);
            this.RchDetay.Name = "RchDetay";
            this.RchDetay.Size = new System.Drawing.Size(173, 96);
            this.RchDetay.TabIndex = 9;
            this.RchDetay.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(56, 197);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(29, 18);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Yıl : ";
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(105, 153);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtModel.Properties.Appearance.Options.UseFont = true;
            this.TxtModel.Size = new System.Drawing.Size(173, 24);
            this.TxtModel.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(5, 323);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 18);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Satış Fiyat : ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(36, 156);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 18);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Model : ";
            // 
            // NudAdet
            // 
            this.NudAdet.Font = new System.Drawing.Font("Tahoma", 11F);
            this.NudAdet.Location = new System.Drawing.Point(105, 233);
            this.NudAdet.Name = "NudAdet";
            this.NudAdet.Size = new System.Drawing.Size(173, 25);
            this.NudAdet.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(31, 366);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 18);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Detay : ";
            // 
            // TxtSatis
            // 
            this.TxtSatis.Location = new System.Drawing.Point(105, 320);
            this.TxtSatis.Name = "TxtSatis";
            this.TxtSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtSatis.Properties.Appearance.Options.UseFont = true;
            this.TxtSatis.Size = new System.Drawing.Size(173, 24);
            this.TxtSatis.TabIndex = 8;
            // 
            // TxtAlis
            // 
            this.TxtAlis.Location = new System.Drawing.Point(105, 275);
            this.TxtAlis.Name = "TxtAlis";
            this.TxtAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtAlis.Properties.Appearance.Options.UseFont = true;
            this.TxtAlis.Size = new System.Drawing.Size(173, 24);
            this.TxtAlis.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 281);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 18);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "Alış Fiyat : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(40, 235);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Adet : ";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(105, 110);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.TxtMarka.Properties.Appearance.Options.UseFont = true;
            this.TxtMarka.Size = new System.Drawing.Size(173, 24);
            this.TxtMarka.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Marka : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 70);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(173, 24);
            this.txtAd.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(55, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad : ";
            // 
            // MskYil
            // 
            this.MskYil.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MskYil.Location = new System.Drawing.Point(105, 194);
            this.MskYil.Mask = "0000";
            this.MskYil.Name = "MskYil";
            this.MskYil.Size = new System.Drawing.Size(173, 25);
            this.MskYil.TabIndex = 5;
            this.MskYil.ValidatingType = typeof(int);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(105, 31);
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
            this.labelControl1.Location = new System.Drawing.Point(55, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // FrmUrunler
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnTemizle;
            this.ClientSize = new System.Drawing.Size(1882, 878);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchDetay;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit TxtModel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.NumericUpDown NudAdet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSatis;
        private DevExpress.XtraEditors.TextEdit TxtAlis;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.MaskedTextBox MskYil;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}