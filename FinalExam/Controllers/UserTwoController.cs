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
        public async Task<IActionResult> Register([FromBody]UserDtoRegister request)
        {
            if (_context.Users.Any(u => u.Username == request.Username))
            {
                return BadRequest("Username already exists.");
            }
            var newUser = new User
            {
                Username = request.Username,
                Password = request.Password,
                Role = "user",
                Person = new Person
                {
                    UserId= _context.Users.Max(u => u.Id) == 0 ? 1 : _context.Users.Max(u => u.Id)+1,
                    Name = request.Person.Name,
                    Surname = request.Person.Surname,
                    PersonalId = request.Person.PersonalId,
                    Phone= request.Person.Phone,
                    Email= request.Person.Email,
                    Image= request.Person.Image,

                },
                Address = new Address
                {
                    UserId = _context.Users.Max(u => u.Id) == 0 ? 1 : _context.Users.Max(u => u.Id) + 1,
                    City = request.Address.City,
                    Street= request.Address.Street,
                    StreetNumber = request.Address.StreetNumber,
                    HouseNumber= request.Address.HouseNumber,
                },
 
            };
            _context.Add(newUser);
            _context.SaveChanges();
            return Ok("User succesfully created!");

        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromQuery]UserDtoLogin request)
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
        [HttpGet("allInfo")]
        public async Task<List<User>> GetAllUserInfo()
        {
            var records = await _context.Users.Select(x => new User()
            { Id = x.Id,
              Username = x.Username,
              Password= x.Password,
              Role= x.Role,
              Person = new Person()
              {
                  Name = x.Person.Name,
                  Surname= x.Person.Surname,
                  PersonalId= x.Person.PersonalId,
                  Phone= x.Person.Phone,
                  Email = x.Person.Email,
                  Image= x.Person.Image,
              },
              Address = new Address()
              {
                  City = x.Address.City,
                  Street= x.Address.Street,
                  StreetNumber= x.Address.StreetNumber,
                  HouseNumber= x.Address.HouseNumber,
              }
            
            }).ToListAsync();
            return records;
        }
        
    }
}
