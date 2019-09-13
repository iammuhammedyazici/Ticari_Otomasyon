using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmBankalar : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmBankalar()
        {
            InitializeComponent();
        }
        void bankalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        void firmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID, AD from TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        void temizle()
        {
            txtBankaAd.Text = "";
            TxtIban.Text = "";
            TxtSube.Text = "";
            lookUpEdit1.Text = "";
            TxtHesapNo.Text = "";
            TxtHesapTuru.Text = "";
            Txtid.Text = "";
            TxtYetkili.Text = "";
            Cmbil.Text = "";
            Cmbilce.Text = "";
            MskTarih.Text = "";
            MskTelefon.Text = "";
            
        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            bankalistele();
            sehirlistesi();
            firmaListesi();
        }
      
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Gridde seçili olanı textboxlara çekme
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//Satırın verisini al
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                txtBankaAd.Text = dr["BANKAADI"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                TxtSube.Text = dr["SUBE"].ToString();
                TxtIban.Text = dr["IBAN"].ToString();
                TxtHesapNo.Text = dr["HESAPNO"].ToString();
                TxtYetkili.Text = dr["YETKILI"].ToString();
                MskTelefon.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();

            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR " +
                "(BANKAADI, IL, ILCE, SUBE, IBAN, HESAPNO, YETKILI, TELEFON, TARIH, HESAPTURU, FIRMAID)" +
                "values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)"
                , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBankaAd.Text);
            komut.Parameters.AddWithValue("@p2", Cmbil.Text);
            komut.Parameters.AddWithValue("@p3", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", TxtSube.Text);
            komut.Parameters.AddWithValue("@p5", TxtIban.Text);
            komut.Parameters.AddWithValue("@p6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bankalistele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi sisteme kaydoldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmbilce.Properties.Items.Clear();

            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_bankalar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            bankalistele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_BANKALAR SET " +
                "BANKAADI=@P1, IL=@P2, ILCE=@P3, SUBE=@P4, IBAN=@P5, HESAPNO=@P6, YETKILI=@P7, " +
                "TELEFON=@P8, TARIH=@P9, HESAPTURU=@P10, FIRMAID=@P11 " +
                "WHERE ID=@P11", 
                bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtBankaAd.Text);
            komut.Parameters.AddWithValue("@P2", Cmbil.Text);
            komut.Parameters.AddWithValue("@P3", Cmbilce.Text);
            komut.Parameters.AddWithValue("@P4", TxtSube.Text);
            komut.Parameters.AddWithValue("@P5", TxtIban.Text);
            komut.Parameters.AddWithValue("@P6", TxtHesapNo.Text);
            komut.Parameters.AddWithValue("@P7", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@P8", MskTelefon.Text);
            komut.Parameters.AddWithValue("@P9", MskTarih.Text);
            komut.Parameters.AddWithValue("@P10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@P12", Txtid.Text);
            komut.ExecuteNonQuery();
            bankalistele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
