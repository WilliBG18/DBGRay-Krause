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

            return rows;
        }

        public string[] DisplayTables(string database)
        {
            ConnString conn = new ConnString();
            conn.SetDatabase(database);
            string query = "show tables from " + database;
            MySqlConnection connection = new MySqlConnection(conn.getConnString());
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            List<string> rowList = new List<string>();

            while (reader.Read())
            {                
                rowList.Add(reader[0].ToString());
            }

            string[] rows = new string[rowList.Count];
            for (int i = 0; i < rows.Length; i++)
                rows[i] = rowList.ElementAt(i);

            reader.Close();
            connection.Close();

            return rows;
        }
    }
}
