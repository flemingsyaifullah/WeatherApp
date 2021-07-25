using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public interface IMockRepository
    {
        IEnumerable<Country> CountryData();
        IEnumerable<City> IndonesiaCityData();
        IEnumerable<City> MalaysiaCityData();
        IEnumerable<City> AustraliaCityData();
        IEnumerable<City> EnglandCityData();
    }
}
