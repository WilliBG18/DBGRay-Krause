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
    class DatabaseCRUD
    {
        ConnString conn = new ConnString();
        public void CreateTable(string Tblname, string param)
        {
            MySqlConnection connect = new MySqlConnection(conn.getConnString());
            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "CREATE TABLE" + Tblname + @"(
            param
            )";
            //string createTbl;
            connect.Close();
        }
        public void DisplayTable()
        {
            
            MySqlConnection connect = new MySqlConnection(conn.getConnString());
            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "Select * FROM database_name.table1";
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    //textBox1.Text = myReader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        public void UpdateTable()
        {

        }
        public void DropTable(string Tblname)
        {
            MySqlConnection connect = new MySqlConnection(conn.getConnString());
            connect.Open();
            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "DROP TABLE" + Tblname;
            connect.Close();
        }
    }
}
