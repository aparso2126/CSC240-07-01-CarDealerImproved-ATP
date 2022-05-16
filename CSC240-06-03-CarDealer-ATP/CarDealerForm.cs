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
            string currentIndex = UxJeepModelsComboBox.SelectedIndex.ToString();
            var timeoutInMilliseconds = 5000;
            var uri = new Uri("https://www.globalautomall.com/vehicles.cfm/make/jeep/");
            var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);
            string modelURL = "https://www.globalautomall.com" + doc.GetElementsByClass("col-sm-9").ElementAt(Int32.Parse(currentIndex)).GetElementsByTag("a").ElementAt(0).Attr("href");

            if (currentIndex == "4") {
                carPictureBox.ImageLocation = "https://media.motorfuse.com/img.cfm/type/2/img/0E16CC4049698D85C6FDAAC6AC2D0A0CC0EB71D23ABD5D74";
            }
            else
            {
                carPictureBox.ImageLocation = getCarImage(modelURL);
            }

            UxJeepYearComboBox.Items.Clear();
            var uri2 = new Uri(modelURL);
            var doc2 = Supremes.Dcsoup.Parse(uri2, timeoutInMilliseconds);
            int availableYearsCount = doc2.GetElementsByClass("col-sm-9").Count;

            for (int i = 0; i < availableYearsCount; i++)
            {
                string year = doc2.GetElementsByClass("col-sm-9").ElementAt(i).GetElementsByTag("h4").ElementAt(0).Text.Substring(0,4);
                UxJeepYearComboBox.Items.Add(year);
            }
            UxJeepYearComboBox.SelectedIndex = 0;

            UxJeepTrimComboBox.Items.Clear();
            var uri3 = new Uri(modelURL);
            var doc3 = Supremes.Dcsoup.Parse(uri3, timeoutInMilliseconds);
            int trimOptionsCount = doc3.GetElementsByClass("col-sm-9").ElementAt(UxJeepYearComboBox.SelectedIndex).GetElementsByClass("list-group").ElementAt(0).GetElementsByClass("list-group-item").Count;
            
            for(int i = 0; i < trimOptionsCount; i++)
            {
                string trimOption = doc3.GetElementsByClass("col-sm-9").ElementAt(UxJeepYearComboBox.SelectedIndex).GetElementsByClass("list-group").ElementAt(0).GetElementsByClass("list-group-item").ElementAt(i).GetElementsByClass("sTrim").ElementAt(0).Text;
                UxJeepTrimComboBox.Items.Add(trimOption.Substring(trimOption.IndexOf(UxJeepModelsComboBox.Text)+UxJeepModelsComboBox.Text.Length+1));
            }
            UxJeepTrimComboBox.SelectedIndex = 0;
        }

        private void CarDealerForm_Load(object sender, EventArgs e)
        {
            var timeoutInMilliseconds = 5000;
            var uri = new Uri("https://www.globalautomall.com/vehicles.cfm/make/jeep/");
            var doc = Supremes.Dcsoup.Parse(uri, timeoutInMilliseconds);

            var modelCount = doc.GetElementsByClass("col-sm-9").Count;

            for (int i = 0; i < modelCount; i += 1)
            {
                string modelStr = doc.GetElementsByClass("col-sm-9").ElementAt(i).GetElementsByClass("notranslate").ElementAt(0).Text.Substring(5);
                UxJeepModelsComboBox.Items.Add(modelStr);
            }

            UxJeepModelsComboBox.SelectedIndex = 0;
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

        private void UxViewSpecsButton_Click_1(object sender, EventArgs e)
        {
            CarSpecsForm carSpecsForm = new CarSpecsForm("https://www.globalautomall.com/vehicles.cfm/make/jeep/model/cherokee/year/2021/level/400912497/");
            carSpecsForm.ShowDialog();
        }
    }
}