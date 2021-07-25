using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class CountryViewModel
    {
        [DisplayName("Country Name")]
        public string CountryName { get; set; }

        public CountryViewModel(Country country)
        {
            this.CountryName = country.CountryName;
        }
    }
}
