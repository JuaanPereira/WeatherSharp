using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WeatherSharp
{
    public partial class Form1 : Form
    {
        API api;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTestApi_clicked(object sender, EventArgs e)
        {

            api = new API();
            bool API_OK = await api.testConnection();

            if (API_OK)
            {
                txtAPIOK.Text = "Works";
            }
            else {
                txtAPIOK.Text = "Doesn't work tbh";
            }
        }
        private async void btnSearchCity_Click(object sender, EventArgs e)
        {
            api = new API();
            string input = inputCity.Text;
            
            string result = await api.getCoords(input);

            responseBox.Text = result;
            
            /*------- CODE SECTION TO PARSE THE JSON --------*/

            // Parse the JSON data
            JObject json = JObject.Parse(result);

            // Access the "results" array and its first element
            JToken parsedJSON = json["results"][0];

            // Retrieve values for the specified keys
            string name = (string)parsedJSON["name"];
            double latitude = (double)parsedJSON["latitude"];
            double longitude = (double)parsedJSON["longitude"];

            /* Creamos nuevo objeto para añadir la ciudad buscada... */
            Cities CityData = new Cities();
            CityData.addCity(name, latitude, longitude, 0);

            // Bind the data to the DataGridView
            dataGridView1.DataSource = CityData.cities;
        }
    }
}
