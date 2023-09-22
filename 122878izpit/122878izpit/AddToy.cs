using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _122878izpit
{
    public partial class AddToy : Form
    {
        public List<Toys> ToyList = new List<Toys>();
        public const string FILE_NAME = "Toys.dat";
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;
        public AddToy(List<Toys> ToyList)
        {
            InitializeComponent();
            toysBindingSource.DataSource = ToyList;
        }

        private void AddToy_Load(object sender, EventArgs e)
        {

        }

        private void toysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

           
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да съхранитеданните ? ", "Съхраняване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                    fs = new FileStream(FILE_NAME, FileMode.Open);
                    int id = 8888;
                    int.TryParse(textbox_id.Text, out id);
                    ToyList.Add(new Toys()
                    {
                        Id_Item = id,
                        toy_Name = textBox2.Text.ToString(),
                        toy_Type = comboBox2.Text.ToString(),
                        name_Manufacturer = comboBox1.Text.ToString(),
                    });
                    bf.Serialize(fs, ToyList);
                    fs.Close();
                    MessageBox.Show("Данните Ви бяха съхранениуспешно!");
                    //toysDataGridView.DataSource= ToyList;
                }
            }
        }
    }

