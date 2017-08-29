using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokek
{
    class DBUser
    {
        public DBUser(User user)
        {
            DBConnector connector = new DBConnector();
            connector.AddUser(user);
        }

    }
}
