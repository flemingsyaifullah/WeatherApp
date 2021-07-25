using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class CityViewModel
    {
        [DisplayName("City Name")]
        public string CityName { get; set; }

        public CityViewModel(City city)
        {
            this.CityName = city.CityName;
        }
    }
}
