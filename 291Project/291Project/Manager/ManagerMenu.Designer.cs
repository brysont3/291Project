namespace _291Project
{
    partial class ManagerMenu
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EditMovieButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.SalesReportButton = new System.Windows.Forms.Button();
            this.MovieRentalButton = new System.Windows.Forms.Button();
            this.MostActiveCustomersButton = new System.Windows.Forms.Button();
            this.MostActiveEmployeesButton = new System.Windows.Forms.Button();
            this.NewCustomerButton = new System.Windows.Forms.Button();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.MovieButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(484, 500);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EditMovieButton
            // 
            this.EditMovieButton.Location = new System.Drawing.Point(51, 393);
            this.EditMovieButton.Name = "EditMovieButton";
            this.EditMovieButton.Size = new System.Drawing.Size(124, 55);
            this.EditMovieButton.TabIndex = 1;
            this.EditMovieButton.Text = "Edit Movies";
            this.EditMovieButton.UseVisualStyleBackColor = true;
            this.EditMovieButton.Click += new System.EventHandler(this.EditMovieButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(51, 147);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(124, 59);
            this.EmployeeButton.TabIndex = 2;
            this.EmployeeButton.Text = "Employees";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // SalesReportButton
            // 
            this.SalesReportButton.Location = new System.Drawing.Point(51, 232);
            this.SalesReportButton.Name = "SalesReportButton";
            this.SalesReportButton.Size = new System.Drawing.Size(124, 60);
            this.SalesReportButton.TabIndex = 3;
            this.SalesReportButton.Text = "Sales Report";
            this.SalesReportButton.UseVisualStyleBackColor = true;
            this.SalesReportButton.Click += new System.EventHandler(this.SalesReportButton_Click);
            // 
            // MovieRentalButton
            // 
            this.MovieRentalButton.Location = new System.Drawing.Point(51, 317);
            this.MovieRentalButton.Name = "MovieRentalButton";
            this.MovieRentalButton.Size = new System.Drawing.Size(124, 57);
            this.MovieRentalButton.TabIndex = 4;
            this.MovieRentalButton.Text = "Movie Rentals";
            this.MovieRentalButton.UseVisualStyleBackColor = true;
            this.MovieRentalButton.Click += new System.EventHandler(this.MovieRentalButton_Click);
            // 
            // MostActiveCustomersButton
            // 
            this.MostActiveCustomersButton.Location = new System.Drawing.Point(283, 59);
            this.MostActiveCustomersButton.Name = "MostActiveCustomersButton";
            this.MostActiveCustomersButton.Size = new System.Drawing.Size(120, 55);
            this.MostActiveCustomersButton.TabIndex = 5;
            this.MostActiveCustomersButton.Text = "Most Active Customers";
            this.MostActiveCustomersButton.UseVisualStyleBackColor = true;
            this.MostActiveCustomersButton.Click += new System.EventHandler(this.MostActiveCustomersButton_Click);
            // 
            // MostActiveEmployeesButton
            // 
            this.MostActiveEmployeesButton.Location = new System.Drawing.Point(283, 147);
            this.MostActiveEmployeesButton.Name = "MostActiveEmployeesButton";
            this.MostActiveEmployeesButton.Size = new System.Drawing.Size(120, 59);
            this.MostActiveEmployeesButton.TabIndex = 6;
            this.MostActiveEmployeesButton.Text = "Most Active Employees";
            this.MostActiveEmployeesButton.UseVisualStyleBackColor = true;
            this.MostActiveEmployeesButton.Click += new System.EventHandler(this.MostActiveEmployeesButton_Click);
            // 
            // NewCustomerButton
            // 
            this.NewCustomerButton.Location = new System.Drawing.Point(283, 232);
            this.NewCustomerButton.Name = "NewCustomerButton";
            this.NewCustomerButton.Size = new System.Drawing.Size(120, 60);
            this.NewCustomerButton.TabIndex = 7;
            this.NewCustomerButton.Text = "New Customer";
            this.NewCustomerButton.UseVisualStyleBackColor = true;
            this.NewCustomerButton.Click += new System.EventHandler(this.NewCustomerButton_Click);
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.Location = new System.Drawing.Point(283, 317);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(120, 57);
            this.NewEmployeeButton.TabIndex = 8;
            this.NewEmployeeButton.Text = "New Employee";
            this.NewEmployeeButton.UseVisualStyleBackColor = true;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // MovieButton
            // 
            this.MovieButton.Location = new System.Drawing.Point(51, 59);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(124, 55);
            this.MovieButton.TabIndex = 9;
            this.MovieButton.Text = "Movies";
            this.MovieButton.UseVisualStyleBackColor = true;
            this.MovieButton.Click += new System.EventHandler(this.MovieButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Help",
            "Movies",
            "Employees",
            "Sales Report",
            "Movie Rentals",
            "Edit Movies",
            "Most Active Customers",
            "Most Active Employees",
            "New Customer",
            "New Employee"});
            this.comboBox1.Location = new System.Drawing.Point(455, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 535);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MovieButton);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.NewCustomerButton);
            this.Controls.Add(this.MostActiveEmployeesButton);
            this.Controls.Add(this.MostActiveCustomersButton);
            this.Controls.Add(this.MovieRentalButton);
            this.Controls.Add(this.SalesReportButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.EditMovieButton);
            this.Controls.Add(this.LogoutButton);
            this.Name = "ManagerMenu";
            this.Text = "ManagerMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button EditMovieButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button SalesReportButton;
        private System.Windows.Forms.Button MovieRentalButton;
        private System.Windows.Forms.Button MostActiveCustomersButton;
        private System.Windows.Forms.Button MostActiveEmployeesButton;
        private System.Windows.Forms.Button NewCustomerButton;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}