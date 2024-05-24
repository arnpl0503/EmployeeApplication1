namespace EmployeeApplication1
{
    partial class ComputeSalary
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblBasicsalary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Name*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(237, 323);
            button1.Name = "button1";
            button1.Size = new Size(185, 51);
            button1.TabIndex = 2;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 48);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Lastname";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(395, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 140);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 5;
            label3.Text = "Department*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 140);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Job title*";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(395, 163);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(202, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 232);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 9;
            label5.Text = "Rate per hour*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(395, 232);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 10;
            label6.Text = " Total hours worked*";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(54, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(395, 255);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 27);
            textBox6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 412);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 13;
            label7.Text = "First name*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 455);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 14;
            label8.Text = "Last name*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 494);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 15;
            label9.Text = "Basic salary*";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(206, 412);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(130, 20);
            lblFirstname.TabIndex = 16;
            lblFirstname.Text = "<First name here>";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(206, 455);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(129, 20);
            lblLastname.TabIndex = 17;
            lblLastname.Text = "<Last name here>";
            // 
            // lblBasicsalary
            // 
            lblBasicsalary.AutoSize = true;
            lblBasicsalary.Location = new Point(207, 494);
            lblBasicsalary.Name = "lblBasicsalary";
            lblBasicsalary.Size = new Size(138, 20);
            lblBasicsalary.TabIndex = 18;
            lblBasicsalary.Text = "<Basic salary here>";
            // 
            // ComputeSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 556);
            Controls.Add(lblBasicsalary);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ComputeSalary";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblFirstname;
        private Label lblLastname;
        private Label lblBasicsalary;
    }
}
