using WeatherExerciseDependencyInjection.DataLayer;
using WeatherExerciseDependencyInjection.Interfaces;


namespace WeatherExerciseDependencyInjection.Services
{
    public class WeatherLogic : IWeatherLogic
    {
        private CityWeatherDAL? data = null;
        public WeatherLogic()
        {
            data = new CityWeatherDAL();
        }

        public List<ICityWeather> GetWeatherData()
        {
            if (data != null)
            {
                foreach (var item in data.CityWeatherData)
                {
                    item.TemperatureColor = GetColorByTemp(item.Temperature);
                }

                return data.CityWeatherData;
            }
            else
            {
                return new List<ICityWeather>();
            }
          
        }

        private string GetColorByTemp(int temp)
        {
            string tempColor = string.Empty;
            switch (temp)
            {
                case <= 40:
                    tempColor = "bg-coldest";
                    break;
                case <= 60:
                    tempColor = "bg-cold";
                    break;
                case <= 80:
                    tempColor = "bg-warm";
                    break;
                case <= 95:
                    tempColor = "bg-hot";
                    break;
                default:
                    tempColor = "bg-hotest";
                    break;
            }
            return tempColor;
        }
    }
}
