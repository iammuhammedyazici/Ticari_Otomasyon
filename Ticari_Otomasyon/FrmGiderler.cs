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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER Order By ID ASC ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderlistesi();
            giderTemizle();
        }
        void giderTemizle()
        {
            Txtid.Text = "";
            CmbAy.Text = "";
            CmbYil.Text = "";
            TxtElektrik.Text = "";
            TxtSu.Text = "";
            TxtDogalgaz.Text = "";
            TxtInternet.Text = "";
            TxtMaaslar.Text = "";
            TxtEkstra.Text = "";
            RchNotlar.Text = "";

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER" +
                "(AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            komut.Parameters.AddWithValue("@p2", CmbYil.Text);
            komut.Parameters.AddWithValue("@p3", TxtElektrik.Text);
            komut.Parameters.AddWithValue("@p4", TxtSu.Text);
            komut.Parameters.AddWithValue("@p5", TxtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p6", TxtInternet.Text);
            komut.Parameters.AddWithValue("@p7", TxtMaaslar.Text);
            komut.Parameters.AddWithValue("@p8", TxtEkstra.Text);
            komut.Parameters.AddWithValue("@p9", RchNotlar.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bu ay ki giderler sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult uyari;
            uyari = MessageBox.Show("Silmek istediğinize emin misiniz ?", "UYARI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_GIDERLER where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                giderlistesi();

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                CmbAy.Text = dr["AY"].ToString();
                CmbYil.Text = dr["YIL"].ToString();
                TxtElektrik.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtDogalgaz.Text = dr["DOGALGAZ"].ToString();
                TxtInternet.Text = dr["INTERNET"].ToString();
                TxtMaaslar.Text = dr["MAASLAR"].ToString();
                TxtEkstra.Text = dr["EKSTRA"].ToString();
                RchNotlar.Text = dr["NOTLAR"].ToString();

            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            giderTemizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_GIDERLER set " +
                "AY=@P1, YIL=@P2, ELEKTRIK=@P3, SU=@P4, DOGALGAZ=@P5,INTERNET=@P6, MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 " +
                "where ID=@P10",
             bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbAy.Text);
            komut.Parameters.AddWithValue("@p2", CmbYil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtSu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtDogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtMaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@p9", RchNotlar.Text);
            komut.Parameters.AddWithValue("@p10", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Personel Bilgisi Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            giderTemizle();
        }

       
    }
}
