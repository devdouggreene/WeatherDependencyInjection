using WeatherExerciseDependencyInjection.Interfaces;

namespace WeatherExerciseDependencyInjection.Models
{
    public class CityWeather :ICityWeather
    {

        public string? CityUniqueCode { get; set; }
        public string? CityName { get; set; }
        public DateTime? CurrentDateTime { get; set; }
        public int Temperature { get; set; }
        public string? TemperatureColor { get; set; }



    }
}
