using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krsova
{
    public partial class StatisticsForm : Form
    {
        public static List<Patient> patients = new List<Patient>();
        public static string filePath = "patients.txt";
        private StatisticsForm statisticsForm;
        List<Patient> filteredPatients;

        public StatisticsForm()
        {
            InitializeComponent();
            filteredPatients = patients;

            // update patientListBox with filtered patients
            foreach (Patient patient in filteredPatients)
            {
                patientListBox.Items.Add(patient.Name);
            }
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }
        public void UpdatePatientList(List<Patient> patients)
        {
            patientListBox.Items.Clear();
            foreach (Patient patient in patients)
            {
                patientListBox.Items.Add(patient.Name);
            }
        }

    }
}
