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
            this.UxJeepWranglerRadioButton = new System.Windows.Forms.RadioButton();
            this.UxCompassRadioButton = new System.Windows.Forms.RadioButton();
            this.UxRenegadeRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // UxJeepModelsLabel
            // 
            this.UxJeepModelsLabel.AutoSize = true;
            this.UxJeepModelsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxJeepModelsLabel.Location = new System.Drawing.Point(22, 24);
            this.UxJeepModelsLabel.Name = "UxJeepModelsLabel";
            this.UxJeepModelsLabel.Size = new System.Drawing.Size(171, 29);
            this.UxJeepModelsLabel.TabIndex = 1;
            this.UxJeepModelsLabel.Text = "Jeep Models:";
            // 
            // UxJeepWranglerRadioButton
            // 
            this.UxJeepWranglerRadioButton.AutoSize = true;
            this.UxJeepWranglerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxJeepWranglerRadioButton.Location = new System.Drawing.Point(22, 155);
            this.UxJeepWranglerRadioButton.Name = "UxJeepWranglerRadioButton";
            this.UxJeepWranglerRadioButton.Size = new System.Drawing.Size(113, 29);
            this.UxJeepWranglerRadioButton.TabIndex = 4;
            this.UxJeepWranglerRadioButton.Text = "Wrangler";
            this.UxJeepWranglerRadioButton.UseVisualStyleBackColor = true;
            this.UxJeepWranglerRadioButton.CheckedChanged += new System.EventHandler(this.UxJeepWranglerRadioButton_CheckedChanged);
            // 
            // UxCompassRadioButton
            // 
            this.UxCompassRadioButton.AutoSize = true;
            this.UxCompassRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxCompassRadioButton.Location = new System.Drawing.Point(22, 67);
            this.UxCompassRadioButton.Name = "UxCompassRadioButton";
            this.UxCompassRadioButton.Size = new System.Drawing.Size(117, 29);
            this.UxCompassRadioButton.TabIndex = 2;
            this.UxCompassRadioButton.Text = "Compass";
            this.UxCompassRadioButton.UseVisualStyleBackColor = true;
            this.UxCompassRadioButton.CheckedChanged += new System.EventHandler(this.UxCompassRadioButton_CheckedChanged);
            // 
            // UxRenegadeRadioButton
            // 
            this.UxRenegadeRadioButton.AutoSize = true;
            this.UxRenegadeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxRenegadeRadioButton.Location = new System.Drawing.Point(22, 111);
            this.UxRenegadeRadioButton.Name = "UxRenegadeRadioButton";
            this.UxRenegadeRadioButton.Size = new System.Drawing.Size(123, 29);
            this.UxRenegadeRadioButton.TabIndex = 3;
            this.UxRenegadeRadioButton.Text = "Renegade";
            this.UxRenegadeRadioButton.UseVisualStyleBackColor = true;
            this.UxRenegadeRadioButton.CheckedChanged += new System.EventHandler(this.UxRenegadeRadioButton_CheckedChanged);
            // 
            // CarDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 259);
            this.Controls.Add(this.UxRenegadeRadioButton);
            this.Controls.Add(this.UxCompassRadioButton);
            this.Controls.Add(this.UxJeepWranglerRadioButton);
            this.Controls.Add(this.UxJeepModelsLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarDealerForm";
            this.Text = "Car Dealer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label UxJeepModelsLabel;
        private RadioButton UxJeepWranglerRadioButton;
        private RadioButton UxCompassRadioButton;
        private RadioButton UxRenegadeRadioButton;
    }
}