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
            string currentIndex = jeepModelsComboBox.SelectedIndex.ToString();
            var timeoutInMilliseconds = 5000;
            var uri = new Uri("https://www.globalautomall.com/vehicles.cfm/make/jeep/");
            var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);
            string modelURL = "https://www.globalautomall.com" + doc.GetElementsByClass("col-sm-9").ElementAt(Int32.Parse(currentIndex)).GetElementsByTag("a").ElementAt(0).Attr("href");

            if (currentIndex == "4") {
                carPictureBox.ImageLocation = "https://media.motorfuse.com/img.cfm/type/2/img/0E16CC4049698D85C6FDAAC6AC2D0A0CC0EB71D23ABD5D74";
                return;
            }

            carPictureBox.ImageLocation = getCarImage(modelURL);
        }

        private void CarDealerForm_Load(object sender, EventArgs e)
        {
            var timeoutInMilliseconds = 5000;
            var uri = new Uri("https://www.globalautomall.com/vehicles.cfm/make/jeep/");
            var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);

            // <span itemprop="ratingValue">86</span>
            var modelCount = doc.GetElementsByClass("col-sm-9").Count;

            for (int i = 0; i < modelCount; i += 1)
            {
                string modelStr = doc.GetElementsByClass("col-sm-9").ElementAt(i).GetElementsByClass("notranslate").ElementAt(0).Text.Substring(5);
                jeepModelsComboBox.Items.Add(modelStr);
            }
            jeepModelsComboBox.SelectedIndex = 0;
        }

        private static string getCarImage(string URL)
        {
            var timeoutInMilliseconds = 5000;
            var uri = new Uri(URL);
            var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);

            int imageIndex = doc.GetElementsByClass("row").ElementAt(1).GetElementsByClass("col-sm-3").Count()-1;
            string imageSrc = doc.GetElementsByClass("row").ElementAt(1).GetElementsByClass("col-sm-3").ElementAt(imageIndex).GetElementsByTag("img").ElementAt(0).Attr("data-src");
            return imageSrc;
        }
    }
}