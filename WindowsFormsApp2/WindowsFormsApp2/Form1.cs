using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            LB1.Items.Clear(); 

            if (int.TryParse(TB1.Text, out int num))
            {
                if (num >= 1 && num <= 7000)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            LB1.Items.Add(i.ToString());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Въведете число между 1-7000.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Въведете валидно число.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
