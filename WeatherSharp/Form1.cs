using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnSearchCity_Click(object sender, EventArgs e)
        {
            api = new API();
            string input = inputCity.Text;

            api.getCoords(input);
        
        }

    }
}
