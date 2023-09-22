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

namespace asdfasgdasdg
{
    public partial class Form1 : Form
    {
        public const string FILE_NAME = "pacienti.dat";
        public List<Patient> PatientList = new List<Patient>();
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(FILE_NAME))
            {
                using (fs = new FileStream(FILE_NAME, FileMode.CreateNew))
                {
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
            LoadPatientList();
        }

        private void LoadPatientList()
        {
            if (File.Exists(FILE_NAME))
            {
                using (fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    PatientList = (List<Patient>)bf.Deserialize(fs);
                }
            }
        }



        private void добавянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatients add = new AddPatients(PatientList);
            Visible = false;
            add.ShowDialog();
            Visible = true;
            LoadPatientList();
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisuk spisuk = new Spisuk(PatientList);
            Visible = false;
            spisuk.ShowDialog();
            Visible = true;
            LoadPatientList();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да затворитеприложението ? ", "Изход", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(PatientList);
            statisticsForm.ShowDialog();
        }
    }
}
