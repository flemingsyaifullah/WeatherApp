using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;
using static WeatherApp.Models.WeatherViewModel;
using static WeatherApp.WeatherObject;

namespace WeatherApp
{
    public class WeatherService : IWeatherService
    {
        private IAPIClient _apiClient;

        public WeatherService(IAPIClient apiClient)
        {
            _apiClient = apiClient;
        }

        public WeatherService()
        {

        }
        public string GetWeather(string cityName)
        {
            string weatherRootJson = _apiClient.GetWeatherAPI(cityName);

            WeatherRoot weatherRoot = JsonConvert.DeserializeObject<WeatherRoot>(weatherRootJson);

            WeatherViewModel viewModel = new WeatherViewModel();

            viewModel.Country = weatherRoot.sys.country;
            viewModel.City = weatherRoot.name;
            viewModel.WeatherDateTime = DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            viewModel.Wind = Convert.ToString(weatherRoot.wind.speed) + " meter/sec";
            viewModel.Visibility = Convert.ToString(weatherRoot.visibility) + " meter";
            viewModel.Sky = weatherRoot.weather[0].description;

            viewModel.Temp = Convert.ToString(weatherRoot.main.temp);

            double tempFahrenheit = ConvertKelvinToFahrenheit(weatherRoot.main.temp);
            viewModel.TempInFahrenheit = Convert.ToString(RoundUp(tempFahrenheit, 2)) + " °F";

            double tempCelcius = ConvertFahrenheitToCelcius(tempFahrenheit);
            viewModel.TempInCelcius = Convert.ToString(RoundUp(tempCelcius, 2)) + " °C";

            viewModel.DewPoint = Convert.ToString(RoundUp(tempCelcius, 2)) + " °C";
            viewModel.Humidity = Convert.ToString(weatherRoot.main.humidity) + " %";
            viewModel.Pressure = Convert.ToString(weatherRoot.main.pressure) + " hPa";


            var weatherViewModelJson = JsonConvert.SerializeObject(viewModel, Formatting.Indented);

            return weatherViewModelJson;
        }

        //formula
        public double ConvertKelvinToFahrenheit(double tempKelvin)
        {
            double tempFahrenheit;
            tempFahrenheit = ((tempKelvin - 273.15) * 9 / 5) + 32;
            return tempFahrenheit;
        }

        public double ConvertFahrenheitToCelcius(double tempFahrenheit)
        {
            double tempCelcius;
            tempCelcius = (tempFahrenheit - 32) * 5 / 9;
            return tempCelcius;
        }

        public double RoundUp(double input, int places)
        {
            double multiplier = Math.Pow(10, Convert.ToDouble(places));
            return Math.Ceiling(input * multiplier) / multiplier;
        }
    }
}
