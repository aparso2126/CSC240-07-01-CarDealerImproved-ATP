namespace CSC240_07_01_CarDealerImproved_ATP
{
    partial class CarSpecsForm
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
            this.UxSpecTitleLabel = new System.Windows.Forms.Label();
            this.UxSpecsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxSpecTitleLabel
            // 
            this.UxSpecTitleLabel.AutoSize = true;
            this.UxSpecTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxSpecTitleLabel.ForeColor = System.Drawing.Color.Lime;
            this.UxSpecTitleLabel.Location = new System.Drawing.Point(12, 12);
            this.UxSpecTitleLabel.Name = "UxSpecTitleLabel";
            this.UxSpecTitleLabel.Size = new System.Drawing.Size(0, 29);
            this.UxSpecTitleLabel.TabIndex = 1;
            // 
            // UxSpecsLabel
            // 
            this.UxSpecsLabel.AutoSize = true;
            this.UxSpecsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxSpecsLabel.ForeColor = System.Drawing.Color.Lime;
            this.UxSpecsLabel.Location = new System.Drawing.Point(300, 12);
            this.UxSpecsLabel.Name = "UxSpecsLabel";
            this.UxSpecsLabel.Size = new System.Drawing.Size(0, 29);
            this.UxSpecsLabel.TabIndex = 2;
            // 
            // CarSpecsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.UxSpecsLabel);
            this.Controls.Add(this.UxSpecTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarSpecsForm";
            this.Text = "Car Specifications";
            this.Load += new System.EventHandler(this.CarSpecsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UxSpecTitleLabel;
        private Label UxSpecsLabel;
    }
}