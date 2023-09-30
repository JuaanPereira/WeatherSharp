using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace WeatherSharp
{
    public partial class Form1 : Form
    {
        API api = new API();
        public Form1()
        {
            InitializeComponent();
            responseBox.Hide();
        }

 
        private async void btnSearchCity_Click(object sender, EventArgs e)
        {
            string input = inputCity.Text;
            string result = await api.getCoords(input);
            responseBox.Text = result;

            Utils addRegisters = new Utils();
            Memory city = new Memory();

            addRegisters.addRegisters(city, result);

            citiesDataGrid.DataSource = city.cities;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewAPIRes.CheckState == CheckState.Checked)
            {
                responseBox.Show();
            }
            else
            {
                responseBox.Hide();
            }
        }

        private void btnChkOnMap_Click(object sender, EventArgs e)
        {
            /* We get the selected register on the data grid and feed the HTML viewer with it's google maps location */
            if (citiesDataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must select a SINGLE place you want to get the location for.");
            }
            else
            {
                string selectedLatString = citiesDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                string selectedLongString = citiesDataGrid.SelectedRows[0].Cells[2].Value.ToString();

                /* Parsing data into double to round them up to 6 decimals, then, recover them as strings to pass it to the URI */
                double.TryParse(selectedLatString, out double selectedLat);
                double.TryParse(selectedLongString, out double selectedLong);
                double roundedLat = Math.Round(selectedLat, 6);
                double roundedLong = Math.Round(selectedLong, 6);

                /* Back to string */
                string roundedLatString = roundedLat.ToString();
                string roundedLongString = roundedLong.ToString();

                string queryLastBit = roundedLatString.Replace(",", ".") + "," + roundedLongString.Replace(",", ".");
                string URILocation = "http://maps.google.com/maps?q=" + queryLastBit;
                HTMLViewer.Source = new Uri(URILocation);
            }

        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            if (citiesDataGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must select a SINGLE place you want to get the location for.");
            }
            else
            {
                double latitude = Math.Round(float.Parse(citiesDataGrid.SelectedRows[0].Cells[1].Value.ToString()), 2);
                double longitude = Math.Round(float.Parse(citiesDataGrid.SelectedRows[0].Cells[2].Value.ToString()), 2);
                string result = await api.getWeather(latitude, longitude);

                /* We get the weather data from the response, we don't need to deserialize it as we won't work on it as an object, we use JObject to
                access the values directly. */

                JArray JSON = JArray.Parse(result);

                /* Iterating over every element the array has */

                for (int i = 0; i < JSON.Count; i++)
                {
                    JObject jsonObject = (JObject)JSON[i];
                    var weatherObject = jsonObject["current_weather"];

                    responseBox.Text = weatherObject.ToString();

                    float temperature = (float)weatherObject["temperature"];


                }
            }
        }
    }
}
