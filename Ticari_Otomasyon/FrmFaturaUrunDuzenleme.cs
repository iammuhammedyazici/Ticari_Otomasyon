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
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            TxtUrunid.Text = urunid;
            SqlCommand komut = new SqlCommand("Select *from TBL_FATURADETAY WHERE FATURAURUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrun.Text = dr[1].ToString();
                txtMiktar.Text = dr[2].ToString();
                TxtFiyat.Text = dr[3].ToString();
                TxtTutar.Text = dr[4].ToString();
                bgl.baglanti().Close();
            }

        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(TxtFiyat.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = miktar * fiyat;
            TxtTutar.Text = tutar.ToString();

            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY SET " +
                "URUNAD=@P1, MIKTAR=@P2, FIYAT=@P3, TUTAR=@P4 " +
                "WHERE FATURAURUNID=@P5", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtUrun.Text);
            komut.Parameters.AddWithValue("@p2", txtMiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p5", TxtUrunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY WHERE FATURAURUNID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
