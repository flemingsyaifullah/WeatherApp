using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class CountryService : ICountryService
    {
        private IMockRepository _mockRepository;

        public CountryService(IMockRepository mockRepository)
        {
            _mockRepository = mockRepository;
        }
        public IEnumerable<Country> GetCountry()
        {
            return _mockRepository.CountryData();

        }
    }
}
