using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace Pacienti
{
    public partial class Main : Form
    {

        public const string FILE_NAME = "pacienti.dat";
        public List<Patient> PatientList = new List<Patient>();
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;

        public Main()
        {
            InitializeComponent();
            LoadPatientData(); // Add this line to load patient data
        }

        private void LoadPatientData()
        {
            if (File.Exists(FILE_NAME))
            {
                fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                PatientList = (List<Patient>)bf.Deserialize(fs);
                fs.Close();
            }
        }

        private void добавянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatients add = new AddPatients(PatientList);
            add.ShowDialog(); // Use ShowDialog instead of Show
            LoadPatientData(); // Refresh patient data after AddPatients form is closed
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisuk spisuk = new Spisuk(PatientList);
            spisuk.ShowDialog(); // Use ShowDialog instead of Show
            LoadPatientData(); // Refresh patient data after Spisuk form is closed
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да затворитеприложението ? ", "Изход", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
