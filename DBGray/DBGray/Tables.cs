using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBGray
{
    class Tables
    {
        //public string[] DisplayTable(string database, string table)
        //{
        //    ConnString conn = new ConnString();
        //    conn.SetDatabase(database);
        //    string query = "SELECT * From " + table;
        //    MySqlConnection connection = new MySqlConnection(conn.getConnString());
        //    MySqlCommand command = new MySqlCommand(query, connection);
        //    connection.Open();
        //    MySqlDataReader reader = command.ExecuteReader();

        //    List<string> rowList = new List<string>();

        //    while (reader.Read())
        //    {
        //        rowList.Add(reader[0].ToString());
        //    }

        //    string[] rows = new string[rowList.Count];
        //    for (int i = 0; i < rows.Length; i++)
        //        rows[i] = rowList.ElementAt(i);

        //    reader.Close();
        //    connection.Close();

        //    return rows;
        //}
        public void SelectTable(string database, string table)
        {
            ConnString conn = new ConnString();
            conn.SetDatabase(database);
            MySqlConnection connection = new MySqlConnection(conn.getConnString());
            connection.Open();
            bool connect = true;
            if (connect == true)
            {
                ViewTableForm veiwTable = new ViewTableForm(table);
                veiwTable.Show();
            }
        }
    }
}
