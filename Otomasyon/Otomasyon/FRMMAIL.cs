using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Otomasyon
{
    public partial class FRMMAIL : Form
    {
        public FRMMAIL()
        {
            InitializeComponent();
        }
        public string mail;
        private void FRMMAIL_Load(object sender, EventArgs e)
        {
            txtmail.Text = mail;
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();

            istemci.UseDefaultCredentials = false;
            istemci.Credentials = new System.Net.NetworkCredential("stfincos@gmail.com", "Meftun2001");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(txtmail.Text);
            mesaj.From = new MailAddress("stfincos@gmail.com", "Maftun Hahsimli");
            mesaj.Subject = txtkonu.Text;
            mesaj.Body = txtmesaj.Text;
            istemci.Send(mesaj);

     
  
      

        }
    }
}
