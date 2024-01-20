
using WeatherExerciseDependencyInjection.Interfaces;

namespace WeatherExerciseDependencyInjection.Services
{
    public class DougsTest : IDougsTest
    {
        public string InstanceId
        {
            get
            {
                return Guid.NewGuid().ToString();
            }
        }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime? GetCurrentDate()
        {
            return DateTime.Now;
        }
        public int Count { get; set; }
        public override string ToString()
        {
            string output = $"Id: {InstanceId} Count: {Count} Name: {Name} Description: {Description}";
            return output;
        }
    }
}
