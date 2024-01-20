

namespace WeatherExerciseDependencyInjection.Interfaces
{
    public interface IWeatherLogic
    {
        List<ICityWeather> GetWeatherData();
    }
}