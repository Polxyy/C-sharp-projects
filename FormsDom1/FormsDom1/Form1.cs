using System;
using System.Windows.Forms;

namespace FormsDom1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            matrixGridView.AllowUserToAddRows = false;
            matrixGridView.RowHeadersVisible = false;
            matrixGridView.ColumnHeadersVisible = false;
            matrixGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get the number of rows and columns from the user input
            int numRows = int.Parse(Console.ReadLine());
            int numCols = int.Parse(Console.ReadLine());

            // Generate a matrix with the specified number of rows and columns
            int[,] matrix = new int[numRows, numCols];

                // Fill the matrix with random numbers between -99 and 99
                Random rand = new Random();
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        matrix[i, j] = rand.Next(-99, 100);
                    }
                }

                // Display the matrix in the DataGridView control
                matrixGridView.Rows.Clear();
                for (int i = 0; i < numRows; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    for (int j = 0; j < numCols; j++)
                    {
                        DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                        cell.Value = matrix[i, j];
                        row.Cells.Add(cell);
                    }
                    matrixGridView.Rows.Add(row);
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixGridView.Rows.Count; i++)
            {
                for (int j = 0; j < matrixGridView.Columns.Count; j++)
                {
                    DataGridViewCell cell = matrixGridView.Rows[i].Cells[j];

                    // Check if the cell value is negative
                    if (cell.Value is int && (int)cell.Value < 0)
                    {
                        int value = (int)cell.Value;

                        // Check if the absolute value of the cell value is one digit
                        if (Math.Abs(value) < 10)
                        {
                            cell.Value = value * value;
                        }
                        else
                        {
                            cell.Value = Math.Abs(value);
                        }
                    }
                }
            }
        }
    }
}