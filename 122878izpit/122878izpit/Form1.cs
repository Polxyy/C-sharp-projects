using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _122878izpit
{
    
    public partial class Form1 : Form
    {
        public List<Toys> ToyList = new List<Toys>();
        public const string FILE_NAME = "Toys.dat";
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;
        public Form1()
        {
            InitializeComponent();
            var info = new FileInfo(FILE_NAME);
            if (File.Exists(FILE_NAME) && info.Length != 0)
            {
                fs = new FileStream(FILE_NAME, FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite);
                ToyList = (List<Toys>)bf.Deserialize(fs);
                
            }
            fs.Close();
        }

        private void addToyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddToy add = new AddToy(ToyList);
            Visible = false;
            add.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics(ToyList);
            Visible = false;
            s.Show();
        }
    }
}
