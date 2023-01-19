using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("user")]
        public ActionResult<User> Get([FromQuery] string username)
        {
           User user=  _userRepository.Get(username);
            return user == null ? NotFound(): Ok(user);
        }
        [HttpGet]
        public ActionResult<User> Get([FromQuery] string username, [FromQuery] string password)
        {
            UserDto userDto = new UserDto { Password= password, Username= username };
            var user = _userRepository.Get(userDto);
            return user == null ? NotFound(): Ok(user);
        }
        [HttpPost]
        public User Add([FromBody] UserDto user)
        {
            return _userRepository.AddNewUser(user);
        }

        [HttpDelete]
        public User Delete([FromQuery] int id)
        {
            return _userRepository.Delete(id);
        }

    }
}
