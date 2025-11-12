
using Microsoft.AspNetCore.Mvc;
using TripHelperS.Models;

namespace TripHelperS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteController : ControllerBase
    {

        [HttpPost("add")]
        public IActionResult AddFavoriteLocation([FromBody] LocationModel location)
        {
            if (location == null || string.IsNullOrWhiteSpace(location.address) || string.IsNullOrWhiteSpace(location.name))
                return BadRequest("유효하지 않은 요청입니다.");

            // 예시: DB에 추가하거나, 로그 출력
            Console.WriteLine($"[POST] {location.name}, {location.address}, Favorite={location.isFavorite}");

            // 클라이언트에 응답
            return Ok(new
            {
                message = "등록 완료",
                data = location
            });
        }
    }
}
