using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WeatherApp.Models.WeatherViewModel;

namespace WeatherApp
{
    public interface IWeatherService
    {
         string GetWeather(string cityName);
    }
}
