namespace My_Mane.Helper
{
    public class OtpHelper
    {
        public static string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Generates a 6-digit OTP
        }
    }
}
