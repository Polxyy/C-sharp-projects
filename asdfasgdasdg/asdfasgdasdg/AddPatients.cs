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
    public partial class AddPatients : Form1
    {


        public AddPatients(List<Patient> patientList)
        {
            InitializeComponent();
            PatientList = patientList;
            patientBindingSource.DataSource = PatientList;
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да съхраните данните?", "Съхраняване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int age;
                if (!int.TryParse(ageTextBox.Text, out age))
                {
                    MessageBox.Show("Невалидна възраст! Моля, въведете цяло число.");
                    return;
                }

                Patient newPatient = new Patient()
                {
                    Name = nameTextBox.Text,
                    Gender = genderTextBox.Text,
                    Age = age,
                    ExamDate = examDateDateTimePicker.Value
                };

                PatientList.Add(newPatient);

                using (fs = new FileStream(FILE_NAME, FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, PatientList);
                }

                MessageBox.Show("Данните бяха съхранени успешно!");
                Close();
            }
        }
        }
    }

