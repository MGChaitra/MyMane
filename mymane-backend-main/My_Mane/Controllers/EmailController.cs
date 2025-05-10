using Microsoft.AspNetCore.Mvc;
using My_Mane.Model;
using My_Mane.Services;

namespace My_Mane.Controllers
{
    [Route("api/email")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly EmailService _emailService;

        public EmailController()
        {
            _emailService = new EmailService();
        }

        [HttpPost("send")]
        public IActionResult SendEmail([FromBody] EmailRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.To))
            {
                return BadRequest(new { error = "Invalid email request!" });
            }

            string errorMessage;
            bool isSent = _emailService.SendEmail(request, out errorMessage);

            if (isSent)
                return Ok(new { message = "Email sent successfully!" });
            else
                return BadRequest(new { error = errorMessage });
        }
    }
}
