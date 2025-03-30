using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;

namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class CommercialRentLeaseController : Controller
    {
        private readonly IRepository<CommercialRentLease> _rentLeaseRepository;

        public CommercialRentLeaseController(IRepository<CommercialRentLease> rentLeaseRepository)
        {
            _rentLeaseRepository = rentLeaseRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommercialRentLease>>> GetAllRentLeases()
        {
            return Ok(await _rentLeaseRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CommercialRentLease>> GetRentLeaseById(int id)
        {
            var rentLease = await _rentLeaseRepository.GetByIdAsync(id);
            if (rentLease == null) return NotFound();
            return Ok(rentLease);
        }

        [HttpPost]
        public async Task<ActionResult<CommercialRentLease>> CreateRentLease(CommercialRentLease rentLease)
        {
            var createdRentLease = await _rentLeaseRepository.AddAsync(rentLease);
            return CreatedAtAction(nameof(GetRentLeaseById), new { id = createdRentLease.property_id }, createdRentLease);
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRentLease(int id)
        {
            var deletedPg = await _rentLeaseRepository.DeleteAsync(id);
            if (deletedPg == null) return NotFound();
            return Ok(deletedPg);
        }
    }
}
