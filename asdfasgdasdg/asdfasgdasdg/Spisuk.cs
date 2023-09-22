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
    public partial class Spisuk : Form1
    {

        public Spisuk(List<Patient> patientList)
        {
            InitializeComponent();
            PatientList = patientList;
            LoadPatientList();
            bindingNavigatorDeleteItem.Click += bindingNavigatorDeleteItem_Click;
        }
        private void LoadPatientList()
        {
            if(File.Exists(FILE_NAME))
            {
                using (fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    PatientList = (List<Patient>)bf.Deserialize(fs);
                }
            }
            patientDataGridView.DataSource = PatientList;
        }
        private void Spisuk_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да изтриете тези данни?", "Изтриване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow selectedRow = patientDataGridView.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();

                PatientList.RemoveAll(p => p.Name == name);

                using (fs = new FileStream(FILE_NAME, FileMode.Create))
                {
                    bf.Serialize(fs, PatientList);
                }

                patientDataGridView.DataSource = null;
                patientDataGridView.DataSource = PatientList;

                MessageBox.Show("Данните бяха изтрити успешно!");
            }
        }

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
