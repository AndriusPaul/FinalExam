using FinalExam.Dto;
using FinalExam.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserTwoController : ControllerBase
    {
        private readonly Context _context;
        public UserTwoController(Context context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto request)
        {
            if (_context.Users.Any(u => u.Username == request.Username))
            {
                return BadRequest("Username already exists.");
            };
            var newUser = new User
            {
                Username = request.Username,
                Password = request.Password,
                Role = "user",
            };
            _context.Add(newUser);
            _context.SaveChanges();
            return Ok("User succesfully created!");

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDtoLogin request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u=>u.Username == request.Username);
            if(user == null)
            {
                return BadRequest("User not found.");
            }

            if(request.Password != user.Password)
            {
                return BadRequest("Password incorrect.");
            }
            return Ok($"Login succesfully. Welcome {user.Username} !");
        }
    }
}
