using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DboTicariOtomasyonuDataSet5.TBL_PERSONELLER' table. You can move, or remove it, as needed.
            this.TBL_PERSONELLERTableAdapter.Fill(this.DboTicariOtomasyonuDataSet5.TBL_PERSONELLER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonuDataSet4.TBL_GIDERLER' table. You can move, or remove it, as needed.
            this.TBL_GIDERLERTableAdapter.Fill(this.DboTicariOtomasyonuDataSet4.TBL_GIDERLER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonuDataSet1.TBL_MUSTERILER' table. You can move, or remove it, as needed.
            this.TBL_MUSTERILERTableAdapter.Fill(this.DboTicariOtomasyonuDataSet1.TBL_MUSTERILER);
            // TODO: This line of code loads data into the 'DboTicariOtomasyonuDataSet.TBL_FIRMALAR' table. You can move, or remove it, as needed.
            this.TBL_FIRMALARTableAdapter.Fill(this.DboTicariOtomasyonuDataSet.TBL_FIRMALAR);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}
