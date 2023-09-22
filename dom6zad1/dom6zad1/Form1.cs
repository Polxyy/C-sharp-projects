namespace dom6zad1
{
    public partial class Form1 : Form
    {
        public matrixGridView()
        {
            InitializeComponent();

            // Set up the DataGridView control
            matrixGridView.AllowUserToAddRows = false;
            matrixGridView.RowHeadersVisible = false;
            matrixGridView.ColumnHeadersVisible = false;
            matrixGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numRows = (int)numRowsUpDown.Value;
            int numCols = (int)numColsUpDown.Value;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}