using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class CityService : ICityService
    {
        private IMockRepository _mockRepository;
        public CityService(IMockRepository mockRepository)
        {
            _mockRepository = mockRepository;
        }
        public IEnumerable<City> GetCity(string countryName)
        {
            
            if (countryName == "Indonesia")
            {
                return _mockRepository.IndonesiaCityData();
            }
            else if (countryName == "England")
            {
                return _mockRepository.EnglandCityData();
            }

            else if (countryName == "Malaysia")
            {
                return _mockRepository.MalaysiaCityData();
            }
            else
            {
                return null;
            }
        }
    }
}
