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
        string URL = "";
        public CarSpecsForm(String URL)
        {
            InitializeComponent();
            this.URL = URL;
        }

        private void CarSpecsForm_Load(object sender, EventArgs e)
        {
            var timeoutInMilliseconds = 5000;
            var uri = new Uri(URL);
            var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);
            int specsCount = doc.GetElementsByClass("col-sm-5").ElementAt(1).GetElementsByClass("table").ElementAt(0).GetElementsByTag("tr").Count;

            for (int i = 0; i < specsCount; i++)
            {
                string specTitle = doc.GetElementsByClass("col-sm-5").ElementAt(1).GetElementsByClass("table").ElementAt(0).GetElementsByTag("tr").ElementAt(i).GetElementsByTag("td").ElementAt(0).Text;
                UxSpecTitleLabel.Text += specTitle + ":\n\n";
            }
            UxSpecTitleLabel.Text += "MPG City:\n\nMPG Hwy:";

            for (int i = 0; i < specsCount; i++)
            {
                string specValue = doc.GetElementsByClass("col-sm-5").ElementAt(1).GetElementsByClass("table").ElementAt(0).GetElementsByTag("tr").ElementAt(i).GetElementsByTag("td").ElementAt(1).Text;
                UxSpecsLabel.Text += specValue + "\n\n";
            }
            string mpgCity = doc.GetElementsByClass("well").ElementAt(0).GetElementsByTag("tr").ElementAt(0).GetElementsByTag("td").ElementAt(0).Text;
            string mpgHwy = doc.GetElementsByClass("well").ElementAt(0).GetElementsByTag("tr").ElementAt(0).GetElementsByTag("td").ElementAt(2).Text;
            UxSpecsLabel.Text += mpgCity + "\n\n" + mpgHwy;

            UxSpecsLabel.Location = new Point(UxSpecTitleLabel.Location.X + UxSpecTitleLabel.Size.Width + 20,UxSpecsLabel.Location.Y);
            this.Height = UxSpecTitleLabel.Size.Height + 80;
            this.Width = UxSpecsLabel.Location.X + UxSpecsLabel.Size.Width + 30;
        }
    }
}
