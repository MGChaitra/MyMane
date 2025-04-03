using System.Net.Mail;
using System.Net;
using My_Mane.Model;

namespace My_Mane.Services
{
    public class EmailService
    {
        private readonly string _smtpServer = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private readonly string _senderEmail = "nikhilbavkargaming@gmail.com";
        private readonly string _appPassword = "pkwp dobs avcd zwvk"; // Use app password

        public bool SendEmail(EmailRequest request, out string errorMessage)
        {
            try
            {
                SmtpClient smtp = new SmtpClient(_smtpServer, _smtpPort)
                {
                    Credentials = new NetworkCredential(_senderEmail, _appPassword),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage(_senderEmail, request.To)
                {
                    Subject = request.Subject,
                    Body = request.Message
                };

                smtp.Send(mail);
                errorMessage = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
