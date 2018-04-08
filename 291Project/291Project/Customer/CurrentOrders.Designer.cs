namespace _291Project.Customer
{
    partial class CurrentOrders
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
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AllowUserToAddRows = false;
            this.OrderDataGridView.AllowUserToDeleteRows = false;
            this.OrderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Location = new System.Drawing.Point(12, 12);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.ReadOnly = true;
            this.OrderDataGridView.RowTemplate.Height = 28;
            this.OrderDataGridView.Size = new System.Drawing.Size(673, 239);
            this.OrderDataGridView.TabIndex = 1;
            // 
            // CurrentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 263);
            this.Controls.Add(this.OrderDataGridView);
            this.Name = "CurrentOrders";
            this.Text = "CurrentOrders";
            this.Load += new System.EventHandler(this.CurrentOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView OrderDataGridView;
    }
}