using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBGray
{
    class Display
    {
        public Display()
        {

        }
        ConnString conn = new ConnString();
        public string[] DisplayDBs()
        {
            string[] rows = new string[1];
            MySqlConnection connection = new MySqlConnection(conn.getConnString());
            String query = "SHOW DATABASES;";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            int i;
            while (reader.Read())
            {
               for (i = 0; i < reader.FieldCount; i++)
                   rows[i] += reader.GetValue(i).ToString() + ", ";
                
            }
            reader.Close();
            string[] catrows = rows;

            
            connection.Close();
            return catrows;
        }

        public void DisplayTables()
        {
            ConnString conn = new ConnString();
            List<String> Tablenames = new List<String>();
            string query = "show tables from dbGray";
            MySqlConnection connection = new MySqlConnection(conn.getConnString() + "database= dbGray");
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            Form3 form3 = new Form3();
            form3.Show();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Tablenames.Add(reader.GetString(0));
                }
            }
            connection.Close();
        }
    }
}
