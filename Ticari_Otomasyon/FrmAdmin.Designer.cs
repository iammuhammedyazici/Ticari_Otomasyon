namespace Ticari_Otomasyon
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(110, 177);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            this.TxtKullaniciAd.Size = new System.Drawing.Size(206, 26);
            this.TxtKullaniciAd.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(110, 219);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtSifre.Properties.UseSystemPasswordChar = true;
            this.TxtSifre.Size = new System.Drawing.Size(206, 26);
            this.TxtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre : ";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnGirisYap.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.BtnGirisYap.Location = new System.Drawing.Point(110, 265);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(206, 46);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            this.BtnGirisYap.MouseLeave += new System.EventHandler(this.BtnGirisYap_MouseLeave);
            this.BtnGirisYap.MouseHover += new System.EventHandler(this.BtnGirisYap_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(183, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ShadowSoft-2019";
            // 
            // FrmAdmin
            // 
            this.AcceptButton = this.BtnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAd;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label3;
    }
}