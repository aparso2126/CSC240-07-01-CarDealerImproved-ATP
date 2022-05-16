using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supremes;

namespace CSC240_07_01_CarDealerImproved_ATP
{
    public partial class CarSpecsForm : Form
    {
        string URL = "https://www.globalautomall.com/vehicles.cfm/make/jeep/model/grand-cherokee-wk/year/2022/level/400919328/";
        public CarSpecsForm(String URL)
        {
            InitializeComponent();
            this.URL = URL;
        }
    }
}
