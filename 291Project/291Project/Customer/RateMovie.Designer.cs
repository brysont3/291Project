namespace _291Project.Customer
{
    partial class RateMovie
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
            this.MovieComboBox = new System.Windows.Forms.ComboBox();
            this.RateMovieButton = new System.Windows.Forms.Button();
            this.RateComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieComboBox
            // 
            this.MovieComboBox.FormattingEnabled = true;
            this.MovieComboBox.Location = new System.Drawing.Point(37, 111);
            this.MovieComboBox.Name = "MovieComboBox";
            this.MovieComboBox.Size = new System.Drawing.Size(152, 28);
            this.MovieComboBox.TabIndex = 0;
            // 
            // RateMovieButton
            // 
            this.RateMovieButton.Location = new System.Drawing.Point(425, 83);
            this.RateMovieButton.Name = "RateMovieButton";
            this.RateMovieButton.Size = new System.Drawing.Size(136, 65);
            this.RateMovieButton.TabIndex = 1;
            this.RateMovieButton.Text = "Rate Movie";
            this.RateMovieButton.UseVisualStyleBackColor = true;
            this.RateMovieButton.Click += new System.EventHandler(this.RateMovieButton_Click);
            // 
            // RateComboBox
            // 
            this.RateComboBox.FormattingEnabled = true;
            this.RateComboBox.Location = new System.Drawing.Point(239, 111);
            this.RateComboBox.Name = "RateComboBox";
            this.RateComboBox.Size = new System.Drawing.Size(121, 28);
            this.RateComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rating:";
            // 
            // RateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RateComboBox);
            this.Controls.Add(this.RateMovieButton);
            this.Controls.Add(this.MovieComboBox);
            this.Name = "RateMovie";
            this.Text = "RateMovie";
            this.Load += new System.EventHandler(this.RateMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MovieComboBox;
        private System.Windows.Forms.Button RateMovieButton;
        private System.Windows.Forms.ComboBox RateComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}