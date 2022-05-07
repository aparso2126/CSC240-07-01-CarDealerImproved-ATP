using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_03_CarDealer_ATP
{
    public partial class CarSpecsForm : Form
    {
        string make = "";
        string model = "";
        public CarSpecsForm(String make, String model)
        {
            InitializeComponent();
            this.model = model;
            this.make = make;
        }

        private void CarSpecsForm_Load(object sender, EventArgs e)
        {
            if (make == "Jeep")
            {
                if (model == "Compass")
                {
                    UxModelPictureBox.ImageLocation = "https://www.jeep.com/mediaserver/iris?COSY-EU-100-1713uLDEMTV1r9s%25WBXaBKFmfKSLC9gIQALMc6UhVk3GBfM9IW2VRkr72kVTd9pVNwXGXQpMTV1rUp3g6OQCckPquBhS1U%25jzbTllxA0n2Cl%250QFmwFDkpd2rTBoM&&pov=fronthero&width=1000&height=460&bkgnd=white&resp=jpg&cut=&x=&y=&w=&h=";
                    UxMakeLabel.Text = make;
                    UxModelLabel.Text = model;
                    UxMSRPLabel.Text = "$26,390";
                    UxFuelTypeLabel.Text = "Regular Unleaded";
                    UxFuelTankLabel.Text = "13.5 gal";
                    UxFuelEconLabel.Text = "25 mpg";
                }
                if (model == "Renegade")
                {
                    UxModelPictureBox.ImageLocation = "https://www.jeep.com/mediaserver/iris?COSY-EU-100-1713uLDEMTV1r9s%25WBXaBKFmfKSLC9gIQALMc6UhVk3GBfM9IW2VRkr72kVTd9pMXwXGXQpMTV1rUp6g6OQCckPquBhS1U%25jzbTllxA01BCl%250QFmwFDkpd2ATBoM&&pov=fronthero&width=1000&height=460&bkgnd=white&resp=jpg&cut=&x=&y=&w=&h=";
                    UxMakeLabel.Text = make;
                    UxModelLabel.Text = model;
                    UxMSRPLabel.Text = "$24,195";
                    UxFuelTypeLabel.Text = "Premium Unleaded";
                    UxFuelTankLabel.Text = "12.7 gal";
                    UxFuelEconLabel.Text = "27 mpg";
                }
                if (model == "Wrangler")
                {
                    UxModelPictureBox.ImageLocation = "https://www.jeep.com/mediaserver/iris?COSY-EU-100-1713uLDEMTV1r9s%25WBXaBKFmfKSLC9gIQALMc6UhVk3GBfM9IW2VRkr72kVTd9pQswXGXQpMTV1rUp3g6OQCckPquBhS1U%25jzbTllxA0uvLl%250QFmwpikpd2LCBoM&&pov=fronthero&width=1000&height=460&bkgnd=white&resp=jpg&cut=&x=&y=&w=&h=";
                    UxMakeLabel.Text = make;
                    UxModelLabel.Text = model;
                    UxMSRPLabel.Text = "$33,595";
                    UxFuelTypeLabel.Text = "Regular Unleaded";
                    UxFuelTankLabel.Text = "21.5 gal";
                    UxFuelEconLabel.Text = "19 mpg";
                }
            }
        }
    }
}
