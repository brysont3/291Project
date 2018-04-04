namespace _291Project.Employee
{
    partial class MovieSuggestions
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
            this.components = new System.ComponentModel.Container();
            this.MovieSuggestionGridView = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new _291Project.dataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new _291Project.dataSet1TableAdapters.CustomerTableAdapter();
            this.CustomerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieSuggestionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieSuggestionGridView
            // 
            this.MovieSuggestionGridView.AllowUserToAddRows = false;
            this.MovieSuggestionGridView.AllowUserToDeleteRows = false;
            this.MovieSuggestionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieSuggestionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order});
            this.MovieSuggestionGridView.Location = new System.Drawing.Point(12, 65);
            this.MovieSuggestionGridView.Name = "MovieSuggestionGridView";
            this.MovieSuggestionGridView.ReadOnly = true;
            this.MovieSuggestionGridView.Size = new System.Drawing.Size(747, 511);
            this.MovieSuggestionGridView.TabIndex = 0;
            this.MovieSuggestionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieSuggestionGridView_CellContentClick);
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Customer";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerTextBox
            // 
            this.CustomerTextBox.Location = new System.Drawing.Point(156, 21);
            this.CustomerTextBox.Name = "CustomerTextBox";
            this.CustomerTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 588);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieSuggestionGridView);
            this.Name = "MovieSuggestions";
            this.Text = "MovieSuggestions";
            this.Load += new System.EventHandler(this.MovieSuggestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieSuggestionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MovieSuggestionGridView;
        private System.Windows.Forms.Label label1;
        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private dataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
        private System.Windows.Forms.TextBox CustomerTextBox;
        private System.Windows.Forms.Button button1;
    }
}