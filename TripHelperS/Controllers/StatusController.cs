using Microsoft.AspNetCore.Mvc;

namespace TripHelperS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetServerTime()
        {
            DateTime now = DateTime.Now;

            var response = new
            {
                serverTime = now.ToString("yyyy-MM-dd HH:mm:ss"),
                timeZone = TimeZoneInfo.Local.StandardName
            };

            return Ok(response);
        }

        [HttpGet("utc")]
        public IActionResult GetUtcTime()
        {
            var utcNow = DateTime.UtcNow;

            return Ok(new
            {
                serverTimeUtc = utcNow.ToString("yyyy-MM-dd HH:mm:ss"),
                timeZone = "UTC"
            });
        }
    }
}
