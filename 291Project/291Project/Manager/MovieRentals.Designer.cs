namespace _291Project.Manager
{
    partial class MovieRentals
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
            this.MovieGridView = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new _291Project.dataSet1();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new _291Project.dataSet1TableAdapters.GenreTableAdapter();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MovieGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieGridView
            // 
            this.MovieGridView.AllowUserToAddRows = false;
            this.MovieGridView.AllowUserToDeleteRows = false;
            this.MovieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieGridView.Location = new System.Drawing.Point(0, 27);
            this.MovieGridView.Name = "MovieGridView";
            this.MovieGridView.ReadOnly = true;
            this.MovieGridView.Size = new System.Drawing.Size(1023, 607);
            this.MovieGridView.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.dataSet1;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Items.AddRange(new object[] {
            "Movie Name",
            "Movie Type",
            "Customer Name"});
            this.OrderComboBox.Location = new System.Drawing.Point(147, 0);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(121, 21);
            this.OrderComboBox.TabIndex = 1;
            this.OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort By:";
            // 
            // MovieRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderComboBox);
            this.Controls.Add(this.MovieGridView);
            this.Name = "MovieRentals";
            this.Text = "MovieRentals";
            this.Load += new System.EventHandler(this.MovieRentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MovieGridView;
        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private dataSet1TableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.ComboBox OrderComboBox;
        private System.Windows.Forms.Label label1;
    }
}