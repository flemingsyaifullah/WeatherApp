using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class City
    {
        public string CityName { get; set; }
        public City(string cityName)
        {
            this.CityName = cityName;
        }
    }
}
