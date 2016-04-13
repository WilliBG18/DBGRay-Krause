using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGray
{
    public class ConnString
    {

        static string myConnectionString;

        public void staticConn(string server, string userID, string password)
        {
            myConnectionString = "server=" + server + ";" + "uid=" + userID + ";" + "pwd=" + password + ";";
        }
        public string getConnString()
        {
            return myConnectionString;
        }

    }
}
