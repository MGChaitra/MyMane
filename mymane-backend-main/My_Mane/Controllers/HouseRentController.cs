using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;

namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class HouseRentController : Controller
    {
        private readonly IRepository<HouseRent> _houseRentRepository;

        public HouseRentController(IRepository<HouseRent> houseRentRepository)
        {
            _houseRentRepository = houseRentRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HouseRent>>> GetAllHouseRents()
        {
            return Ok(await _houseRentRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HouseRent>> GetHouseRentById(int id)
        {
            var house = await _houseRentRepository.GetByIdAsync(id);
            if (house == null) return NotFound();
            return Ok(house);
        }

        [HttpPost]
        public async Task<ActionResult<HouseRent>> CreateHouseRent(HouseRent house)
        {
            var createdHouseRent = await _houseRentRepository.AddAsync(house);
            return CreatedAtAction(nameof(GetHouseRentById), new { id = createdHouseRent.property_id }, createdHouseRent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHouseRent(int id, HouseRent house)
        {
            var updatedHouseRent = await _houseRentRepository.UpdateAsync(id, house);
            if (updatedHouseRent == null) return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHouseRent(int id)
        {
            var deletedHouserent = await _houseRentRepository.DeleteAsync(id);
            if (deletedHouserent == null) return NotFound();
            return Ok(deletedHouserent);
        }
    }
}

