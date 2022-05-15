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
            // jeepModelsComboBox
            // 
            this.jeepModelsComboBox.FormattingEnabled = true;
            this.jeepModelsComboBox.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.jeepModelsComboBox.Location = new System.Drawing.Point(22, 73);
            this.jeepModelsComboBox.MaxDropDownItems = 10;
            this.jeepModelsComboBox.Name = "jeepModelsComboBox";
            this.jeepModelsComboBox.Size = new System.Drawing.Size(311, 28);
            this.jeepModelsComboBox.TabIndex = 2;
            this.jeepModelsComboBox.SelectedIndexChanged += new System.EventHandler(this.jeepModelsComboBox_SelectedIndexChanged);
            // 
            // CarDealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 229);
            this.Controls.Add(this.jeepModelsComboBox);
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
        private ComboBox jeepModelsComboBox;
    }
}