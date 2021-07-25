using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class MockRepository : IMockRepository
    {
        public IEnumerable<Country> CountryData()
        {
            IList<Country> countries = new List<Country>();
            countries.Add(new Country("England"));
            countries.Add(new Country("Indonesia"));
            countries.Add(new Country("Malaysia"));
            countries.Add(new Country("Australia"));
            return countries;

        }

        public IEnumerable<City> IndonesiaCityData()
        {
            IList<City> cities = new List<City>();
            cities.Add(new City("Jakarta"));
            cities.Add(new City("Surabaya"));
            cities.Add(new City("Bandung"));
            cities.Add(new City("Semarang"));

            return cities;
        }

        public IEnumerable<City> EnglandCityData()
        {
            IList<City> cities = new List<City>();
            cities.Add(new City("London"));
            cities.Add(new City("Manchester City"));
            cities.Add(new City("Stamford"));
            cities.Add(new City("Darlington"));

            return cities;
        }

        public IEnumerable<City> AustraliaCityData()
        {
            IList<City> cities = new List<City>();
            cities.Add(new City("Jakarta"));
            cities.Add(new City("Surabaya"));
            cities.Add(new City("Bandung"));
            cities.Add(new City("Semarang"));

            return cities;
        }

        public IEnumerable<City> MalaysiaCityData()
        {
            IList<City> cities = new List<City>();
            cities.Add(new City("Jakarta"));
            cities.Add(new City("Surabaya"));
            cities.Add(new City("Bandung"));
            cities.Add(new City("Semarang"));

            return cities;
        }
    }
}
