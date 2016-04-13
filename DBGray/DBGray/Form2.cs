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
            string[] row = displayDB.DisplayDBs();
            for (int i = 0; i < row.Length; i++)
            {
                ListDBs.Items.Add(row[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB connect = new ConnectDB();
            connect.connectToDB(ListDBs.SelectedItem.ToString());
        }
    }
}
