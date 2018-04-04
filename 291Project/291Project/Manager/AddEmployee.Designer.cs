namespace _291Project.Manager
{
    partial class AddEmployee
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.TelephoneTextbox = new System.Windows.Forms.TextBox();
            this.ZipTextbox = new System.Windows.Forms.TextBox();
            this.StateTextbox = new System.Windows.Forms.TextBox();
            this.CityTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SSNTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.HourlyWageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Confrim Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Password";
            // 
            // ConfirmTextbox
            // 
            this.ConfirmTextbox.Location = new System.Drawing.Point(290, 419);
            this.ConfirmTextbox.Name = "ConfirmTextbox";
            this.ConfirmTextbox.Size = new System.Drawing.Size(100, 20);
            this.ConfirmTextbox.TabIndex = 9;
            this.ConfirmTextbox.UseSystemPasswordChar = true;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(290, 384);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextbox.TabIndex = 8;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "label13";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Cost";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.comboBox1.Location = new System.Drawing.Point(290, 485);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "AccountType";
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(238, 562);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 52;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(392, 562);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 46;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(234, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "New Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "First Name";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(290, 346);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextbox.TabIndex = 7;
            // 
            // TelephoneTextbox
            // 
            this.TelephoneTextbox.Location = new System.Drawing.Point(290, 303);
            this.TelephoneTextbox.Name = "TelephoneTextbox";
            this.TelephoneTextbox.Size = new System.Drawing.Size(100, 20);
            this.TelephoneTextbox.TabIndex = 6;
            // 
            // ZipTextbox
            // 
            this.ZipTextbox.Location = new System.Drawing.Point(290, 259);
            this.ZipTextbox.Name = "ZipTextbox";
            this.ZipTextbox.Size = new System.Drawing.Size(100, 20);
            this.ZipTextbox.TabIndex = 5;
            // 
            // StateTextbox
            // 
            this.StateTextbox.Location = new System.Drawing.Point(290, 216);
            this.StateTextbox.Name = "StateTextbox";
            this.StateTextbox.Size = new System.Drawing.Size(100, 20);
            this.StateTextbox.TabIndex = 4;
            // 
            // CityTextbox
            // 
            this.CityTextbox.Location = new System.Drawing.Point(290, 176);
            this.CityTextbox.Name = "CityTextbox";
            this.CityTextbox.Size = new System.Drawing.Size(100, 20);
            this.CityTextbox.TabIndex = 3;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(290, 103);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextbox.TabIndex = 1;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(290, 70);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextbox.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "SSN";
            // 
            // SSNTextbox
            // 
            this.SSNTextbox.Location = new System.Drawing.Point(290, 137);
            this.SSNTextbox.Name = "SSNTextbox";
            this.SSNTextbox.Size = new System.Drawing.Size(100, 20);
            this.SSNTextbox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Hourly Wage";
            // 
            // HourlyWageTextBox
            // 
            this.HourlyWageTextBox.Location = new System.Drawing.Point(290, 449);
            this.HourlyWageTextBox.Name = "HourlyWageTextBox";
            this.HourlyWageTextBox.Size = new System.Drawing.Size(100, 20);
            this.HourlyWageTextBox.TabIndex = 10;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 601);
            this.Controls.Add(this.HourlyWageTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SSNTextbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ConfirmTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.TelephoneTextbox);
            this.Controls.Add(this.ZipTextbox);
            this.Controls.Add(this.StateTextbox);
            this.Controls.Add(this.CityTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ConfirmTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox TelephoneTextbox;
        private System.Windows.Forms.TextBox ZipTextbox;
        private System.Windows.Forms.TextBox StateTextbox;
        private System.Windows.Forms.TextBox CityTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SSNTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox HourlyWageTextBox;
    }
}