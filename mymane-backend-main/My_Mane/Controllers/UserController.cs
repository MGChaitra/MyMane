using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using My_Mane.Contracts;
using My_Mane.Model;
namespace My_Mane.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    public class UserController : Controller
    {

        private readonly IRepository<UserInfo> _userRepository;

        public UserController(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserInfo>>> GetAllUsers()
        {
            return Ok(await _userRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserInfo>> GetUserById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpPost("register")]
        public async Task<ActionResult<UserInfo>> Register(UserInfo user)
        {
            if (user == null)
                return BadRequest("Invalid user data.");

            // Hash the password before storing
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            // First, save the user to get the generated ID
            var createdUser = await _userRepository.AddAsync(user);

            // Generate a unique UserInfoNumber using the assigned ID
            createdUser.UserInfoNumber = "U" + createdUser.Id;

            // Save again to update UserInfoNumber
            await _userRepository.UpdateAsync(createdUser.Id, createdUser);

            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var users = await _userRepository.GetAllAsync();
            var user = users.FirstOrDefault(u => u.Email == loginRequest.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.Password))
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }

            return Ok(new { message = "Login successful", user });
        }

        [HttpPost]
        public async Task<ActionResult<UserInfo>> CreateUser(UserInfo user)
        {
            var createdUser = await _userRepository.AddAsync(user);
            return CreatedAtAction(nameof(GetUserById), new { id = createdUser.Id }, createdUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserInfo user)
        {
            var updatedUser = await _userRepository.UpdateAsync(id, user);
            if (updatedUser == null) return NotFound();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deletedUser= await _userRepository.DeleteAsync(id);
            if (deletedUser==null) return NotFound();
            return Ok(deletedUser);
        }
        public class LoginRequest
        {
            public string Email { get; set; } = string.Empty;
            public string Password { get; set; }= string.Empty;
        }
    }
}
