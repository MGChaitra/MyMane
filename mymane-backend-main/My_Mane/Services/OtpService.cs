using System.Text.Json;
using System.Text;
using My_Mane.Contracts;
using My_Mane.Model;
using Newtonsoft.Json;

namespace My_Mane.Services
{
    public class OtpService : IOtpService
    {
        private readonly HttpClient _client;
        private readonly string _apiKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjY4MWY5NjgyZDM5YzhkMDM5MDZjNWIxYiIsIm5hbWUiOiJNeU1hbmUiLCJhcHBOYW1lIjoiQWlTZW5zeSIsImNsaWVudElkIjoiNjgxZjk2NmNkMzljOGQwMzkwNmM1YTMyIiwiYWN0aXZlUGxhbiI6IkZSRUVfRk9SRVZFUiIsImlhdCI6MTc0NjkwMDYxMH0.410O5KQf691XcljmXCSFOKHH-2qQdvCSACl8aOEyQA4";
        private readonly string _whatsappSource = "your_whatsapp_number";

        public OtpService(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> SendOtpAsync(string phone, string name)
        {
            var otp = new Random().Next(100000, 999999).ToString();

            // Store OTP in-memory
            OtpStore.OtpData[phone] = otp;

            var payload = new
            {
                to = "91" + phone,
                type = "template",
                template_name = "otp_template_name",
                @params = new[] { name, otp },
                source = _whatsappSource,
                api_key = _apiKey
            };

            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("https://backend.aisensy.com/campaign/message", content);
            return await response.Content.ReadAsStringAsync();
        }

        public bool VerifyOtp(string phone, string otp)
        {
            if (OtpStore.OtpData.TryGetValue(phone, out var storedOtp))
            {
                if (storedOtp == otp)
                {
                    OtpStore.OtpData.Remove(phone);
                    return true;
                }
            }
            return false;
        }
    }
}
