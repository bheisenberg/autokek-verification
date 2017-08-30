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
        private string mismatchMessage = "Passwords do not match";
        private string passwordMessage = "Password must use valid characters";
        private string usernameMessage = "Username must use alphanumeric characters";
        private string emailMessage = "Email must be valid";
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

        private void create_Click(object sender, EventArgs e)
        {

            User user = new User(usernameField.Text, emailField.Text, passwordField.Text, confirmField.Text);
            if (!user.isValid())
            {
                if (!user.validName())
                {
                    setErrorMessage(usernameError, usernameMessage);
                }
                else
                {
                    hideErrorMessage(usernameError);
                }

                if (!user.validEmail())
                {
                    setErrorMessage(emailError, emailMessage);
                }
                else
                {
                    hideErrorMessage(emailError);
                }

                if (!user.validPassword())
                {
                    setErrorMessage(passwordError, passwordMessage);
                }
                else
                {
                    hideErrorMessage(passwordError);
                }

                if (!user.matchingPassword())
                {
                    setErrorMessage(mismatchError, mismatchMessage);
                }
                else
                {
                    hideErrorMessage(mismatchError);
                }
            }
            else
            {
                SwitchControl(new VerificationPanel(user));
            }
        }

        private void SwitchControl(UserControl control)
        {
            Controls.Clear();
            Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
