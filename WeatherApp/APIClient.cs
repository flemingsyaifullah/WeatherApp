using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;

namespace WeatherApp
{
    public class APIClient : IAPIClient
    {
        [HttpPost]
        public string GetWeatherAPI(string cityName)
        {
            string weatherRootJson = null;
            string appId = "03946eb36056a631f9ca6e07198410fd";
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}", cityName, appId);

            using (WebClient client = new WebClient())
            {
                try
                {
                    weatherRootJson = client.DownloadString(url);
                }
                catch
                {
                    weatherRootJson = LoadOfflineJson();
                }
            }
            return weatherRootJson;
        }

        private string LoadOfflineJson()
        {
            string weatherRootJson = null;
            using (StreamReader r = new StreamReader("weatherOfflineData.json"))
            {
                weatherRootJson = r.ReadToEnd();
            }
            return weatherRootJson;
        }
    }
}
