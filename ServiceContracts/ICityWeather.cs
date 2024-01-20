
namespace WeatherExerciseDependencyInjection.Interfaces
{
    public interface ICityWeather
    {
        string? CityName { get; set; }
        string? CityUniqueCode { get; set; }
        DateTime? CurrentDateTime { get; set; }
        int Temperature { get; set; }
        string? TemperatureColor { get; set; }
    }
}