using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _122878izpit
{
    public partial class Statistics : Form
    {
        public List<Toys> ToyList;
        public Statistics(List<Toys> Toys)
        {
            InitializeComponent();
            ToyList = Toys;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string man = comboBox1.Text.ToString();
            string type = comboBox2.Text.ToString();
            var toysByMan = ToyList.Where(p => p.name_Manufacturer == man).ToList();
            int countByMan = toysByMan.Count;

            var toysToShow = ToyList.Where(p => p.name_Manufacturer == man && p.toy_Type == type).ToList();

            //var toysByMan = ToyList.Where(p => p.name_Manufacturer == man).ToList();
            //var toysByType = ToyList.Where(p => p.toy_Type == type).ToList();

            listBox1.Items.Clear();
            foreach (var toy in toysToShow)
            {
                listBox1.Items.Add(toy);
            }
            textBox1.Text = toysByMan.Count.ToString();
        }
    }
}
