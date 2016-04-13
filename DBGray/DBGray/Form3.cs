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
    public partial class Form3 : Form
    {
        string database;
        public Form3(string database)
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
                listBox1.Items.Add(row[i]);
            }
        }
    }
}
