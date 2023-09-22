using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontrolno2zad3
{
    public partial class Form1 : Form
    {
        private const int ROWS = 5;
        private const int COLUMNS = 5;
        private const int MAX_ONES = 5;

        public Form1()
        {
            InitializeComponent();

            dg1.ColumnCount = COLUMNS;
            dg1.RowCount = ROWS;

            // Fill cells with random numbers between 0 and 1
            Random random = new Random();
            int onesCount = 0;
            foreach (DataGridViewRow row in dg1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int value = random.Next(2);
                    if (value == 1 && onesCount < MAX_ONES)
                    {
                        onesCount++;
                    }
                    else
                    {
                        value = 0;
                    }
                    cell.Value = value.ToString();
                    cell.Style.ForeColor = Color.White;
                    cell.Style.BackColor = Color.Black;
                }
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            // Show cell values
            foreach (DataGridViewRow row in dg1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.ForeColor = dg1.DefaultCellStyle.ForeColor;
                    cell.Style.BackColor = dg1.DefaultCellStyle.BackColor;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
