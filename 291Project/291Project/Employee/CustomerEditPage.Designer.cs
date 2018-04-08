namespace _291Project.Employee
{
    partial class CustomerEditPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new _291Project.dataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new _291Project.dataSet1TableAdapters.CustomerTableAdapter();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCreationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.accountCreationDateDataGridViewTextBoxColumn,
            this.creditCardDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1245, 429);
            this.dataGridView1.TabIndex = 0;
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
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // accountCreationDateDataGridViewTextBoxColumn
            // 
            this.accountCreationDateDataGridViewTextBoxColumn.DataPropertyName = "AccountCreationDate";
            this.accountCreationDateDataGridViewTextBoxColumn.HeaderText = "AccountCreationDate";
            this.accountCreationDateDataGridViewTextBoxColumn.Name = "accountCreationDateDataGridViewTextBoxColumn";
            // 
            // creditCardDataGridViewTextBoxColumn
            // 
            this.creditCardDataGridViewTextBoxColumn.DataPropertyName = "CreditCard";
            this.creditCardDataGridViewTextBoxColumn.HeaderText = "CreditCard";
            this.creditCardDataGridViewTextBoxColumn.Name = "creditCardDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(-1, 514);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(140, 95);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete Selected Row";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1101, 514);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(143, 95);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CustomerEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 610);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerEditPage";
            this.Text = "CustomerEditPage";
            this.Load += new System.EventHandler(this.CustomerEditPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private dataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCreationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}