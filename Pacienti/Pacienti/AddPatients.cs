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
    public partial class AddPatients : Form
    {
        public const string FILE_NAME = "pacienti.dat";
        public List<Patient> PatientList;

        public AddPatients(List<Patient> patientList)
        {
            InitializeComponent();
            PatientList = patientList;
        }
        private void AddPatients_Load(object sender, EventArgs e)
        {

        }
        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да съхранитеданните ? ", "Съхраняване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int a = int.Parse(ageTextBox.Text);
                PatientList.Add(new Patient()
                {
                    Name = nameTextBox.Text.ToString(),
                    Gender = genderTextBox.Text.ToString(),
                    Age = a,
                    ExamDate = examDateDateTimePicker.Value
                });

                // Save the patient list to file
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, PatientList);
                }

                MessageBox.Show("Данните Ви бяха съхранени успешно!");
            }
            Close();
        }
    }
}

