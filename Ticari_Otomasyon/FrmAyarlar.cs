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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from TBL_ADMIN", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            txtKullaniciAdi.Text = "";
            TxtSifre.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (BtnKaydet.Text == "Kaydet")
            {

                SqlCommand komut = new SqlCommand("insert into TBL_ADMIN VALUES (@P1, @P2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (BtnKaydet.Text == "Güncelle")
            {
                SqlCommand komut = new SqlCommand("update TBL_ADMIN set SIFRE=@P2 WHERE KULLANICIAD=@P1)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr !=null)
            {
                txtKullaniciAdi.Text = dr["KULLANICIAD"].ToString();
                TxtSifre.Text = dr["SIFRE"].ToString();
            }
        }

        private void txtKullaniciAdi_EditValueChanged(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text != "")
            {
                BtnKaydet.Text = "Güncelle";
                BtnKaydet.BackColor = Color.Azure;
            }
            else
            {
                BtnKaydet.Text = "Kaydet";
                BtnKaydet.BackColor = Color.Yellow;

            }
        }
    }
}
