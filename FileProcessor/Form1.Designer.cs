namespace FileProcessor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxFileChooserButton = new System.Windows.Forms.Button();
            this.uxFilenameLabel = new System.Windows.Forms.Label();
            this.uxProcessButton = new System.Windows.Forms.Button();
            this.uxResultsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxFileDialog
            // 
            this.uxFileDialog.Filter = "CSV Files|*.csv";
            this.uxFileDialog.InitialDirectory = ".\\";
            // 
            // uxFileChooserButton
            // 
            this.uxFileChooserButton.Location = new System.Drawing.Point(12, 12);
            this.uxFileChooserButton.Name = "uxFileChooserButton";
            this.uxFileChooserButton.Size = new System.Drawing.Size(81, 23);
            this.uxFileChooserButton.TabIndex = 0;
            this.uxFileChooserButton.Text = "Choose File...";
            this.uxFileChooserButton.UseVisualStyleBackColor = true;
            this.uxFileChooserButton.Click += new System.EventHandler(this.uxFileChooserButton_Click);
            // 
            // uxFilenameLabel
            // 
            this.uxFilenameLabel.AutoSize = true;
            this.uxFilenameLabel.Location = new System.Drawing.Point(100, 21);
            this.uxFilenameLabel.Name = "uxFilenameLabel";
            this.uxFilenameLabel.Size = new System.Drawing.Size(0, 13);
            this.uxFilenameLabel.TabIndex = 1;
            // 
            // uxProcessButton
            // 
            this.uxProcessButton.Location = new System.Drawing.Point(13, 42);
            this.uxProcessButton.Name = "uxProcessButton";
            this.uxProcessButton.Size = new System.Drawing.Size(75, 23);
            this.uxProcessButton.TabIndex = 2;
            this.uxProcessButton.Text = "Process";
            this.uxProcessButton.UseVisualStyleBackColor = true;
            this.uxProcessButton.Click += new System.EventHandler(this.uxProcessButton_Click);
            // 
            // uxResultsListBox
            // 
            this.uxResultsListBox.FormattingEnabled = true;
            this.uxResultsListBox.Location = new System.Drawing.Point(6, 19);
            this.uxResultsListBox.Name = "uxResultsListBox";
            this.uxResultsListBox.Size = new System.Drawing.Size(189, 121);
            this.uxResultsListBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxResultsListBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 149);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 232);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxProcessButton);
            this.Controls.Add(this.uxFilenameLabel);
            this.Controls.Add(this.uxFileChooserButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog uxFileDialog;
        private System.Windows.Forms.Button uxFileChooserButton;
        private System.Windows.Forms.Label uxFilenameLabel;
        private System.Windows.Forms.Button uxProcessButton;
        private System.Windows.Forms.ListBox uxResultsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

