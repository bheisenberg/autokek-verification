using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokek
{
    public class User
    {
        public User (String username)
        {
            this.username = username;
            this.exists = doesExist();
        }

        public User (String username, String email, String password, String confirmPassword)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.confirmPassword = confirmPassword;
            this.valid = isValid();
        }

        public string username { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string email { get; set; }
        public bool exists;
        public bool valid;
        public string verificationCode { get; set; }
        private int[] usernameBounds = new int[] { 3, 16 };

        private bool validName ()
        {
            return (username.Length >= usernameBounds[0] && username.Length <= usernameBounds[1]);
        }

        private bool doesExist()
        {
            DBConnector connection = new DBConnector();
            return connection.UserExists(this.username);
        }

        private bool isValid ()
        {
            return (validName() && validEmail() && validPassword() && matchingPassword() && !doesExist());
        }

        private bool validEmail()
        {
            return true;
        }

        private bool validPassword()
        {
            return (password.Length >= 8 && password.Length < 100);
        }

        private bool matchingPassword()
        {
            return (password == confirmPassword);
        }

    }
}
