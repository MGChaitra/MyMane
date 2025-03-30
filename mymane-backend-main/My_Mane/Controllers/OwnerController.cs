using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;

namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class OwnerController : Controller
    {
        private readonly IRepository<Owners> _ownerRepository;

        public OwnerController(IRepository<Owners> ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Owners>>> GetAllOwners()
        {
            return Ok(await _ownerRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Owners>> GetOwnerById(int id)
        {
            var owner = await _ownerRepository.GetByIdAsync(id);
            if (owner == null) return NotFound();
            return Ok(owner);
        }

        [HttpPost]
        public async Task<ActionResult<Owners>> CreateOwner(Owners owner)
        {
            var createdOwner = await _ownerRepository.AddAsync(owner);
            return CreatedAtAction(nameof(GetOwnerById), new { id = createdOwner.owner_id }, createdOwner);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOwner(int id, Owners owner)
        {
            var updatedOwner = await _ownerRepository.UpdateAsync(id, owner);
            if (updatedOwner == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner(int id)
        {
            var deletedOwner = await _ownerRepository.DeleteAsync(id);
            if (deletedOwner == null) return NotFound();
            return Ok(deletedOwner);
        }
    }
}
