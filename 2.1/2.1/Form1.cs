using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class Form1 : Form
    {
        int s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = DGrid.RowCount;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j < i)
                    {
                        DGrid[j, i].Value = -Math.Abs((int)DGrid[j, i].Value);
                    }
                    else
                    {
                        DGrid[j, i].Value = Math.Abs((int)DGrid[j, i].Value);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (!int.TryParse(TB1.Text, out s))
            {
                MessageBox.Show("Not a number!");
            }
            else
            {
                DGrid.ColumnCount = s;
                DGrid.RowCount = s;
                Random rnd = new Random();
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        DGrid[j, i].Value = rnd.Next(-10, 10);
                    }
                }
            }
        }
    }
}
