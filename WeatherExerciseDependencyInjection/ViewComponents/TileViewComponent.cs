using Microsoft.AspNetCore.Mvc;
using WeatherExerciseDependencyInjection.Interfaces;
using WeatherExerciseDependencyInjection.Models;

namespace WeatherExerciseDependencyInjection.Presentation.Components
{
    public class TileViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(CityWeather cityWeather)
        {
            return View(cityWeather);
        }
    }
}
