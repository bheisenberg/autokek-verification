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
    public partial class NewAccount : UserControl
    {
        private string mismatchMessage = "Your passwords do not match";
        public NewAccount()
        {
            InitializeComponent();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            emailField.Focus();
        }

        private void setErrorMessage (String message)
        {
            errorLabel.Visible = true;
            errorLabel.Text = message;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (passwordField.Text == confirmField.Text)
            {
                User newUser = new User(usernameField.Text, emailField.Text, passwordField.Text);
                generateVerification();
                SwitchControl(new VerificationPanel());
            }
            else
            {
                setErrorMessage(mismatchMessage);
            }
        }

        private void SwitchControl(UserControl control)
        {
            Controls.Clear();
            Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private int generateVerification()
        {
            int min = 0;
            int max = 9;
            int sequenceLength = 5;
            string sequence = "";
            Random rand = new Random();
            for (int i = 0; i < sequenceLength; i++)
            {
                sequence += rand.Next(min, max);
            }
            Console.WriteLine(sequence);
            return Int32.Parse(sequence);
        }
    }
}
