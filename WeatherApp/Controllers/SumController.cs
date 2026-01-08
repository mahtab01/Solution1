using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController : ControllerBase
    {
        // GET /sum?a=2&b=2
        [HttpGet]
        public ActionResult<string> Get([FromQuery] int? a, [FromQuery] int? b)
        {
            if (a is null || b is null)
            {
                return BadRequest("Please provide query parameters 'a' and 'b'. Example: /sum?a=2&b=2");
            }

            var sum = a.Value + b.Value;
            return Ok($"{a.Value}+{b.Value}={sum}");
        }


        
        [HttpPost("/multiplication")]
        public ActionResult<string> Post([FromQuery] int? a, [FromQuery] int? b)
        {
            if (a is null || b is null)
            {
                return BadRequest("Please provide query parameters 'a' and 'b'. Example: /multiplication?a=2&b=2");
            }

            var multiplication = a.Value * b.Value;
            return Ok($"{a.Value}*{b.Value}={multiplication}");
        }
    }
}
