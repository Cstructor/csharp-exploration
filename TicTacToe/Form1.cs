using System;
using System.Windows.Forms;

namespace TicTacToeApp
{
    public partial class Form1 : Form
    {
        // Keep track of whose turn it is (X, O)
        private string currentTurn;

        public Form1()
        {
            InitializeComponent();

            ResetBoard();
        }

        private void ResetBoard()
        {
            // Set the first turn to X
            currentTurn = "X";

            // Update the status bar
            WhoseTurn();

            // Reset the buttons to empty text
            uxButton1.ResetText();
            uxButton2.ResetText();
            uxButton3.ResetText();
            uxButton4.ResetText();
            uxButton5.ResetText();
            uxButton6.ResetText();
            uxButton7.ResetText();
            uxButton8.ResetText();
            uxButton9.ResetText();

            // Enable each button to be clickable
            uxButton1.Enabled = true;
            uxButton2.Enabled = true;
            uxButton3.Enabled = true;
            uxButton4.Enabled = true;
            uxButton5.Enabled = true;
            uxButton6.Enabled = true;
            uxButton7.Enabled = true;
            uxButton8.Enabled = true;
            uxButton9.Enabled = true;
        }

        // Disable all buttons to not be clickable
        private void DisableBoard()
        {
            uxButton1.Enabled = false;
            uxButton2.Enabled = false;
            uxButton3.Enabled = false;
            uxButton4.Enabled = false;
            uxButton5.Enabled = false;
            uxButton6.Enabled = false;
            uxButton7.Enabled = false;
            uxButton8.Enabled = false;
            uxButton9.Enabled = false;
        }

        // Update the status bar
        private void WhoseTurn()
        {
            uxToolStripStatusLabel.Text = string.Format("{0}'s turn", currentTurn);
        }

        // Check if there is a winner
        private bool IsThereWinner()
        {
            // Check if first horizontal row is three in a row
            if (uxButton1.Text != ""
                && uxButton1.Text == uxButton2.Text
                && uxButton2.Text == uxButton3.Text)
            {
                uxToolStripStatusLabel.Text = string.Format("{0} is a winner", uxButton1.Text);
                return true;
            }
            return false;
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxButton_Click(object sender, EventArgs e)
        {
            // Get the current "button" that was clicked.
            // The actual "button" is a Label control.
            var button = (Label)sender;

            // Check if the button is empty
            if (string.IsNullOrEmpty(button.Text))
            {
                button.Text = currentTurn;

                if (IsThereWinner())
                {
                    DisableBoard();
                }
                else
                {
                    if (currentTurn == "X")
                    {
                        currentTurn = "O";
                    }
                    else
                    {
                        currentTurn = "X";
                    }

                    WhoseTurn();
                }
            }
        }
    }
}
