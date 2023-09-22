using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kont.zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int a;
            int.TryParse(tb1.Text, out a);
            for(int i = 0; i<100; i++)
            {
                if(i%a == 0)
                {
                    lb1.Items.Add(i);
                }
            }
        }
    }
}
