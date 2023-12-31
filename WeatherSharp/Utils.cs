﻿using System;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherSharp
{
    class Utils
    {
        public void addRegisters(Memory cities, string JSON){ /* Loops JSON elements and adds them to it's memory table */
            
            string city;
            float latitude;
            float longitude;
            /*int population;*/
            string countryCode;

            /* Getting the "results" array */
            dynamic data = JsonConvert.DeserializeObject(JSON);
            var results = data.results;

            foreach (var result in results)
            {       
                city = result.name;
                latitude = result.latitude;
                longitude = result.longitude;
                /*population = result.population;*/
                countryCode = result.country_code;

                cities.addCity(city, latitude, longitude, 0, getCountryNameByCode(countryCode));
            }
        }
        
        public string getCountryNameByCode(string code)
        {

            string countryName = "";
                    
            foreach (CultureInfo cultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo region = new RegionInfo(cultureInfo.Name);
               
                if (region.TwoLetterISORegionName.Equals(code, System.StringComparison.OrdinalIgnoreCase))
                {
                    countryName = region.EnglishName;
                    break;
                }

            }

            return countryName;
        }

        bool IsValidJson(string json)
        {
            try
            {
                JToken.Parse(json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}