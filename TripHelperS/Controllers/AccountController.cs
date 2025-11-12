using Microsoft.AspNetCore.Mvc;
using TripHelperS.Models;

namespace TripHelperS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost("signin")]
        public IActionResult GetSignInResult([FromBody] SignModel format)
        {
            if(format == null || string.IsNullOrWhiteSpace(format.userId) || string.IsNullOrWhiteSpace(format.userPw))
            {
                return BadRequest("유효하지 않은 접근입니다.");
            }

            return Ok(new {
                message = "인증 완료",
                data = format
            });
        }


        [HttpPost("signup")]
        public IActionResult GetSignUpResult([FromBody] SignModel format)
        {
            if (format == null || string.IsNullOrWhiteSpace(format.userId) || string.IsNullOrWhiteSpace(format.userPw))
            {
                return BadRequest("유효하지 않은 접근입니다.");
            }

            return Ok(new
            {
                message = "가입 완료",
                data = format
            });
        }
    }
}
