using System;
using System.Windows.Forms;

namespace WeatherSharp
{
    public partial class Form1 : Form
    {
        API api;
        public Form1()
        {
            InitializeComponent();
            responseBox.Hide();
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
            
            Utils addRegisters = new Utils();
            Cities city = new Cities();

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
    }
}
