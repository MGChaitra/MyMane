using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;

using Microsoft.AspNetCore.Cors;

namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class BlogController : Controller
    {
        private readonly IRepository<Blogs> _blogRepository;

        public BlogController(IRepository<Blogs> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blogs>>> GetAllBlogs()
        {
            return Ok(await _blogRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Blogs>> GetBlogById(int id)
        {
            var blog = await _blogRepository.GetByIdAsync(id);
            if (blog == null) return NotFound();
            return Ok(blog);
        }

        [HttpPost]
        public async Task<ActionResult<Blogs>> CreateBlog(Blogs blog)
        {
            var createdBlog = await _blogRepository.AddAsync(blog);
            return CreatedAtAction(nameof(GetBlogById), new { id = createdBlog.Id }, createdBlog);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            var deletedBlog = await _blogRepository.DeleteAsync(id);
            if (deletedBlog == null) return NotFound();
            return Ok(deletedBlog);
        }
    }
}
