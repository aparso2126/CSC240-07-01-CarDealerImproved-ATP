/**************************************
 * Name:        Austin Parsons
 * Date:        2022-05-07
 * Description: A program that displays information about
 * different car models by using radio buttons
 * Assistance:
 *************************************/

namespace CSC240_06_03_CarDealer_ATP
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
            }
        }
    }
}