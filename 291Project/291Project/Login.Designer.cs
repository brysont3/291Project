namespace _291Project
{
    partial class Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CustomerLoginFailedLabel = new System.Windows.Forms.Label();
            this.CustomerLoginButton = new System.Windows.Forms.Button();
            this.CustomerPasswordTextbox = new System.Windows.Forms.TextBox();
            this.CustomerEmailTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EmployeeLoginFailedLabel = new System.Windows.Forms.Label();
            this.EmployeeLoginButton = new System.Windows.Forms.Button();
            this.EmployeePasswordTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeEmailTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CustomerLoginFailedLabel);
            this.tabPage1.Controls.Add(this.CustomerLoginButton);
            this.tabPage1.Controls.Add(this.CustomerPasswordTextbox);
            this.tabPage1.Controls.Add(this.CustomerEmailTextbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CustomerLoginFailedLabel
            // 
            this.CustomerLoginFailedLabel.AutoSize = true;
            this.CustomerLoginFailedLabel.Location = new System.Drawing.Point(259, 71);
            this.CustomerLoginFailedLabel.Name = "CustomerLoginFailedLabel";
            this.CustomerLoginFailedLabel.Size = new System.Drawing.Size(35, 13);
            this.CustomerLoginFailedLabel.TabIndex = 6;
            this.CustomerLoginFailedLabel.Text = "label7";
            this.CustomerLoginFailedLabel.Visible = false;
            // 
            // CustomerLoginButton
            // 
            this.CustomerLoginButton.Location = new System.Drawing.Point(353, 365);
            this.CustomerLoginButton.Name = "CustomerLoginButton";
            this.CustomerLoginButton.Size = new System.Drawing.Size(75, 31);
            this.CustomerLoginButton.TabIndex = 5;
            this.CustomerLoginButton.Text = "Login";
            this.CustomerLoginButton.UseVisualStyleBackColor = true;
            this.CustomerLoginButton.Click += new System.EventHandler(this.CustomerLoginButton_Click);
            // 
            // CustomerPasswordTextbox
            // 
            this.CustomerPasswordTextbox.Location = new System.Drawing.Point(262, 269);
            this.CustomerPasswordTextbox.Name = "CustomerPasswordTextbox";
            this.CustomerPasswordTextbox.Size = new System.Drawing.Size(166, 20);
            this.CustomerPasswordTextbox.TabIndex = 4;
            this.CustomerPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // CustomerEmailTextbox
            // 
            this.CustomerEmailTextbox.Location = new System.Drawing.Point(262, 203);
            this.CustomerEmailTextbox.Name = "CustomerEmailTextbox";
            this.CustomerEmailTextbox.Size = new System.Drawing.Size(166, 20);
            this.CustomerEmailTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EmployeeLoginFailedLabel);
            this.tabPage2.Controls.Add(this.EmployeeLoginButton);
            this.tabPage2.Controls.Add(this.EmployeePasswordTextbox);
            this.tabPage2.Controls.Add(this.EmployeeEmailTextbox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EmployeeLoginFailedLabel
            // 
            this.EmployeeLoginFailedLabel.AutoSize = true;
            this.EmployeeLoginFailedLabel.Location = new System.Drawing.Point(258, 72);
            this.EmployeeLoginFailedLabel.Name = "EmployeeLoginFailedLabel";
            this.EmployeeLoginFailedLabel.Size = new System.Drawing.Size(35, 13);
            this.EmployeeLoginFailedLabel.TabIndex = 12;
            this.EmployeeLoginFailedLabel.Text = "label8";
            this.EmployeeLoginFailedLabel.Visible = false;
            // 
            // EmployeeLoginButton
            // 
            this.EmployeeLoginButton.Location = new System.Drawing.Point(352, 369);
            this.EmployeeLoginButton.Name = "EmployeeLoginButton";
            this.EmployeeLoginButton.Size = new System.Drawing.Size(75, 31);
            this.EmployeeLoginButton.TabIndex = 11;
            this.EmployeeLoginButton.Text = "Login";
            this.EmployeeLoginButton.UseVisualStyleBackColor = true;
            this.EmployeeLoginButton.Click += new System.EventHandler(this.EmployeeLoginButton_Click);
            // 
            // EmployeePasswordTextbox
            // 
            this.EmployeePasswordTextbox.Location = new System.Drawing.Point(261, 273);
            this.EmployeePasswordTextbox.Name = "EmployeePasswordTextbox";
            this.EmployeePasswordTextbox.Size = new System.Drawing.Size(166, 20);
            this.EmployeePasswordTextbox.TabIndex = 10;
            this.EmployeePasswordTextbox.UseSystemPasswordChar = true;
            // 
            // EmployeeEmailTextbox
            // 
            this.EmployeeEmailTextbox.Location = new System.Drawing.Point(261, 207);
            this.EmployeeEmailTextbox.Name = "EmployeeEmailTextbox";
            this.EmployeeEmailTextbox.Size = new System.Drawing.Size(166, 20);
            this.EmployeeEmailTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Employee Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustomerLoginButton;
        private System.Windows.Forms.TextBox CustomerPasswordTextbox;
        private System.Windows.Forms.TextBox CustomerEmailTextbox;
        private System.Windows.Forms.Button EmployeeLoginButton;
        private System.Windows.Forms.TextBox EmployeePasswordTextbox;
        private System.Windows.Forms.TextBox EmployeeEmailTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CustomerLoginFailedLabel;
        private System.Windows.Forms.Label EmployeeLoginFailedLabel;
    }
}