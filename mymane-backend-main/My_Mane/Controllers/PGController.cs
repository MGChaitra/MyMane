using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;

namespace My_Mane.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class PGController : Controller
    {
        private readonly IRepository<PG> _pgRepository;

        public PGController(IRepository<PG> pgRepository)
        {
            _pgRepository = pgRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PG>>> GetAllPGs()
        {
            return Ok(await _pgRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PG>> GetPGById(int id)
        {
            var pg = await _pgRepository.GetByIdAsync(id);
            if (pg == null) return NotFound();
            return Ok(pg);
        }

        [HttpPost]
        public async Task<ActionResult<PG>> CreatePG(PG pg)
        {
            var createdPg = await _pgRepository.AddAsync(pg);
            return CreatedAtAction(nameof(GetPGById), new { id = createdPg.property_id }, createdPg);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePG(int id, PG pg)
        {
            var updatedPg = await _pgRepository.UpdateAsync(id, pg);
            if (updatedPg == null) return NotFound();
            return NoContent();
        }
       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePG(int id)
        {
            var deletedpg = await _pgRepository.DeleteAsync(id);
            if (deletedpg == null) return NotFound();
            return Ok(deletedpg);
        }
    }
}