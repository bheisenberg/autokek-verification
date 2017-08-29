using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Autokek
{
    public partial class VerificationPanel : UserControl
    {
        private User user;
        public VerificationPanel(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void VerificationPanel_Load(object sender, EventArgs e)
        {
            emailLabel.Text = user.email;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("admin@autokek.com");
            message.To.Add(user.email);
            message.Subject = "Verification code for Autokek";
            message.Body = string.Format("Your verification code is {0}", user.verificationCode);
            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Credentials = new NetworkCredential("autokekker@gmail.com", "bigkekker"),
                EnableSsl = true
            };
            smtp.Send(message);
        }
    }
}
