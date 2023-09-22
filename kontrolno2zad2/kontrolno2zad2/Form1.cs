using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontrolno2zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            dg1.ColumnCount = 5;
            dg1.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for(int j=0; j < 5; j++)
                {
                    dg1.Rows[i].Cells[j].Value = rand.Next(2);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dg1.Rows) 
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null && cell.Value.ToString() == "0")
                    {
                        cell.Value = 1;
                    }
                    else if(cell.Value != null && cell.Value.ToString() == "1") {
                    cell.Value = 0;}
                }
            }
        }
    }
}
