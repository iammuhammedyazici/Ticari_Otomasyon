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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from TBL_ADMIN " +
            "WHERE KULLANICIAD=@P1 AND SIFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul fr = new FrmAnaModul();
                fr.kullanici = TxtKullaniciAd.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGirisYap_MouseHover(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.White;

        }

        private void BtnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.DeepSkyBlue;

        }
    }
}
