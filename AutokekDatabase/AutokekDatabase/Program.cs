using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutokekDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnector connector = new DBConnector();
            connector.UpdateDB();
        }
    }
}
