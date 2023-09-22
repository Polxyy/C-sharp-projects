using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asdfasgdasdg
{
    public partial class StatisticsForm : Form
    {
        private List<Patient> patientList;
        public StatisticsForm(List<Patient> patients)
        {
            InitializeComponent();
            patientList = patients;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            int.TryParse(textBox1.Text, out age);
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Filter patients by age
            var patientsByAge = patientList.Where(p => p.Age == age).ToList();
            int countByAge = patientsByAge.Count;

            // Filter patients by selected date
            var patientsByDate = patientList.Where(p => p.ExamDate.Date == selectedDate).ToList();

            // Display count by age
            label4.Text = countByAge.ToString();

            // Display count by gender
            int countMen = patientsByAge.Count(p => p.Gender.ToLower() == "muj");
            int countWomen = patientsByAge.Count(p => p.Gender.ToLower() == "jena");
            label1.Text = countMen.ToString();
            label2.Text = countWomen.ToString();

            // Display total count
            label3.Text = patientsByAge.Count.ToString();

            // Display patients examined on selected date
            listBox1.Items.Clear();
            foreach (var patient in patientsByDate)
            {
                listBox1.Items.Add(patient.Name);
            }
        }
    }
}
