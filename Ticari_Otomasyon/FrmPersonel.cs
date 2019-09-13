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


    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void personellistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER order by ID asc", bgl.baglanti());
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
        void personelTemizle()
        {
            Txtid.Text = "";
            txtAd.Text = "";
            TxtSoyad.Text = "";
            TxtGorev.Text = "";
            TxtMail.Text = "";
            MskTC.Text = "";
            MskTelefon1.Text = "";
            RchAdres.Text = "";

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personellistele();
            sehirlistesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER" +
                "(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellistele();
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
            bgl.baglanti();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            personelTemizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                TxtSoyad.Text = dr["SOYAD"].ToString();
                MskTelefon1.Text = dr["TELEFON"].ToString();
                MskTC.Text = dr["TC"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                Cmbil.Text = dr["IL"].ToString();
                Cmbilce.Text = dr["ILCE"].ToString();
                RchAdres.Text = dr["ADRES"].ToString();
                TxtGorev.Text = dr["GOREV"].ToString();

            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult uyari;
            uyari = MessageBox.Show("Silmek istediğinize emin misiniz ?", "UYARI!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyari == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("DELETE FROM TBL_PERSONELLER where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", Txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma listeden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                personellistele();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER " +
                "set AD=@P1, SOYAD=@P2, TELEFON=@P3, TC=@P4, MAIL=@P5,IL=@P6, ILCE=@P7,ADRES=@P8,GOREV=@P9 " +
                "where ID=@P10",
             bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon1.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", Cmbil.Text);
            komut.Parameters.AddWithValue("@p7", Cmbilce.Text);
            komut.Parameters.AddWithValue("@p8", RchAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p10", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Personel Bilgisi Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellistele();
        }
    }
}
