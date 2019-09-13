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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            TxtAlici.Text = "";
            Txtid.Text = "";
            TxtTeden.Text = "";
            TxtTalan.Text = "";
            TxtVergiDairesi.Text = "";
            txtSeri.Text = "";
            TxtSiraNo.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";

        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            if(TxtFaturaid.Text=="" )
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI " +
                    "(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) " +
                    "VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)",
                    bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtSeri.Text);
                komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
                komut.Parameters.AddWithValue("@P3", MskTarih.Text);
                komut.Parameters.AddWithValue("@P4", MskSaat.Text);
                komut.Parameters.AddWithValue("@P5", TxtVergiDairesi.Text);
                komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
                komut.Parameters.AddWithValue("@P7", TxtTeden.Text);
                komut.Parameters.AddWithValue("@P8", TxtTalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            //Firma Carisi
            if (TxtFaturaid.Text!="" && comboBox1.Text == "Firma")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;

                TxtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY " +
                    "(URUNAD, MIKTAR,FIYAT,TUTAR,FATURAID)" +
                    "VALUES" +
                    "(@P1,@P2,@P3,@P4,@P5)",
                    bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtUrun.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", TxtFaturaid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                //Hareket Tablosuna Veri Girişi

                SqlCommand komut3 = new SqlCommand("insert into TBL_FIRMAHAREKETLER" +
                    "(URUNID, ADET, PERSONEL, FIRMA, FIYAT, TOPLAM, FATURAID, TARIH) " +
                    "VALUES (@H1,@H2,@H3,@H4,@H5,@H6,@H7,@H8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", TxtUrunid.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", TxtFaturaid.Text);
                komut3.Parameters.AddWithValue("@h8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Stok Sayısını Azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@S1 WHERE ID=@S1", bgl.baglanti());
                komut4.Parameters.AddWithValue("@S1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@S2", TxtUrunid.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        
            //Müşteri Carisi
            if (TxtFaturaid.Text != "" && comboBox1.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;

                TxtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY " +
                    "(URUNAD, MIKTAR,FIYAT,TUTAR,FATURAID)" +
                    "VALUES" +
                    "(@P1,@P2,@P3,@P4,@P5)",
                    bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtUrun.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(TxtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", TxtFaturaid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                //Hareket Tablosuna Veri Girişi

                SqlCommand komut3 = new SqlCommand("insert into TBL_MUSTERIHAREKET" +
                    "(URUNID, ADET, PERSONEL, MUSTERI, FIYAT, TOPLAM, FATURAID, TARIH) " +
                    "VALUES (@H1,@H2,@H3,@H4,@H5,@H6,@H7,@H8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", TxtUrunid.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(TxtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(TxtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", TxtFaturaid.Text);
                komut3.Parameters.AddWithValue("@h8", MskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Stok Sayısını Azaltma
                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER SET ADET=ADET-@S1 WHERE ID=@S1", bgl.baglanti());
                komut4.Parameters.AddWithValue("@S1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@S2", TxtUrunid.Text);
                komut4.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//Satırın verisini al
            if (dr != null)
            {
                Txtid.Text = dr["FATURABILGIID"].ToString();
                txtSeri.Text = dr["SERI"].ToString();
                TxtSiraNo.Text = dr["SIRANO"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtAlici.Text = dr["ALICI"].ToString();
                TxtTeden.Text = dr["TESLIMEDEN"].ToString();
                TxtTalan.Text = dr["TESLIMALAN"].ToString();
                TxtVergiDairesi.Text = dr["VERGIDAIRE"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult uyari;
            uyari = MessageBox.Show("Silmek istediğinize emin misiniz ?", "UYARI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_FATURABILGI WHERE FATURABILGIID=@P1 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Silindi", "Uyarı!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                listele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURABILGI set " +
              "SERI=@P1, SIRANO=@P2, TARIH=@P3, SAAT=@P4, VERGIDAIRE=@P5, ALICI=@P6, TESLIMEDEN=@P7, TESLIMALAN=@P8 " +
              "where FATURABILGIID=@P9",
              bgl.baglanti());
          komut.Parameters.AddWithValue("@P1", txtSeri.Text);
            komut.Parameters.AddWithValue("@P2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@P3", MskTarih.Text);
            komut.Parameters.AddWithValue("@P4", MskSaat.Text);
            komut.Parameters.AddWithValue("@P5", TxtVergiDairesi.Text);
            komut.Parameters.AddWithValue("@P6", TxtAlici.Text);
            komut.Parameters.AddWithValue("@P7", TxtTeden.Text);
            komut.Parameters.AddWithValue("@P8", TxtTalan.Text);
            komut.Parameters.AddWithValue("@P9", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr!=null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
                fr.Show();
                    }
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select URUNAD, SATISFIYAT FROM TBL_URUNLER WHERE ID=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunid.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrun.Text = dr[0].ToString();
                TxtFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
                }
    }
}
