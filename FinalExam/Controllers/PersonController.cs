using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository= personRepository;
        }
        [HttpGet]
        public List<Person> Get()
        {
            return _personRepository.GetAll();
        }
        [HttpPost]
        public Person Add([FromBody] PersonDto person)
        {
            return _personRepository.AddNewPerson(person);
        }
        [HttpPut]
        public Person Update([FromQuery] int id, [FromBody] PersonDto person)
        {
           return _personRepository.UpdatePerson(id, person);
        }
        [HttpDelete]
        public Person Delete([FromQuery] int id)
        {
            return _personRepository.DeletePerson(id);
        }
    }
}
