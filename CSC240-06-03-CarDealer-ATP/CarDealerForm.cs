using System;
using Supremes;
/**************************************
 * Name:        Austin Parsons
 * Date:        2022-05-15
 * Description: An improved version of CarDealer from last week
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

        private void jeepModelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            jeepModelsComboBox.Items.Add("Test9");
        }
    }
}