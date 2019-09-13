using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            TxtMailAdresi.Text = mail;
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient(); //istemci nesnesi
            istemci.Credentials = new System.Net.NetworkCredential("Mail", "Sifre"); //istemcinin kimiği ve ağ kimliği
            istemci.Port = 587; // Türkiyede kullanılan mail adresi port
            istemci.Host = "smtp.live.com"; // istersek gmail yapabiliriz.
            istemci.EnableSsl = true;
            mesajim.To.Add(RchMesaj.Text);
            mesajim.From = new MailAddress("Mail"); //kime gönderilecek
            mesajim.Subject = TxtKonu.Text;
            mesajim.Body = RchMesaj.Text;
            istemci.Send(mesajim);
            
        }
    }
}
