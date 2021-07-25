using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private IWeatherService _weatherService;
        private ICountryService _countryService;
        private ICityService _cityService;  

        public WeatherController(IWeatherService wheaterService, ICountryService countryService, ICityService
            cityService)
        {
            _weatherService = wheaterService;
            _countryService = countryService;
            _cityService = cityService;
        }
        public IActionResult Index()
        {
            return View(GetCountry());
        }

        public IEnumerable<CountryViewModel> GetCountry()
        {
            IEnumerable<Country> countries = _countryService.GetCountry();
            IList<CountryViewModel> countryViewModels = new List<CountryViewModel>();
            foreach(Country country in countries)
            {
                countryViewModels.Add(new CountryViewModel(country));
            }
            return countryViewModels;
        }

        public IEnumerable<CityViewModel> GetCity(string countryName)
        {
            IEnumerable<City> cities = _cityService.GetCity(countryName);
            IList<CityViewModel> cityViewModels = new List<CityViewModel>();
            foreach (City city in cities)
            {
                cityViewModels.Add(new CityViewModel(city));
            }
            return cityViewModels;
        }

        public IActionResult List(string countryName)
        {
            return View(GetCity(countryName));
        }

        public string GetWeather(string cityName)
        {
            return _weatherService.GetWeather(cityName);
        }
    }
}
