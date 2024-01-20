using WeatherExerciseDependencyInjection.Interfaces;
using WeatherExerciseDependencyInjection.Models;

namespace WeatherExerciseDependencyInjection.DataLayer
{
    public class CityWeatherDAL
    {
        private List<ICityWeather> _cityWeatherData;
        public List<ICityWeather> CityWeatherData
        {
            get { return _cityWeatherData; }
        }

        public CityWeatherDAL()
        {

            _cityWeatherData = LoadWeatherData();
        }

        private List<ICityWeather> LoadWeatherData()
        {
            List<ICityWeather> data = new List<ICityWeather>() {
                 new CityWeather()
                {
                    CityName = "London",
                    CityUniqueCode = "LDN",
                    CurrentDateTime = Convert.ToDateTime("2030-01-01 8:00"),
                    Temperature = 33
                },
            new CityWeather()
            {
                CityName= "New York",
                CityUniqueCode="NYC",
                CurrentDateTime=Convert.ToDateTime("2030-01-01 3:00"),
                Temperature = 60
            },
            new CityWeather()
            {
                CityName= "Paris",
                CityUniqueCode="PAR",
                CurrentDateTime=Convert.ToDateTime("2030-01-01 9:00"),
                Temperature = 82
            },
             new CityWeather()
            {
                CityName= "Arizona",
                CityUniqueCode="AZI",
                CurrentDateTime=Convert.ToDateTime("2030-01-01 5:00"),
                Temperature = 102
            },
            new CityWeather()
            {
                CityName= "Charlotte",
                CityUniqueCode="CLT",
                CurrentDateTime=DateTime.Now,
                Temperature = 31
            }
        };
            return data;
        }
    }
}
