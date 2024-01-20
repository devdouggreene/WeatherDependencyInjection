
namespace WeatherExerciseDependencyInjection.Interfaces
{
    public interface IDougsTest
    {
        string? Description { get; set; }
        string InstanceId { get; }
        string? Name { get; set; }
        int Count { get; set; }
        DateTime? GetCurrentDate();
        string ToString();
    }
}