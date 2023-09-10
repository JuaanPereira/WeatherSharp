using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherSharp
{
    class API
    {
        string URL = "https://api.open-meteo.com/v1/forecast"; /* Weather */
        string GEO_URL = "https://geocoding-api.open-meteo.com/v1/search"; /* Geolocations */

        HttpClient client;
        HttpResponseMessage response;
        public async Task<bool> testConnection()
        {
            bool isConnected;
            client = new HttpClient();
            response = await client.GetAsync("https://api.open-meteo.com/v1/forecast?latitude=42.2328&longitude=-8.7226&hourly=temperature_2m"); /* Await evita el bloqueo del programa mientras esta operación se ejecuta, el método debe ser asynchronous */

            if (response.IsSuccessStatusCode)
            {
                isConnected = true;

            }
            else {
                isConnected = false;
            }

            return isConnected;
        }

        public async Task<string> getCoords(string city)
        {

            client = new HttpClient();
            response = await client.GetAsync(GEO_URL+"?name="+city);
            
            string JSON = await response.Content.ReadAsStringAsync();

            return JSON;

        }
    }
}
