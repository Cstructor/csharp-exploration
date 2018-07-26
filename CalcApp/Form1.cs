using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        private RPNEngine rpnEngine;
        private bool firstNumber = true;

        public Form1()
        {
            InitializeComponent();

            // Create a calculator engine
            rpnEngine = new RPNEngine();
        }

        private void uxButton_Click(object sender, EventArgs e)
        {
            // If it's the first number then clear the total label field
            if (firstNumber)
            {
                uxTotalLabel.Text = string.Empty;

                firstNumber = false;
            }

            var button = (Button)sender;

            // Add the current button's number that was pressed
            // to the total label field.
            uxTotalLabel.Text += button.Text;
        }

        // This method is called when they press - or +
        private void uxOperationButton_Click(object sender, EventArgs e)
        {
            // Process the current number in the total label field
            rpnEngine.Process(uxTotalLabel.Text);

            var button = (Button)sender;

            // If the button is not ENTER such as - or +,
            // then process the operation
            if (button.Text != "ENTER")
            {
                rpnEngine.Process(button.Text);

                // Get the result of the operation and
                // put it in the total label field
                uxTotalLabel.Text = rpnEngine.Result.ToString();
            }

            // After an operation or ENTER, assume
            // they are typing in a new number
            firstNumber = true;
        }

        private void uxClearButton_Click(object sender, EventArgs e)
        {
            uxTotalLabel.Text = string.Empty;
        }
    }
}
