namespace _291Project
{
    partial class CustomerMovie
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
            this.tableAdapterManager = new _291Project.dataSet1TableAdapters.TableAdapterManager();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.added = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new _291Project.dataSet1TableAdapters.GenreTableAdapter();
            this.select_genre = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorTableAdapter = new _291Project.dataSet1TableAdapters.ActorTableAdapter();
            this.movie_contains = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.actor_contains = new System.Windows.Forms.TextBox();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Queue = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountInfoTableAdapter = null;
            this.tableAdapterManager.ActorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MoviesInTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.RateTableAdapter = null;
            this.tableAdapterManager.RentQueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _291Project.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AllowUserToAddRows = false;
            this.movieDataGridView.AllowUserToDeleteRows = false;
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.Queue});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Location = new System.Drawing.Point(12, 76);
            this.movieDataGridView.MultiSelect = false;
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.ReadOnly = true;
            this.movieDataGridView.Size = new System.Drawing.Size(756, 510);
            this.movieDataGridView.TabIndex = 1;
            this.movieDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDataGridView_CellContentClick);
            // 
            // added
            // 
            this.added.AutoSize = true;
            this.added.Location = new System.Drawing.Point(53, 589);
            this.added.Name = "added";
            this.added.Size = new System.Drawing.Size(114, 13);
            this.added.TabIndex = 2;
            this.added.Text = "Movie added to queue";
            this.added.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Genre";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // select_genre
            // 
            this.select_genre.DataSource = this.genreBindingSource;
            this.select_genre.DisplayMember = "Genre";
            this.select_genre.FormattingEnabled = true;
            this.select_genre.Location = new System.Drawing.Point(56, 17);
            this.select_genre.Name = "select_genre";
            this.select_genre.Size = new System.Drawing.Size(121, 21);
            this.select_genre.TabIndex = 3;
            this.select_genre.ValueMember = "Genre";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.dataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actor Name:";
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataMember = "Actor";
            this.actorBindingSource.DataSource = this.dataSet1;
            // 
            // actorTableAdapter
            // 
            this.actorTableAdapter.ClearBeforeFill = true;
            // 
            // movie_contains
            // 
            this.movie_contains.Location = new System.Drawing.Point(503, 17);
            this.movie_contains.Name = "movie_contains";
            this.movie_contains.Size = new System.Drawing.Size(138, 20);
            this.movie_contains.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Movie Name:";
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(679, 17);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(75, 23);
            this.filter.TabIndex = 9;
            this.filter.Text = "Filter";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // actor_contains
            // 
            this.actor_contains.Location = new System.Drawing.Point(270, 17);
            this.actor_contains.Name = "actor_contains";
            this.actor_contains.Size = new System.Drawing.Size(134, 20);
            this.actor_contains.TabIndex = 10;
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "MovieID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovieName";
            this.dataGridViewTextBoxColumn2.FillWeight = 125F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumCopies";
            this.dataGridViewTextBoxColumn5.FillWeight = 125F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Copies";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // Queue
            // 
            this.Queue.HeaderText = "Queue";
            this.Queue.Name = "Queue";
            this.Queue.ReadOnly = true;
            this.Queue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Queue.Text = "Add to Queue";
            this.Queue.UseColumnTextForButtonValue = true;
            this.Queue.Width = 200;
            // 
            // CustomerMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 630);
            this.Controls.Add(this.actor_contains);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movie_contains);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_genre);
            this.Controls.Add(this.added);
            this.Controls.Add(this.movieDataGridView);
            this.Name = "CustomerMovie";
            this.Text = "CustomerMovie";
            this.Load += new System.EventHandler(this.CustomerMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private dataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.Label added;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dataSet1TableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.ComboBox select_genre;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private dataSet1TableAdapters.ActorTableAdapter actorTableAdapter;
        private System.Windows.Forms.TextBox movie_contains;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.TextBox actor_contains;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn Queue;
    }
}