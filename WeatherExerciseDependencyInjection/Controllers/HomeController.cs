using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Diagnostics.Eventing.Reader;
using WeatherExerciseDependencyInjection.Interfaces;
using WeatherExerciseDependencyInjection.Models;


namespace WeatherExerciseDependencyInjection.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherLogic _weatherLogic;
        private readonly IDougsTest _doug;
        public HomeController(IWeatherLogic weatherBll, IDougsTest doug)
        {
            _weatherLogic = weatherBll;
            _doug = doug;
            _doug.Name += "Home ";
            _doug.Count += 1;

            _doug.Description = "Born in the constructor of the Controller.";
        }

        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            ViewBag.Title = "Weather App";
            ViewBag.Doug = _doug.ToString();
            ViewBag.DougTime = _doug.GetCurrentDate();

            var viewData = _weatherLogic.GetWeatherData();
            return View(viewData);

        }


        [Route("/details/{citycode}")]
        public IActionResult Details(string cityCode)
        {
             ViewBag.Title = "Weather Details";
            if (cityCode != null)
            {
                ICityWeather? cityWeather = _weatherLogic.GetWeatherData().Where(w => w.CityUniqueCode == cityCode).FirstOrDefault();
                if (cityWeather == null)
                {
                    return BadRequest("Invalid City Code");
                }
                return View(cityWeather);
            }
            else
            {
                return BadRequest("Supply City Code");
            }

        }
        [Route("/get-weather/{citycode}")]
        public IActionResult GetWeather(string cityCode)
        {
            ViewBag.Title = "Weather Details";
            if (cityCode != null)
            {
                ICityWeather? cityWeather = _weatherLogic. GetWeatherData().Where(w => w.CityUniqueCode == cityCode).FirstOrDefault();
                if (cityWeather == null)
                {
                    return BadRequest("Invalid City Code");
                }
                return ViewComponent("Tile", cityWeather);
            }
            else
            {
                return BadRequest("Supply City Code");
            }

        }
    }
}
