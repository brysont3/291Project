namespace _291Project.Customer
{
    partial class CustomerMovieSuggestions
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
            this.MovieSuggestionGridView = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MovieSuggestionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieSuggestionGridView
            // 
            this.MovieSuggestionGridView.AllowUserToAddRows = false;
            this.MovieSuggestionGridView.AllowUserToDeleteRows = false;
            this.MovieSuggestionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieSuggestionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order});
            this.MovieSuggestionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieSuggestionGridView.Location = new System.Drawing.Point(0, 0);
            this.MovieSuggestionGridView.Name = "MovieSuggestionGridView";
            this.MovieSuggestionGridView.ReadOnly = true;
            this.MovieSuggestionGridView.Size = new System.Drawing.Size(917, 579);
            this.MovieSuggestionGridView.TabIndex = 0;
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // CustomerMovieSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 579);
            this.Controls.Add(this.MovieSuggestionGridView);
            this.Name = "CustomerMovieSuggestions";
            this.Text = "CustomerMovieSuggestions";
            ((System.ComponentModel.ISupportInitialize)(this.MovieSuggestionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MovieSuggestionGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
    }
}