using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autokek
{
    public partial class PasswordPanel : UserControl
    {
        private User user;
        public PasswordPanel(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordPanel_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = string.Format("Welcome, {0}", user.username);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PasswordHash.ValidatePassword(passwordField.Text, DBConnector.GetPassword(user.username))) {
                Console.WriteLine("Success, password matched!");
            }
            else
            {
                Console.WriteLine("Password does not match.");
            }
        }
    }
}
