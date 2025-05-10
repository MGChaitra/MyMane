using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Model;
using My_Mane.Services;

namespace My_Mane.Controllers
{
    [Route("api/map")]
    [ApiController]
    [EnableCors("cors")]
    public class MapController : ControllerBase
    {
        private readonly MapService _mapService;

        public MapController()
        {
            _mapService = new MapService();
        }

        [HttpPost("geocode")]
        public async Task<IActionResult> GetCoordinates([FromBody] MapRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Address))
            {
                return BadRequest(new { error = "Invalid address!" });
            }

            var result = await _mapService.GetCoordinatesAsync(request.Address);

            if (result == null)
            {
                return BadRequest(new { error = "Unable to fetch coordinates" });
            }

            return Ok(result); // you can also return parsed JSON if needed
        }
    }
}
