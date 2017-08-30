using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Autokek
{
    public class User
    {
        public User (String username)
        {
            this.username = username;
        }

        public User (String username, String email, String password, String confirmPassword)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        public string username { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string email { get; set; }
        public string verificationCode { get; set; }
        private int[] usernameBounds = new int[] { 3, 16 };
        private string passwordPattern = @"^([a-zA-Z0-9@%+\\/'!#$^\?:\.(){}\[\]~`\-_]){8,100}$";
        private string namePattern = @"^([a-zA-Z]+[0-9]*){3,16}$";

        public bool validName ()
        {
            return (Regex.IsMatch(username, namePattern));
        }

        public bool doesExist()
        {
            DBConnector connection = new DBConnector();
            return connection.UserExists(this.username);
        }

        public bool isValid ()
        {
            return (validName() && validEmail() && validPassword() && matchingPassword() && !doesExist());
        }

        public bool validEmail()
        {
            try
            {
                MailAddress email = new MailAddress(this.email);
                return email.Address == this.email;
            }
            catch
            {
                return false;
            }
        }

        public bool validPassword()
        {
            return (Regex.IsMatch(password, passwordPattern));
        }

        public bool matchingPassword()
        {
            return (password == confirmPassword);
        }

    }
}
