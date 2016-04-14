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
    public partial class DBTablesForm : Form
    {
        string database;
        public DBTablesForm(string database)
        {
            InitializeComponent();
            this.database = database;
            DisplayTables();
        }
        private void DisplayTables()
        {
            Display dispTables = new Display();
            dispTables.DisplayTables(database);
            string[] row = dispTables.DisplayTables(database);
            for (int i = 0; i < row.Length; i++)
            {
                TablesLB.Items.Add(row[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = TablesLB.SelectedItem.ToString();
            Tables tables = new Tables();
            tables.SelectTable(database, table);
        }
    }
}
