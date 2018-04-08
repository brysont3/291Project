﻿namespace _291Project.Customer
{
    partial class ReturnMovie
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
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label returnDateLabel;
            System.Windows.Forms.Label movieIDLabel;
            System.Windows.Forms.Label cIDLabel;
            System.Windows.Forms.Label eIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnMovie));
            this.dataSet1 = new _291Project.dataSet1();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new _291Project.dataSet1TableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new _291Project.dataSet1TableAdapters.TableAdapterManager();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.cIDTextBox = new System.Windows.Forms.TextBox();
            this.eIDTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ReturnMovieButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            returnDateLabel = new System.Windows.Forms.Label();
            movieIDLabel = new System.Windows.Forms.Label();
            cIDLabel = new System.Windows.Forms.Label();
            eIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(91, 155);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(74, 20);
            orderIDLabel.TabIndex = 1;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(91, 188);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(92, 20);
            orderDateLabel.TabIndex = 3;
            orderDateLabel.Text = "Order Date:";
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Location = new System.Drawing.Point(91, 220);
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new System.Drawing.Size(101, 20);
            returnDateLabel.TabIndex = 5;
            returnDateLabel.Text = "Return Date:";
            // 
            // movieIDLabel
            // 
            movieIDLabel.AutoSize = true;
            movieIDLabel.Location = new System.Drawing.Point(91, 251);
            movieIDLabel.Name = "movieIDLabel";
            movieIDLabel.Size = new System.Drawing.Size(75, 20);
            movieIDLabel.TabIndex = 7;
            movieIDLabel.Text = "Movie ID:";
            // 
            // cIDLabel
            // 
            cIDLabel.AutoSize = true;
            cIDLabel.Location = new System.Drawing.Point(91, 283);
            cIDLabel.Name = "cIDLabel";
            cIDLabel.Size = new System.Drawing.Size(41, 20);
            cIDLabel.TabIndex = 9;
            cIDLabel.Text = "CID:";
            // 
            // eIDLabel
            // 
            eIDLabel.AutoSize = true;
            eIDLabel.Location = new System.Drawing.Point(91, 315);
            eIDLabel.Name = "eIDLabel";
            eIDLabel.Size = new System.Drawing.Size(41, 20);
            eIDLabel.TabIndex = 11;
            eIDLabel.Text = "EID:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "dataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.dataSet1;
            this.orderBindingSource.Filter = "ReturnDate IS NULL AND EID IS NOT NULL AND CID = 0" + Program.CustomerID.ToString();
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.RateTableAdapter = null;
            this.tableAdapterManager.RentQueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _291Project.dataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(715, 31);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.orderBindingNavigatorSaveItem.Text = "Save Data";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(198, 152);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.ReadOnly = true;
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.orderIDTextBox.TabIndex = 2;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(198, 184);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.orderDateDateTimePicker.TabIndex = 4;
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "ReturnDate", true));
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(198, 216);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.returnDateDateTimePicker.TabIndex = 6;
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "MovieID", true));
            this.movieIDTextBox.Location = new System.Drawing.Point(198, 248);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.ReadOnly = true;
            this.movieIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.movieIDTextBox.TabIndex = 8;
            // 
            // cIDTextBox
            // 
            this.cIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CID", true));
            this.cIDTextBox.Location = new System.Drawing.Point(198, 280);
            this.cIDTextBox.Name = "cIDTextBox";
            this.cIDTextBox.ReadOnly = true;
            this.cIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.cIDTextBox.TabIndex = 10;
            // 
            // eIDTextBox
            // 
            this.eIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "EID", true));
            this.eIDTextBox.Location = new System.Drawing.Point(198, 312);
            this.eIDTextBox.Name = "eIDTextBox";
            this.eIDTextBox.ReadOnly = true;
            this.eIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.eIDTextBox.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.orderBindingSource;
            this.comboBox1.DisplayMember = "OrderID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "OrderID";
            // 
            // ReturnMovieButton
            // 
            this.ReturnMovieButton.Location = new System.Drawing.Point(516, 152);
            this.ReturnMovieButton.Name = "ReturnMovieButton";
            this.ReturnMovieButton.Size = new System.Drawing.Size(143, 70);
            this.ReturnMovieButton.TabIndex = 14;
            this.ReturnMovieButton.Text = "Return Movie";
            this.ReturnMovieButton.UseVisualStyleBackColor = true;
            this.ReturnMovieButton.Click += new System.EventHandler(this.ReturnMovieButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(516, 253);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(143, 80);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel && Close";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order ID:";
            // 
            // ReturnMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ReturnMovieButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(returnDateLabel);
            this.Controls.Add(this.returnDateDateTimePicker);
            this.Controls.Add(movieIDLabel);
            this.Controls.Add(this.movieIDTextBox);
            this.Controls.Add(cIDLabel);
            this.Controls.Add(this.cIDTextBox);
            this.Controls.Add(eIDLabel);
            this.Controls.Add(this.eIDTextBox);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "ReturnMovie";
            this.Text = "ReturnMovie";
            this.Load += new System.EventHandler(this.ReturnMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataSet1 dataSet1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private dataSet1TableAdapters.OrderTableAdapter orderTableAdapter;
        private dataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.TextBox cIDTextBox;
        private System.Windows.Forms.TextBox eIDTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ReturnMovieButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
    }
}