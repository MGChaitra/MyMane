namespace My_Mane.Services
{
    public class MapService
    {
        private readonly string _apiKey = "AIzaSyCXKK_9pfkZRQraB7HvadoCk_lDbsRcHys"; // Move to appsettings in real apps

        public async Task<string> GetCoordinatesAsync(string address)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={_apiKey}";
                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }
    }
}
