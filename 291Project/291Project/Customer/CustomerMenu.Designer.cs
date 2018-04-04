namespace _291Project.Employee
{
    partial class CustomerMenu
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
            this.CreateOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MovieSuggestionButton = new System.Windows.Forms.Button();
            this.edit_info = new System.Windows.Forms.Button();
            this.view_movies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(49, 43);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(2);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(100, 49);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "Create an order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MovieSuggestionButton
            // 
            this.MovieSuggestionButton.Location = new System.Drawing.Point(200, 43);
            this.MovieSuggestionButton.Name = "MovieSuggestionButton";
            this.MovieSuggestionButton.Size = new System.Drawing.Size(101, 49);
            this.MovieSuggestionButton.TabIndex = 2;
            this.MovieSuggestionButton.Text = "Movie Suggestions";
            this.MovieSuggestionButton.UseVisualStyleBackColor = true;
            this.MovieSuggestionButton.Click += new System.EventHandler(this.MovieSuggestionButton_Click);
            // 
            // edit_info
            // 
            this.edit_info.Location = new System.Drawing.Point(49, 144);
            this.edit_info.Margin = new System.Windows.Forms.Padding(2);
            this.edit_info.Name = "edit_info";
            this.edit_info.Size = new System.Drawing.Size(100, 49);
            this.edit_info.TabIndex = 3;
            this.edit_info.Text = "Edit Info";
            this.edit_info.UseVisualStyleBackColor = true;
            this.edit_info.Click += new System.EventHandler(this.edit_info_Click);
            // 
            // view_movies
            // 
            this.view_movies.Location = new System.Drawing.Point(200, 144);
            this.view_movies.Margin = new System.Windows.Forms.Padding(2);
            this.view_movies.Name = "view_movies";
            this.view_movies.Size = new System.Drawing.Size(100, 49);
            this.view_movies.TabIndex = 4;
            this.view_movies.Text = "View Movies";
            this.view_movies.UseVisualStyleBackColor = true;
            this.view_movies.Click += new System.EventHandler(this.view_movies_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 277);
            this.Controls.Add(this.view_movies);
            this.Controls.Add(this.edit_info);
            this.Controls.Add(this.MovieSuggestionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MovieSuggestionButton;
        private System.Windows.Forms.Button edit_info;
        private System.Windows.Forms.Button view_movies;
    }
}