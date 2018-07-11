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

            rpnEngine = new RPNEngine();
        }

        private void uxButton_Click(object sender, EventArgs e)
        {
            if (firstNumber)
            {
                uxTotalLabel.Text = string.Empty;

                firstNumber = false;
            }

            var button = (Button)sender;

            uxTotalLabel.Text += button.Text;
        }

        private void uxOperationButton_Click(object sender, EventArgs e)
        {
            rpnEngine.Process(uxTotalLabel.Text);

            var button = (Button)sender;

            if (button.Text != "ENTER")
            {
                rpnEngine.Process(button.Text);

                uxTotalLabel.Text = rpnEngine.Result.ToString();
            }

            firstNumber = true;
        }

        private void uxClearButton_Click(object sender, EventArgs e)
        {
            uxTotalLabel.Text = string.Empty;
        }
    }
}
