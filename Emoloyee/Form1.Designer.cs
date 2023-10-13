namespace Emoloyee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
      
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            SalaryDetails = new System.Windows.Forms.ListBox();
            Enter_Salary = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            Submit = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(137, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 17);
            label1.TabIndex = 0;
            label1.Text = "Employe Name";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(137, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(139, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(137, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 17);
            label2.TabIndex = 2;
            label2.Text = "Employe Code";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(137, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(139, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SalaryDetails
            // 
            SalaryDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            SalaryDetails.FormattingEnabled = true;
            SalaryDetails.ItemHeight = 15;
            SalaryDetails.Location = new System.Drawing.Point(137, 140);
            SalaryDetails.Name = "SalaryDetails";
            SalaryDetails.Size = new System.Drawing.Size(518, 109);
            SalaryDetails.TabIndex = 4;
            SalaryDetails.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Enter_Salary
            // 
            Enter_Salary.Location = new System.Drawing.Point(348, 202);
            Enter_Salary.Name = "Enter_Salary";
            Enter_Salary.Size = new System.Drawing.Size(110, 23);
            Enter_Salary.TabIndex = 6;
            Enter_Salary.Tag = "E";
            Enter_Salary.TextChanged += Enter_Salary_TextChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(509, 202);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 23);
            button1.TabIndex = 7;
            button1.Text = "+Add More";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Submit
            // 
            Submit.Location = new System.Drawing.Point(168, 330);
            Submit.Name = "Submit";
            Submit.Size = new System.Drawing.Size(72, 29);
            Submit.TabIndex = 9;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(278, 330);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 29);
            button2.TabIndex = 10;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(168, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new System.Drawing.Size(123, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new System.DateTime(2023, 10, 26, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(369, 182);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 17);
            label3.TabIndex = 12;
            label3.Text = "Enter Salary";
            label3.Click += label3_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(Submit);
            Controls.Add(button1);
            Controls.Add(Enter_Salary);
            Controls.Add(SalaryDetails);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox SalaryDetails;
        private System.Windows.Forms.TextBox Enter_Salary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}
