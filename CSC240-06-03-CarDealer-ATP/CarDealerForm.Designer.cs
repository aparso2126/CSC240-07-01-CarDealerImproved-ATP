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
            this.viewSpecsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UxJeepModelsLabel
            // 
            this.UxJeepModelsLabel.AutoSize = true;
            this.UxJeepModelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepModelsLabel.Location = new System.Drawing.Point(123, 25);
            this.UxJeepModelsLabel.Name = "UxJeepModelsLabel";
            this.UxJeepModelsLabel.Size = new System.Drawing.Size(171, 29);
            this.UxJeepModelsLabel.TabIndex = 1;
            this.UxJeepModelsLabel.Text = "Jeep Models:";
            // 
            // jeepModelsComboBox
            // 
            this.jeepModelsComboBox.FormattingEnabled = true;
            this.jeepModelsComboBox.Location = new System.Drawing.Point(123, 74);
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
            this.carPictureBox.Location = new System.Drawing.Point(22, 192);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(427, 320);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 3;
            this.carPictureBox.TabStop = false;
            // 
            // viewSpecsButton
            // 
            this.viewSpecsButton.Location = new System.Drawing.Point(123, 108);
            this.viewSpecsButton.Name = "viewSpecsButton";
            this.viewSpecsButton.Size = new System.Drawing.Size(220, 33);
            this.viewSpecsButton.TabIndex = 4;
            this.viewSpecsButton.Text = "View Specs";
            this.viewSpecsButton.UseVisualStyleBackColor = true;
            // 
            // CarDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 524);
            this.Controls.Add(this.viewSpecsButton);
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
        private Button viewSpecsButton;
    }
}