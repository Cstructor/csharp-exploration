namespace ModApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxFirstTextBox = new System.Windows.Forms.TextBox();
            this.uxSecondTextBox = new System.Windows.Forms.TextBox();
            this.uxResultTextBox = new System.Windows.Forms.TextBox();
            this.uxModulusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result:";
            // 
            // uxFirstTextBox
            // 
            this.uxFirstTextBox.Location = new System.Drawing.Point(106, 13);
            this.uxFirstTextBox.Name = "uxFirstTextBox";
            this.uxFirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxFirstTextBox.TabIndex = 3;
            // 
            // uxSecondTextBox
            // 
            this.uxSecondTextBox.Location = new System.Drawing.Point(106, 39);
            this.uxSecondTextBox.Name = "uxSecondTextBox";
            this.uxSecondTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxSecondTextBox.TabIndex = 4;
            // 
            // uxResultTextBox
            // 
            this.uxResultTextBox.Location = new System.Drawing.Point(106, 95);
            this.uxResultTextBox.Name = "uxResultTextBox";
            this.uxResultTextBox.ReadOnly = true;
            this.uxResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.uxResultTextBox.TabIndex = 6;
            this.uxResultTextBox.TabStop = false;
            // 
            // uxModulusButton
            // 
            this.uxModulusButton.Location = new System.Drawing.Point(106, 66);
            this.uxModulusButton.Name = "uxModulusButton";
            this.uxModulusButton.Size = new System.Drawing.Size(75, 23);
            this.uxModulusButton.TabIndex = 5;
            this.uxModulusButton.Text = "Modulus";
            this.uxModulusButton.UseVisualStyleBackColor = true;
            this.uxModulusButton.Click += new System.EventHandler(this.uxModulusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxModulusButton);
            this.Controls.Add(this.uxResultTextBox);
            this.Controls.Add(this.uxSecondTextBox);
            this.Controls.Add(this.uxFirstTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ModulusApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxFirstTextBox;
        private System.Windows.Forms.TextBox uxSecondTextBox;
        private System.Windows.Forms.TextBox uxResultTextBox;
        private System.Windows.Forms.Button uxModulusButton;
    }
}

