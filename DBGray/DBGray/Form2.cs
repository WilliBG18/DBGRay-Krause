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
    public partial class Form2 : Form
    {
        Display displayDB;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayDB = new Display();
            string[] row = new string[1];
            Array.Copy(displayDB.DisplayDBs(), row, displayDB.DisplayDBs().Length);
            for (int i = 0; i < 1; i++)
            {
                ListDBs.Items.Add(row[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display displayTbl = new Display();
            if(ListDBs.SelectedValue.ToString() == "information_schema, dbGray, ")
            {
                displayTbl.DisplayTables();
            }
        }
    }
}
