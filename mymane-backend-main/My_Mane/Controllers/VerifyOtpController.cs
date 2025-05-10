using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using My_Mane.Model;

namespace My_Mane.Controllers
{
    public class VerifyOtpController : Controller
    {
        private readonly IMemoryCache _cache;  

       
        public VerifyOtpController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpPost("verify-otp")]
        public IActionResult VerifyOtp([FromBody] OtpVerificationRequest request)
        {
            var storedOtp = _cache.Get<string>(request.PhoneNumber); // Retrieve OTP from cache

            if (storedOtp != null && storedOtp == request.Otp)
            {
                return Ok(new { Message = "OTP verified successfully" });
            }
            return BadRequest(new { Message = "Invalid OTP" });
        }

    }
}
