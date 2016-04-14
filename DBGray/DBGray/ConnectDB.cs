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
        
        
        MySqlConnection conn;
            bool connection = false;

        public void connectToDBMS()
        {
            DatabasesForm form2 = new DatabasesForm();
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
        public void connectToDB(string database)
        {
            DBTablesForm form3 = new DBTablesForm(database);
            ConnString connect = new ConnString();
            connect.SetDatabase(database);
            conn = new MySqlConnection();
            if (connection == false)
            {
                conn.ConnectionString = connect.getConnString();
                conn.Open();
                connection = true;
            }
            if (connection == true)
            {
                MessageBox.Show("Connection to Database Successful");
                form3.Show();
            }
        }
    }
}
