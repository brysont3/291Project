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
            this.queue = new System.Windows.Forms.Button();
            this.ReturnOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.OrderHistoryButton = new System.Windows.Forms.Button();
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
            this.button2.Location = new System.Drawing.Point(311, 289);
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
            // queue
            // 
            this.queue.Location = new System.Drawing.Point(49, 235);
            this.queue.Margin = new System.Windows.Forms.Padding(2);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(100, 49);
            this.queue.TabIndex = 5;
            this.queue.Text = "View Queue";
            this.queue.UseVisualStyleBackColor = true;
            this.queue.Click += new System.EventHandler(this.queue_Click);
            // 
            // ReturnOrder
            // 
            this.ReturnOrder.Location = new System.Drawing.Point(74, 188);
            this.ReturnOrder.Name = "ReturnOrder";
            this.ReturnOrder.Size = new System.Drawing.Size(150, 75);
            this.ReturnOrder.TabIndex = 3;
            this.ReturnOrder.Text = "Return an Order";
            this.ReturnOrder.UseVisualStyleBackColor = true;
            this.ReturnOrder.Click += new System.EventHandler(this.ReturnOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Your Current Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(300, 297);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(150, 71);
            this.PaymentButton.TabIndex = 5;
            this.PaymentButton.Text = "Make A Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // OrderHistoryButton
            // 
            this.OrderHistoryButton.Location = new System.Drawing.Point(74, 297);
            this.OrderHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderHistoryButton.Name = "OrderHistoryButton";
            this.OrderHistoryButton.Size = new System.Drawing.Size(150, 71);
            this.OrderHistoryButton.TabIndex = 6;
            this.OrderHistoryButton.Text = "Order History";
            this.OrderHistoryButton.UseVisualStyleBackColor = true;
            this.OrderHistoryButton.Click += new System.EventHandler(this.OrderHistoryButton_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 589);
            this.Controls.Add(this.OrderHistoryButton);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnOrder);
            this.Controls.Add(this.MovieSuggestionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateOrder);
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
        private System.Windows.Forms.Button queue;
        private System.Windows.Forms.Button MovieSuggestionButton;
        private System.Windows.Forms.Button ReturnOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button OrderHistoryButton;
    }
}