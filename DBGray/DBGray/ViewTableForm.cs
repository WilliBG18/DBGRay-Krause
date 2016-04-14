using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBGray
{
    public partial class ViewTableForm : Form
    {
        string database;
        string table;
        public ViewTableForm(string table)
        {
            InitializeComponent();
            this.table = table;
            //DisplayTable();
        }
        //private void DisplayTable()
        //{
        //    database = "dbGray;";
        //    Tables tables = new Tables();
        //    tables.DisplayTable(database, table);
        //    string[] row = tables.DisplayTable(database, table);
        //    for (int i = 0; i < row.Length; i++)
        //    {
        //        TuplesLB.Items.Add(row[i]);
        //    }
        //}
    }
}
