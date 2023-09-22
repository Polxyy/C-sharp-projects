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
    public partial class PatientForm : Form
    {
        public static List<Patient> patients = new List<Patient>();
        public static string filePath = "patients.txt";
        private StatisticsForm statisticsForm;
        private BindingSource _patientBindingSource;
        public PatientForm()
        {
            InitializeComponent();
            this.statisticsForm = statisticsForm;
            _patientBindingSource = new BindingSource();
            _patientBindingSource.DataSource = new List<Patient>();

            dataGridView.DataSource = _patientBindingSource;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(genderTextBox.Text)
                || string.IsNullOrEmpty(ageTextBox.Text) || string.IsNullOrEmpty(dateTextBox.Text))
            {
                errorLabel.Text = "Please fill in all fields";
                return;
            }

            // Parse user input and create new patient object
            if (!int.TryParse(ageTextBox.Text, out int age))
            {
                errorLabel.Text = "Invalid age";
                return;
            }
            if (!DateTime.TryParse(dateOfExaminationLabel.Text, out DateTime date))
            {
                errorLabel.Text = "Invalid date format";
                return;
            }
            Patient patient = new Patient
            {
                Name = nameTextBox.Text,
                Gender = genderTextBox.Text,
                Age = age,
                DateOfExamination = date
            };

            // Add patient to DataGridView and patients list
            dataGridView.Rows.Add(patient.Name, patient.Gender, patient.Age, patient.DateOfExamination.ToString("yyyy-MM-dd"));
            patients.Add(patient);

            // Clear input fields and error label
            nameTextBox.Text = "";
            genderTextBox.Text = "";
            ageTextBox.Text = "";
            dateTextBox.Text = "";
            errorLabel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Parse user input
            if (!DateTime.TryParse(dateTextBox.Text, out DateTime date))
            {
                errorLabel.Text = "Invalid date format";
                return;
            }

            // Filter patients by date
            List<Patient> filteredPatients = patients.Where(p => p.DateOfExamination.Date == date.Date).ToList();

            // Display filtered patients in ListBox in StatisticsForm
            StatisticsForm statsForm = new StatisticsForm();
            statsForm.UpdatePatientList(filteredPatients);

            // Update statistics labels
            int numMale = filteredPatients.Where(p => p.Gender.ToLower() == "male").Count();
            int numFemale = filteredPatients.Where(p => p.Gender.ToLower() == "female").Count();

            // Update labels in PatientForm
            statsForm.maleLabel.Text = $"Male: {numMale}";
            statsForm.femaleLabel.Text = $"Female: {numFemale}";
            statsForm.totalLabel.Text = $"Total: {filteredPatients.Count}";

            // Show StatisticsForm
            statsForm.Show();
        }
    }
}
