using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBGray
{
    class ConnectDB
    {
        Form2 form2 = new Form2();
        MySqlConnection conn;
            bool connection = false;

        public void connectToDB()
        {
            ConnString connect = new ConnString();
            conn = new MySqlConnection();
            if (connection == false)
            {
                conn.ConnectionString = connect.getConnString();
                conn.Open();
                connection = true;
            }
            if (connection == true)
            {
                MessageBox.Show("Connection Successful");
                form2.Show();
            }
        }
        public void CloseConn()
        {
            if (connection == true)
            {
                conn.Close();
                connection = false;
            }
        }
        public void OpenConn()
        {
            if (connection == true)
            {
                conn.Open();
            }
        }
    }
}
