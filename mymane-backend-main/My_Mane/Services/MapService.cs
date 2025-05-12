namespace My_Mane.Services
{
   public class MapService
{
    private readonly string _apiKey = "AIzaSyCXKK_9pfkZRQraB7HvadoCk_lDbsRcHys";
 
    public async Task<object> GetCoordinatesAsync(string address)
    {
        using (HttpClient client = new HttpClient())
        {
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={_apiKey}";
            var response = await client.GetAsync(url);
 
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
 
            var jsonString = await response.Content.ReadAsStringAsync();
            dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);
 
            if (json.status != "OK" || json.results.Count == 0)
                return null;
 
            var location = json.results[0].geometry.location;
            return new { lat = (double)location.lat, lng = (double)location.lng };
        }
    }
}
}
