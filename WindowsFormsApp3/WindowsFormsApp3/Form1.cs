using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public partial class Form1 : Form
        {
            private const int ROWS = 3;
            private const int COLS = 3;
            private const string USER_SYMBOL = "X";
            private const string PROGRAM_SYMBOL = "O";

            private string[,] board = new string[ROWS, COLS];
            private bool userTurn = true;

            public Form1()
            {
                InitializeComponent();
                InitializeBoard();
                UpdateDataGridView();
            }

            private void BT1_Click(object sender, EventArgs e)
            {
                // Start a new game
                InitializeBoard();
                UpdateDataGridView();
                LR.Text = "";
            }

            private void Dshax_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int row = e.RowIndex;
                int col = e.ColumnIndex;

                if (board[row, col] == null)
                {
                    // If the cell is empty, update it with the user's symbol
                    board[row, col] = USER_SYMBOL;
                    UpdateDataGridView();

                    if (CheckForWinner(USER_SYMBOL))
                    {
                        // If the user wins, display a message and end the game
                        LR.Text = "You won!";
                        return;
                    }

                    if (IsBoardFull())
                    {
                        // If the board is full, display a message and end the game
                        LR.Text = "It's a tie!";
                        return;
                    }

                    // Otherwise, it's the program's turn
                    ProgramMove();
                    UpdateDataGridView();

                    if (CheckForWinner(PROGRAM_SYMBOL))
                    {
                        // If the program wins, display a message and end the game
                        LR.Text = "The program won!";
                        return;
                    }

                    if (IsBoardFull())
                    {
                        // If the board is full, display a message and end the game
                        LR.Text = "It's a tie!";
                        return;
                    }
                }
            }

            private void InitializeBoard()
            {
                // Initialize the board with null values
                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        board[i, j] = null;
                    }
                }

                userTurn = true;
            }

            private void UpdateDataGridView()
            {
                // Update the DataGridView with the current state of the board
                Dshax.Rows.Clear();

                for (int i = 0; i < ROWS; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dshax);

                    for (int j = 0; j < COLS; j++)
                    {
                        row.Cells[j].Value = board[i, j];
                    }

                    Dshax.Rows.Add(row);
                }
            }

            private bool CheckForWinner(string symbol)
            {
                // Check if there is a winner in any row, column, or diagonal
                for (int i = 0; i < ROWS; i++)
                {
                    if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                    {
                        return true;
                    }
                }

                for (int j = 0; j < COLS; j++)
                {
                    if (board[0, j] == symbol && board[1, j] == symbol && board[2, j] == symbol)
                    {
                        return true;
                    }
                }
                if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
                {
                    return true;
                }
                if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
                {
                    return true;
                }

                return false;
            }

            private bool IsBoardFull()
            {
                // Check if the board is full
                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        if (board[i, j] == null)
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            private void ProgramMove()
            {
                // The program chooses a random empty cell and updates it with its symbol
                Random random = new Random();

                while (true)
                {
                    int row = random.Next(ROWS);
                    int col = random.Next(COLS);

                    if (board[row, col] == null)
                    {
                        board[row, col] = PROGRAM_SYMBOL;
                        break;
                    }
                }
            }
        }
    }
}
