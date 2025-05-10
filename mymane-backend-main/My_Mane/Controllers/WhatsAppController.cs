using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using My_Mane.Helper;
using My_Mane.Model;
using My_Mane.Services;

namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhatsAppController : Controller
    {
        private readonly IMemoryCache _cache;

        public WhatsAppController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpPost("send-otp")]
        public async Task<IActionResult> SendOtp([FromBody] OtpRequest request)
        {
            string otp = OtpHelper.GenerateOtp();

            // Store OTP in memory cache (expires in 5 minutes)
            _cache.Set(request.PhoneNumber, otp, TimeSpan.FromMinutes(5));

            var response = await WhatsAppService.SendOtp(request.PhoneNumber, otp);
            return Ok(new { Message = "OTP sent successfully", Response = response });
        }
    }
}
