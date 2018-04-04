namespace _291Project.Manager
{
    partial class MovieList
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
            this.dataSet1 = new _291Project.dataSet1();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new _291Project.dataSet1TableAdapters.MovieTableAdapter();
            this.MovieDateGridView = new System.Windows.Forms.DataGridView();
            this.ActorGridView = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.dataSet1;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // MovieDateGridView
            // 
            this.MovieDateGridView.AllowUserToAddRows = false;
            this.MovieDateGridView.AllowUserToDeleteRows = false;
            this.MovieDateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.MovieDateGridView.Location = new System.Drawing.Point(12, 38);
            this.MovieDateGridView.Name = "MovieDateGridView";
            this.MovieDateGridView.ReadOnly = true;
            this.MovieDateGridView.Size = new System.Drawing.Size(584, 218);
            this.MovieDateGridView.TabIndex = 0;
            this.MovieDateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieDateGridView_CellContentClick);
            // 
            // ActorGridView
            // 
            this.ActorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorGridView.Location = new System.Drawing.Point(12, 282);
            this.ActorGridView.Name = "ActorGridView";
            this.ActorGridView.Size = new System.Drawing.Size(594, 270);
            this.ActorGridView.TabIndex = 1;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movies";
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActorGridView);
            this.Controls.Add(this.MovieDateGridView);
            this.Name = "MovieList";
            this.Text = "MovieList";
            this.Load += new System.EventHandler(this.MovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private dataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.DataGridView MovieDateGridView;
        private System.Windows.Forms.DataGridView ActorGridView;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}