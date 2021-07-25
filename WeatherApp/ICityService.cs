using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public interface ICityService
    {
        IEnumerable<City> GetCity(string countryname);
    }
}
