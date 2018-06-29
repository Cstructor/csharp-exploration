using System;
using System.IO;
using System.Windows.Forms;

namespace FileProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxFileChooserButton_Click(object sender, EventArgs e)
        {
            // Display the dialog and look for the OK button
            if (uxFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Save filename into the label field
                uxFilenameLabel.Text = uxFileDialog.FileName;
            }
        }

        private void uxProcessButton_Click(object sender, EventArgs e)
        {
            // Empty the listbox otherwise it will just keep adding items
            uxResultsListBox.Items.Clear();

            // Open the file from the file dialog
            // We use "using" so the file is automatically closed, otherwise
            // you will not be able to open it again.
            using (var stream = new StreamReader(uxFileDialog.OpenFile()))
            {
                string line;
                bool firstLine = true;
                int min = 0;

                // Read through the lines in the file
                // It will return null when the end of file is reached
                while ((line = stream.ReadLine()) != null)
                {
                    /// Since the file is comma separated, we split
                    /// the string based on commas
                    string[] parts = line.Split(',');

                    // Convert the second array element 
                    int current = int.Parse(parts[1]);

                    if (firstLine)
                    {
                        min = current;

                        firstLine = false;
                    }

                    if (current < min)
                    {
                        min = current;
                    }
                }

                /// Add the minimum value into the listbox
                uxResultsListBox.Items.Add(string.Format("Min: {0}", min));
            }
        }
    }
}
