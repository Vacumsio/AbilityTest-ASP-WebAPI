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
    public class ThirdPartyController : ControllerBase
    {
        public IActionResult ThirdPartyWeather()
        {
            return RedirectToAction("SecondaryLaunchWeather", "LaunchWeather");
        }
    }
}
