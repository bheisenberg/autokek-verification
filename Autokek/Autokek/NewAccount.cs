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
        private string passwordMessage = "Your password must use valid charcters";
        private string usernameMessage = "Your username can only use alphanumeric values";
        private string emailMessage = "Your email must be valid";
        public NewAccount()
        {
            InitializeComponent();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            usernameField.Focus();
        }

        private void setErrorMessage (Label field, String message)
        {
            field.Visible = true;
            field.Text = message;
        }

        private void hideErrorMessage (Label field)
        {
            field.Visible = false;
        }

        private void create_Click(object sender, EventArgs e) {

            User user = new User(usernameField.Text, emailField.Text, passwordField.Text, confirmField.Text);
            if (user.validName()) {
                setErrorMessage(usernameError, usernameMessage);
            }
            else
            {
                hideErrorMessage(usernameError);
            }

            if (!user.validEmail()) { 
                setErrorMessage(usernameError, usernameMessage);
            }
            else
            {
                hideErrorMessage(usernameError);
            }
            Console.WriteLine("Username ("+user.username+"): " + user.validName());
            Console.WriteLine("Email: " + user.validEmail());
            Console.WriteLine("Password: " + user.validPassword());
            Console.WriteLine("Password Match: " + user.matchingPassword());
            if (user.isValid()) 
            {
                user.verificationCode = generateVerification();
                //SwitchControl(new VerificationPanel(user));
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

        private string generateVerification()
        {
            int min = 0;
            int max = 9;
            int sequenceLength = 6;
            string sequence = "";
            Random rand = new Random();
            for (int i = 0; i < sequenceLength; i++)
            {
                sequence += rand.Next(min, max);
            }
            return sequence;
        }
    }
}
