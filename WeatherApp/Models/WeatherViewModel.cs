using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherViewModel
    {

        public string City { get; set; }
        public string Country { get; set; }
        public string Sky { get; set; }
        public string Humidity { get; set; }
        
        public string Temp { get; set; }
        public string TempInCelcius { get; set; }
        public string TempInFahrenheit { get; set; }

        public string WeatherDateTime { get; set; }

        public string Wind { get; set; }
        public string Visibility { get; set; }
        public string Pressure { get; set; }
        public string DewPoint { get; set; }

    }
}
