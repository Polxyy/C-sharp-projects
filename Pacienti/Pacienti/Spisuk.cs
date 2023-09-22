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
    public partial class Spisuk : Form
    {
        public List<Patient> PatientList;
        public const string FILE_NAME = "pacienti.dat";
        public Spisuk(List<Patient> patientList)
        {
            InitializeComponent();
            PatientList = patientList;

        }
       
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да изтриете тези данни?", "Изтриване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataGridViewRow selectedRow = patientDataGridView.SelectedRows[0];
                string name = selectedRow.Cells["Name"].Value.ToString();

                // Remove the patient from the list
                PatientList.RemoveAll(p => p.Name == name);

                // Save the updated patient list to file
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, PatientList);
                }

                // Refresh the DataGridView
                patientBindingSource.ResetBindings(false);
                MessageBox.Show("Данните бяха изтрити успешно!");
            }
        }
    }
}
