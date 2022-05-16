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
            this.jeepModelsComboBox = new System.Windows.Forms.ComboBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.UxViewSpecsButton = new System.Windows.Forms.Button();
            this.UxModelTrimComboBox = new System.Windows.Forms.ComboBox();
            this.UxModelTrimLabel = new System.Windows.Forms.Label();
            this.UxJeepYearComboBox = new System.Windows.Forms.ComboBox();
            this.UxJeepYearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UxJeepModelsLabel
            // 
            this.UxJeepModelsLabel.AutoSize = true;
            this.UxJeepModelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepModelsLabel.Location = new System.Drawing.Point(22, 101);
            this.UxJeepModelsLabel.Name = "UxJeepModelsLabel";
            this.UxJeepModelsLabel.Size = new System.Drawing.Size(158, 29);
            this.UxJeepModelsLabel.TabIndex = 1;
            this.UxJeepModelsLabel.Text = "Jeep Model:";
            // 
            // jeepModelsComboBox
            // 
            this.jeepModelsComboBox.FormattingEnabled = true;
            this.jeepModelsComboBox.Location = new System.Drawing.Point(22, 142);
            this.jeepModelsComboBox.MaxDropDownItems = 10;
            this.jeepModelsComboBox.Name = "jeepModelsComboBox";
            this.jeepModelsComboBox.Size = new System.Drawing.Size(220, 28);
            this.jeepModelsComboBox.TabIndex = 2;
            this.jeepModelsComboBox.SelectedIndexChanged += new System.EventHandler(this.jeepModelsComboBox_SelectedIndexChanged);
            // 
            // carPictureBox
            // 
            this.carPictureBox.ImageLocation = "https://media.motorfuse.com/img.cfm/type/2/img/0E16CF4B4F698D85C6FDAAC6AC2D0A0CC0" +
    "EB75A63ABD5D74";
            this.carPictureBox.Location = new System.Drawing.Point(282, 12);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(427, 320);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 3;
            this.carPictureBox.TabStop = false;
            // 
            // UxViewSpecsButton
            // 
            this.UxViewSpecsButton.Location = new System.Drawing.Point(22, 299);
            this.UxViewSpecsButton.Name = "UxViewSpecsButton";
            this.UxViewSpecsButton.Size = new System.Drawing.Size(220, 33);
            this.UxViewSpecsButton.TabIndex = 4;
            this.UxViewSpecsButton.Text = "View Specs";
            this.UxViewSpecsButton.UseVisualStyleBackColor = true;
            this.UxViewSpecsButton.Click += new System.EventHandler(this.UxViewSpecsButton_Click);
            // 
            // UxModelTrimComboBox
            // 
            this.UxModelTrimComboBox.FormattingEnabled = true;
            this.UxModelTrimComboBox.Location = new System.Drawing.Point(22, 229);
            this.UxModelTrimComboBox.MaxDropDownItems = 10;
            this.UxModelTrimComboBox.Name = "UxModelTrimComboBox";
            this.UxModelTrimComboBox.Size = new System.Drawing.Size(220, 28);
            this.UxModelTrimComboBox.TabIndex = 6;
            this.UxModelTrimComboBox.SelectedIndexChanged += new System.EventHandler(this.UxModelTrimComboBox_SelectedIndexChanged);
            // 
            // UxModelTrimLabel
            // 
            this.UxModelTrimLabel.AutoSize = true;
            this.UxModelTrimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxModelTrimLabel.Location = new System.Drawing.Point(22, 188);
            this.UxModelTrimLabel.Name = "UxModelTrimLabel";
            this.UxModelTrimLabel.Size = new System.Drawing.Size(139, 29);
            this.UxModelTrimLabel.TabIndex = 5;
            this.UxModelTrimLabel.Text = "Jeep Trim:";
            // 
            // UxJeepYearComboBox
            // 
            this.UxJeepYearComboBox.FormattingEnabled = true;
            this.UxJeepYearComboBox.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.UxJeepYearComboBox.Location = new System.Drawing.Point(22, 66);
            this.UxJeepYearComboBox.MaxDropDownItems = 10;
            this.UxJeepYearComboBox.Name = "UxJeepYearComboBox";
            this.UxJeepYearComboBox.Size = new System.Drawing.Size(220, 28);
            this.UxJeepYearComboBox.TabIndex = 8;
            // 
            // UxJeepYearLabel
            // 
            this.UxJeepYearLabel.AutoSize = true;
            this.UxJeepYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepYearLabel.Location = new System.Drawing.Point(22, 25);
            this.UxJeepYearLabel.Name = "UxJeepYearLabel";
            this.UxJeepYearLabel.Size = new System.Drawing.Size(140, 29);
            this.UxJeepYearLabel.TabIndex = 7;
            this.UxJeepYearLabel.Text = "Jeep Year:";
            // 
            // CarDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 352);
            this.Controls.Add(this.UxJeepYearComboBox);
            this.Controls.Add(this.UxJeepYearLabel);
            this.Controls.Add(this.UxModelTrimComboBox);
            this.Controls.Add(this.UxModelTrimLabel);
            this.Controls.Add(this.UxViewSpecsButton);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.jeepModelsComboBox);
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
        private ComboBox jeepModelsComboBox;
        private PictureBox carPictureBox;
        private Button UxViewSpecsButton;
        private ComboBox UxModelTrimComboBox;
        private Label UxModelTrimLabel;
        private ComboBox UxJeepYearComboBox;
        private Label UxJeepYearLabel;
    }
}