using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TOA_s_Project.Database
{
    class Connection
    {
        public MySqlConnection conn;
        public Connection()
        {
            string host = "localhost";
            string db = "toa";
            string username = "root";
            string password = "sholehhudin1995";
            string constring = "datasource =" + host + "; database = " + db + "; username = " + username + "; password=" + password + "; SslMode=None;";

            conn = new MySqlConnection(constring);

        }
    }
}
