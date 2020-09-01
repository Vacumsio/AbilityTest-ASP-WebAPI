using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbilityTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchWeatherController : ControllerBase
    {

        public IActionResult SecondaryLaunchWeather()
        {
            return RedirectToAction("Get", "WeatherForecast");
        }
    }
}
