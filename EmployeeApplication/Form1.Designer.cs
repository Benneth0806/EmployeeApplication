namespace EmployeeApplication
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 65);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(443, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(443, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(121, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(216, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(443, 287);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 27);
            textBox6.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 65);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 150);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 150);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Job Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 248);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 248);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 11;
            label6.Text = "Total hours worked";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(290, 342);
            button1.Name = "button1";
            button1.Size = new Size(214, 76);
            button1.TabIndex = 12;
            button1.Text = "Compute salary";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 442);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 13;
            label7.Text = "First name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(182, 486);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 14;
            label8.Text = "Last name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(182, 536);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 15;
            label9.Text = "Basic salary:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(290, 442);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 16;
            label10.Text = "First name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(290, 486);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 17;
            label11.Text = "Last name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(290, 536);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 18;
            label12.Text = "Basic Salary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 626);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}