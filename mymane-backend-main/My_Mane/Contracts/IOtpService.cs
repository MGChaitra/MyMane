namespace My_Mane.Contracts
{
    public interface IOtpService
    {
        Task<string> SendOtpAsync(string phone, string name);
        bool VerifyOtp(string phone, string otp);
    }
}
