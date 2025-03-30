using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;
namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class PropertyController : ControllerBase
    {
        private readonly IRepository<Property> _propertyRepository;

        public PropertyController(IRepository<Property> propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Property>>> GetAllProperties()
        {
            return Ok(await _propertyRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetPropertyById(int id)
        {
            var property = await _propertyRepository.GetByIdAsync(id);
            if (property == null) return NotFound();
            return Ok(property);
        }

        [HttpPost]
        public async Task<ActionResult<Property>> CreateProperty(Property property)
        {
            var createdProperty = await _propertyRepository.AddAsync(property);
            return CreatedAtAction(nameof(GetPropertyById), new { id = createdProperty.property_id }, createdProperty);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProperty(int id, Property property)
        {
            var updatedProperty = await _propertyRepository.UpdateAsync(id, property);
            if (updatedProperty == null) return NotFound();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var deletedProperty = await _propertyRepository.DeleteAsync(id);
            if (deletedProperty == null) return NotFound();
            return Ok(deletedProperty);
        }
    }
}
