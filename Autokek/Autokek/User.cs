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

        public User (String username, String email, String password)
        {

        }

        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool exists;
        private int[] usernameBounds = new int[] { 3, 16 };

        private bool validName ()
        {
            return (username.Length >= usernameBounds[0] && username.Length <= usernameBounds[1]);
        }

        private bool doesExist()
        {
            DBConnector connection = new DBConnector();
            return connection.UserExists(this);
        }

        private bool validEmail()
        {
            return true;
        }

        private bool validPassword()
        {
            return (password.Length >= 8);
        }

    }
}
