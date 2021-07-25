using System;
using Xunit;
using WeatherApp;

namespace WeatherAppTest
{
    public class WeatherServiceTest
    {
        [Fact]
        public void ConvertKelvinToFahrenheitTest()
        {
            var weatherService = new WeatherService();
            Assert.Equal(60, weatherService.ConvertFahrenheitToCelcius(17));
        }

        [Fact]
        public void ConvertFahrenheitToCelciusTest()
        {
            var weatherService = new WeatherService();
            Assert.Equal(50, weatherService.ConvertFahrenheitToCelcius(15));
        }

        [Fact]
        public void GetWeatherWithNullParamTest()
        {
            var weatherService = new WeatherService();
            Assert.NotNull(weatherService.GetWeather(null));
        }

        [Fact]
        public void GetWeatherWithParamTest()
        {
            var weatherService = new WeatherService();
            Assert.NotNull(weatherService.GetWeather("London"));
        }
    }
}
