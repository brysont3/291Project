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
            this.button3 = new System.Windows.Forms.Button();
            this.view_queue = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.movies = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(49, 28);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(1);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(100, 32);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "Create an order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MovieSuggestionButton
            // 
            this.MovieSuggestionButton.Location = new System.Drawing.Point(207, 28);
            this.MovieSuggestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.MovieSuggestionButton.Name = "MovieSuggestionButton";
            this.MovieSuggestionButton.Size = new System.Drawing.Size(100, 47);
            this.MovieSuggestionButton.TabIndex = 2;
            this.MovieSuggestionButton.Text = "Movie Suggestions";
            this.MovieSuggestionButton.UseVisualStyleBackColor = true;
            this.MovieSuggestionButton.Click += new System.EventHandler(this.MovieSuggestionButton_Click);
            // 
            // edit_info
            // 
            this.edit_info.Location = new System.Drawing.Point(0, 0);
            this.edit_info.Name = "edit_info";
            this.edit_info.Size = new System.Drawing.Size(75, 23);
            this.edit_info.TabIndex = 0;
            // 
            // view_movies
            // 
            this.view_movies.Location = new System.Drawing.Point(0, 0);
            this.view_movies.Name = "view_movies";
            this.view_movies.Size = new System.Drawing.Size(75, 23);
            this.view_movies.TabIndex = 0;
            // 
            // queue
            // 
            this.queue.Location = new System.Drawing.Point(0, 0);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(75, 23);
            this.queue.TabIndex = 0;
            // 
            // ReturnOrder
            // 
            this.ReturnOrder.Location = new System.Drawing.Point(49, 94);
            this.ReturnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnOrder.Name = "ReturnOrder";
            this.ReturnOrder.Size = new System.Drawing.Size(100, 49);
            this.ReturnOrder.TabIndex = 3;
            this.ReturnOrder.Text = "Return an Order";
            this.ReturnOrder.UseVisualStyleBackColor = true;
            this.ReturnOrder.Click += new System.EventHandler(this.ReturnOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Your Current Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(207, 152);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(100, 46);
            this.PaymentButton.TabIndex = 5;
            this.PaymentButton.Text = "Make A Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // OrderHistoryButton
            // 
            this.OrderHistoryButton.Location = new System.Drawing.Point(49, 180);
            this.OrderHistoryButton.Name = "OrderHistoryButton";
            this.OrderHistoryButton.Size = new System.Drawing.Size(100, 46);
            this.OrderHistoryButton.TabIndex = 6;
            this.OrderHistoryButton.Text = "Order History";
            this.OrderHistoryButton.UseVisualStyleBackColor = true;
            this.OrderHistoryButton.Click += new System.EventHandler(this.OrderHistoryButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 415);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 71);
            this.button3.TabIndex = 7;
            this.button3.Text = "Rate a Movie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // view_queue
            // 
            this.view_queue.Location = new System.Drawing.Point(207, 296);
            this.view_queue.Name = "view_queue";
            this.view_queue.Size = new System.Drawing.Size(100, 46);
            this.view_queue.TabIndex = 7;
            this.view_queue.Text = "View Queue";
            this.view_queue.UseVisualStyleBackColor = true;
            this.view_queue.Click += new System.EventHandler(this.view_queue_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(49, 261);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(100, 46);
            this.info.TabIndex = 8;
            this.info.Text = "Edit Info";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // movies
            // 
            this.movies.Location = new System.Drawing.Point(207, 224);
            this.movies.Name = "movies";
            this.movies.Size = new System.Drawing.Size(100, 46);
            this.movies.TabIndex = 9;
            this.movies.Text = "View Movies";
            this.movies.UseVisualStyleBackColor = true;
            this.movies.Click += new System.EventHandler(this.movies_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Help",
            "Create an Order",
            "Return an Order",
            "Order History",
            "Edit Info",
            "Movie Suggetions",
            "View Your Current Orders ",
            "Make a Payment",
            "View Movies",
            "View Queue"});
            this.comboBox1.Location = new System.Drawing.Point(328, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 383);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.movies);
            this.Controls.Add(this.info);
            this.Controls.Add(this.view_queue);
            this.Controls.Add(this.OrderHistoryButton);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnOrder);
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
        private System.Windows.Forms.Button queue;
        private System.Windows.Forms.Button ReturnOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button OrderHistoryButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button view_queue;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button movies;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}