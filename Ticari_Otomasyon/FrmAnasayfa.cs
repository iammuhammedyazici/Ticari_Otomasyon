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
using System.Xml;

namespace Ticari_Otomasyon
{
    public partial class FrmAnasayfa : Form
    {
        int SimdikiWidth = 1386;
        int SimdikiHeight = 642;
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        
        //Stoklar
        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Urunad, Sum(Adet) as 'Adet' From TBL_URUNLER group by URUNAD " +
                "having Sum(ADET) <= 20 order by Sum(Adet)", bgl.baglanti());
            da.Fill(dt);
            GridControlStoklar.DataSource = dt;
        }
        void ajanda()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select top 8 TARIH, SAAT, BASLIK from TBL_NOTLAR " +
                "order by ID desc ", bgl.baglanti());
            da2.Fill(dt2);
            GridControlAjanda.DataSource = dt2;
        }
        void firmaHareket()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Exec FIRMAHAREKET2 ", bgl.baglanti());
            da3.Fill(dt3);
            GridControlSonOnHareket.DataSource = dt3;
        }
        void fihrist()
        {
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select ad,telefon1 from TBL_FIRMALAR", bgl.baglanti());
            da4.Fill(dt4);
            GridControlFihrist.DataSource = dt4;
        }
        void haberler()
        {
            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if (xmloku.Name=="title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Rectangle ClienCozunurluk = new Rectangle();
            ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            float OranHeight = ((float)ClienCozunurluk.Height / (float)SimdikiHeight);
            this.Scale(new SizeF(OranWidth, OranHeight));

            stoklar();
            ajanda();
            firmaHareket();
            fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
            haberler();
        }

        private void GridControlSonOnHareket_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
