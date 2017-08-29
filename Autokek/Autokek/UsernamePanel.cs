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
    public partial class UsernamePanel : UserControl
    {
        public UsernamePanel()
        {
            InitializeComponent();
        }

        private void SwitchControl (UserControl control)
        {
            Controls.Clear();
            Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void CreateUser ()
        {
            User newUser = new User(usernameBox.Text);
            if (newUser.exists)
            {
                SwitchControl(new PasswordPanel(newUser));
            } else
            {
                error.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchControl(new NewAccount());
        }
    }
}
