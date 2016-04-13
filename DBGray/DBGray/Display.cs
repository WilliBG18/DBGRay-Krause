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
            
            MySqlConnection connection = new MySqlConnection(conn.getConnString());
            String query = "SHOW DATABASES;";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            string[] rows = new string[reader.FieldCount];

            int i = 0;
            while (reader.Read())
            {
                if(i != 0)
                {
                    rows[i - 1] = reader[0].ToString();
                }
                i++;
            }
            reader.Close();
            
            connection.Close();
            System.Console.WriteLine("WORKING?");
            for (int j = 0; j < rows.Length; j++)
            {
                System.Console.WriteLine("HERE: " + rows[j]);
            }
                return rows;
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
