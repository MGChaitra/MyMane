using System.Text.Json;
using System.Text;

namespace My_Mane.Services
{
    public class WhatsAppService
    {
        private const string AccessToken = "EACK0Q53oGSoBOwP8OrrftWcXEO2gHZAnlUIbgsqK0sejRL0ifyxqFsa93JBKOsrUTsAqWnaytcb2jolxNkoUVgsbVhqTp0ZAZA4ZAZA5hNwj3qAsCchi7qIntazoPrELT5Ubhjqm3u9oiENmMSXMnyZAqiegDlFYaHmjMZCHbh5WBoJlb7yZBktbqO7ZCX411SBfZCnF2ajE63eBeX5YflvZATMpCTgnRlkDSmAAMgZD";
        private const string PhoneNumberId = "605832622614273";
        private const string WhatsAppApiUrl = "https://graph.facebook.com/v22.0/";

        public static async Task<string> SendOtp(string phoneNumber, string otp)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {AccessToken}");

            var payload = new
            {
                messaging_product = "whatsapp",
                to = phoneNumber,
                type = "text",
                text = new { body = $"Your OTP code is: {otp}" }
            };

            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://graph.facebook.com/v22.0/605832622614273/messages", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
