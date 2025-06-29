using Microsoft.AspNetCore.Mvc;

namespace Mono.API.Controllers
{
    [ApiController]
    [Route("airplane")]
    public class AirplaneController : ControllerBase
    {
        [HttpGet("", Name = "GetAirplanes")]
        public IActionResult Get()
        {
            return Ok(new List<string> { "Boeing", "Airbus" });
        }
    }
}
