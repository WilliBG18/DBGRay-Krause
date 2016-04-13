using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBGray
{
    class TableCRUD
    {
        public void InsertTuple(string Tblname)
        {
            ConnString conn = new ConnString();
            MySqlConnection connect = new MySqlConnection(conn.getConnString());
            connect.Open();
            MySqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO" + Tblname + "VALUES(?,?)";
            cmd.Parameters.Add("?", MySqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("?", MySqlDbType.VarChar).Value = "";
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public void SelectTuple()
        {

        }
        public void UpdateTuple()
        {

        }
        public void DeleteTuple()
        {

        }
    }
}
