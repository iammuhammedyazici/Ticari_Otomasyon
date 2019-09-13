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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
        void temizle()
        {
            TxtBaslik.Text = "";
            txtHitap.Text = "";
            Txtid.Text = "";
            TxtOlusturan.Text = "";
            RchDetay.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR " +
                "(TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP) " +
                "VALUES " +
                "(@P1,@P2,@P3,@P4,@P5,@P6)",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RchDetay.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Bilgisi Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Gridde seçili olanı textboxlara çekme
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//Satırın verisini al
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                MskSaat.Text = dr["SAAT"].ToString();
                TxtBaslik.Text = dr["BASLIK"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
                TxtOlusturan.Text = dr["OLUSTURAN"].ToString();
                txtHitap.Text = dr["HITAP"].ToString();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi
            DialogResult uyari;
            uyari = MessageBox.Show("Silmek istediğinize emin misiniz ?", "UYARI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("Delete From TBL_NOTLAR where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti();
                MessageBox.Show("Not Silindi. ", "Uyarı!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();
            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_NOTLAR set " +
              "TARIH=@P1, SAAT=@P2, BASLIK=@P3, DETAY=@P4, OLUSTURAN=@P5,HITAP=@P6 " +
              "where ID=@P7",
              bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RchDetay.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtHitap.Text);
            komut.Parameters.AddWithValue("@P7", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Not bilgisi güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr !=null)
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
    }


