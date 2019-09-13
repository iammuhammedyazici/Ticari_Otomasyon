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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER order by ID asc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Verileri kaydetme
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER " +
                "(URUNAD, MARKA, MODEL, YIL , ADET, ALISFIYAT, SATISFIYAT, DETAY) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((TxtAlis.Text).ToString()));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((TxtSatis.Text).ToString()));
            komut.Parameters.AddWithValue("@p8", RchDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Silme işlemi
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Ürün silindi ", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            listele();
        }
        void temizle()
        {
            txtAd.Text = "";
            TxtAlis.Text = "";
            Txtid.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            TxtSatis.Text = "";
            MskYil.Text = "";
            NudAdet.Value= 0;
            RchDetay.Text = "";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Gridde seçili olanı textboxlara çekme
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);//Satırın verisini al
            if (dr!=null)
            {
                Txtid.Text = dr["ID"].ToString();
                txtAd.Text = dr["URUNAD"].ToString();
                TxtMarka.Text = dr["MARKA"].ToString();
                TxtModel.Text = dr["MODEL"].ToString();
                MskYil.Text = dr["YIL"].ToString();
                NudAdet.Value = decimal.Parse(dr["ADET"].ToString());
                TxtAlis.Text = dr["ALISFIYAT"].ToString();
                TxtSatis.Text = dr["SATISFIYAT"].ToString();
                RchDetay.Text = dr["DETAY"].ToString();
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_URUNLER set " +
                "URUNAD=@P1, MARKA=@P2, MODEL=@P3, YIL=@P4, ADET=@P5,ALISFIYAT=@P6, SATISFIYAT=@P7,DETAY=@P8 where ID=@P9",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P3", TxtModel.Text);
            komut.Parameters.AddWithValue("@P4", MskYil.Text);
            komut.Parameters.AddWithValue("@P5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@P6", decimal.Parse((TxtAlis.Text).ToString()));
            komut.Parameters.AddWithValue("@P7", decimal.Parse((TxtSatis.Text).ToString()));
            komut.Parameters.AddWithValue("@P8", RchDetay.Text);
            komut.Parameters.AddWithValue("@P9", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Ürün bilgisi güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
