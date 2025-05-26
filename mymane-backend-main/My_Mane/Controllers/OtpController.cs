using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;
using Newtonsoft.Json;
using System.Text;

namespace My_Mane.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OtpController : ControllerBase
    {
        private readonly IOtpService _otpService;

        public OtpController(IOtpService otpService)
        {
            _otpService = otpService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendOtp([FromBody] OtpRequest request)
        {
            var response = await _otpService.SendOtpAsync(request.Phone, request.Name);
            return Ok(new { status = "sent", aisensyResponse = response });
        }

        [HttpPost("verify")]
        public IActionResult VerifyOtp([FromBody] VerifyOtpRequest request)
        {
            bool isVerified = _otpService.VerifyOtp(request.Phone, request.Otp);

            if (isVerified)
                return Ok(new { verified = true });

            return BadRequest(new { verified = false, message = "Invalid or expired OTP" });
        }
    }

}
