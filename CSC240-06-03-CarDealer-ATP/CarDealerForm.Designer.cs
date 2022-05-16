namespace CSC240_07_01_CarDealerImproved_ATP
{
    partial class CarDealerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxJeepModelsLabel = new System.Windows.Forms.Label();
            this.UxJeepModelsComboBox = new System.Windows.Forms.ComboBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.UxJeepTrimComboBox = new System.Windows.Forms.ComboBox();
            this.UxModelTrimLabel = new System.Windows.Forms.Label();
            this.UxJeepYearComboBox = new System.Windows.Forms.ComboBox();
            this.UxJeepYearLabel = new System.Windows.Forms.Label();
            this.UxViewSpecsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UxJeepModelsLabel
            // 
            this.UxJeepModelsLabel.AutoSize = true;
            this.UxJeepModelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepModelsLabel.ForeColor = System.Drawing.Color.Red;
            this.UxJeepModelsLabel.Location = new System.Drawing.Point(23, 22);
            this.UxJeepModelsLabel.Name = "UxJeepModelsLabel";
            this.UxJeepModelsLabel.Size = new System.Drawing.Size(158, 29);
            this.UxJeepModelsLabel.TabIndex = 1;
            this.UxJeepModelsLabel.Text = "Jeep Model:";
            // 
            // UxJeepModelsComboBox
            // 
            this.UxJeepModelsComboBox.BackColor = System.Drawing.Color.Black;
            this.UxJeepModelsComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepModelsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UxJeepModelsComboBox.FormattingEnabled = true;
            this.UxJeepModelsComboBox.Location = new System.Drawing.Point(23, 54);
            this.UxJeepModelsComboBox.MaxDropDownItems = 10;
            this.UxJeepModelsComboBox.Name = "UxJeepModelsComboBox";
            this.UxJeepModelsComboBox.Size = new System.Drawing.Size(321, 28);
            this.UxJeepModelsComboBox.TabIndex = 2;
            this.UxJeepModelsComboBox.SelectedIndexChanged += new System.EventHandler(this.jeepModelsComboBox_SelectedIndexChanged);
            // 
            // carPictureBox
            // 
            this.carPictureBox.BackColor = System.Drawing.Color.White;
            this.carPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPictureBox.ImageLocation = "https://media.motorfuse.com/img.cfm/type/2/img/0E16CF4B4F698D85C6FDAAC6AC2D0A0CC0" +
    "EB75A63ABD5D74";
            this.carPictureBox.Location = new System.Drawing.Point(363, 12);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(427, 322);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 3;
            this.carPictureBox.TabStop = false;
            // 
            // UxJeepTrimComboBox
            // 
            this.UxJeepTrimComboBox.BackColor = System.Drawing.Color.Black;
            this.UxJeepTrimComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepTrimComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UxJeepTrimComboBox.FormattingEnabled = true;
            this.UxJeepTrimComboBox.Location = new System.Drawing.Point(24, 198);
            this.UxJeepTrimComboBox.MaxDropDownItems = 10;
            this.UxJeepTrimComboBox.Name = "UxJeepTrimComboBox";
            this.UxJeepTrimComboBox.Size = new System.Drawing.Size(321, 28);
            this.UxJeepTrimComboBox.TabIndex = 6;
            // 
            // UxModelTrimLabel
            // 
            this.UxModelTrimLabel.AutoSize = true;
            this.UxModelTrimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxModelTrimLabel.ForeColor = System.Drawing.Color.Red;
            this.UxModelTrimLabel.Location = new System.Drawing.Point(24, 166);
            this.UxModelTrimLabel.Name = "UxModelTrimLabel";
            this.UxModelTrimLabel.Size = new System.Drawing.Size(139, 29);
            this.UxModelTrimLabel.TabIndex = 5;
            this.UxModelTrimLabel.Text = "Jeep Trim:";
            // 
            // UxJeepYearComboBox
            // 
            this.UxJeepYearComboBox.BackColor = System.Drawing.Color.Black;
            this.UxJeepYearComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepYearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UxJeepYearComboBox.FormattingEnabled = true;
            this.UxJeepYearComboBox.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.UxJeepYearComboBox.Location = new System.Drawing.Point(23, 126);
            this.UxJeepYearComboBox.MaxDropDownItems = 10;
            this.UxJeepYearComboBox.Name = "UxJeepYearComboBox";
            this.UxJeepYearComboBox.Size = new System.Drawing.Size(321, 28);
            this.UxJeepYearComboBox.TabIndex = 8;
            this.UxJeepYearComboBox.SelectedIndexChanged += new System.EventHandler(this.UxJeepYearComboBox_SelectedIndexChanged);
            // 
            // UxJeepYearLabel
            // 
            this.UxJeepYearLabel.AutoSize = true;
            this.UxJeepYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepYearLabel.ForeColor = System.Drawing.Color.Red;
            this.UxJeepYearLabel.Location = new System.Drawing.Point(23, 94);
            this.UxJeepYearLabel.Name = "UxJeepYearLabel";
            this.UxJeepYearLabel.Size = new System.Drawing.Size(140, 29);
            this.UxJeepYearLabel.TabIndex = 7;
            this.UxJeepYearLabel.Text = "Jeep Year:";
            // 
            // UxViewSpecsButton
            // 
            this.UxViewSpecsButton.BackColor = System.Drawing.Color.Black;
            this.UxViewSpecsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxViewSpecsButton.ForeColor = System.Drawing.Color.Red;
            this.UxViewSpecsButton.Location = new System.Drawing.Point(23, 277);
            this.UxViewSpecsButton.Name = "UxViewSpecsButton";
            this.UxViewSpecsButton.Size = new System.Drawing.Size(322, 57);
            this.UxViewSpecsButton.TabIndex = 9;
            this.UxViewSpecsButton.Text = "View Specs";
            this.UxViewSpecsButton.UseVisualStyleBackColor = false;
            this.UxViewSpecsButton.Click += new System.EventHandler(this.UxViewSpecsButton_Click_1);
            // 
            // CarDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(802, 351);
            this.Controls.Add(this.UxViewSpecsButton);
            this.Controls.Add(this.UxJeepYearComboBox);
            this.Controls.Add(this.UxJeepYearLabel);
            this.Controls.Add(this.UxJeepTrimComboBox);
            this.Controls.Add(this.UxModelTrimLabel);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.UxJeepModelsComboBox);
            this.Controls.Add(this.UxJeepModelsLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarDealerForm";
            this.Text = "Car Dealer";
            this.Load += new System.EventHandler(this.CarDealerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UxJeepModelsLabel;
        private ComboBox UxJeepModelsComboBox;
        private PictureBox carPictureBox;
        private ComboBox UxJeepTrimComboBox;
        private Label UxModelTrimLabel;
        private ComboBox UxJeepYearComboBox;
        private Label UxJeepYearLabel;
        private Button UxViewSpecsButton;
    }
}