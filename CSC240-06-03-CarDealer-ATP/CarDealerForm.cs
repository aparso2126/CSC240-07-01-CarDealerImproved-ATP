/**************************************
 * Name:        Austin Parsons
 * Date:        2022-05-07
 * Description: A program that displays information about
 * different car models by using radio buttons
 * Assistance:
 *************************************/

namespace CSC240_07_01_CarDealerImproved_ATP
{
    public partial class CarDealerForm : Form
    {
        public CarDealerForm()
        {
            InitializeComponent();
        }

        private void UxCompassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UxCompassRadioButton.Checked)
            {
                CarSpecsForm carSpecsForm = new CarSpecsForm("Jeep","Compass");
                carSpecsForm.ShowDialog();
                UxCompassRadioButton.Checked = false;
            }
        }

        private void UxRenegadeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UxRenegadeRadioButton.Checked)
            {
                CarSpecsForm carSpecsForm = new CarSpecsForm("Jeep", "Renegade");
                carSpecsForm.ShowDialog();
                UxRenegadeRadioButton.Checked = false;
            }
        }

        private void UxJeepWranglerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UxJeepWranglerRadioButton.Checked)
            {
                CarSpecsForm carSpecsForm = new CarSpecsForm("Jeep", "Wrangler");
                carSpecsForm.ShowDialog();
                UxJeepWranglerRadioButton.Checked = false;
            }
        }
    }
}