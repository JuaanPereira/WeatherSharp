using System.Collections.Generic;

namespace WeatherSharp
{
    class Cities /* Data management, MGMT is also a really cool band */
    {
        public List<CityData> cities = new List<CityData>();

        public class CityData
        {
            public string City { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public float Population { get; set; }
        }

        public void addCity(string city, double latitude, double longitude, float population)
        {
            cities.Add(new CityData
            {
                City = city,
                Latitude = latitude,
                Longitude = longitude,
                Population = population,
            });
        }

    }
}
