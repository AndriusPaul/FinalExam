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
        [HttpGet]
        public List<User> Get()
        {
            return _userRepository.GetAll();
        }
        [HttpGet("id")]
        public List<User> GetById(int id)
        {
            return _userRepository.GetById(id);
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
