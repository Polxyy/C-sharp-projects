using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2
{
    public partial class Form1 : Form
    {
        string FN = "birds.dat";
        FileStream fs;
       // int cnt = int.MaxValue;
        public Form1()
        {
            InitializeComponent();
            fs = new FileStream(FN, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);
            while(fs.Position < fs.Length)
            {
                string vid = br.ReadString();
                string mestoobitanie = br.ReadString();
                int broy = br.ReadInt32();
                dataGridView1.Rows.Add(vid, mestoobitanie, broy);
            }
            fs.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1[0, i].Value.ToString() == textBox1.Text)
                {
                    label1.Text += dataGridView1[1, i].Value.ToString()+" ";
                }
            }

            Dictionary<string, int> brPtici = new Dictionary<string, int>();


            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {

                string vid = dataGridView1[0, i].Value.ToString();
                int br = int.Parse(dataGridView1[2, i].Value.ToString());


                if (brPtici.ContainsKey(vid))
                {
                    brPtici[vid] += br;
                }

                else
                {
                    brPtici.Add(vid, br);
                }
            }


            KeyValuePair<string, int> min = brPtici.First();
            for (int i = 1; i < brPtici.Count; i++)
            {
                KeyValuePair<string, int> BroyPtici = brPtici.ElementAt(i);
                if (BroyPtici.Value < min.Value)
                {
                    min = BroyPtici;
                }
            }


            label2.Text = $"Най-застрашена птица е {min.Key} с {min.Value} бройки.";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            fs = new FileStream(FN, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for(int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                bw.Write(dataGridView1[0, i].Value.ToString());
                bw.Write(dataGridView1[1, i].Value.ToString());
                bw.Write(int.Parse(dataGridView1[2, i].Value.ToString()));
            }
            fs.Close();
        }
    }
}
