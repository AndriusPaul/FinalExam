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
        public ActionResult<Person> GetById([FromQuery] int id)
        {
            var person = _personRepository.GetById(id);
            return person == null ? NotFound() : Ok(person);
        }
        [HttpPost]
        public ActionResult<Person> Add([FromBody] PersonDto person)
        {
            var newPerson = _personRepository.AddNewPerson(person);
            return newPerson== null ? NotFound() : Ok(newPerson);
        }
        [HttpPut("name")]
        public ActionResult<Person> UpdateName([FromQuery] int id, [FromQuery] string name)
        {
            var person = _personRepository.UpdatePersonName(id, name);
            return person == null ? NotFound() : Ok(person);
        }
        [HttpPut("surname")]
        public ActionResult<Person> UpdateSurname([FromQuery] int id, [FromQuery] string surname)
        {
            var person = _personRepository.UpdatePersonSurname(id, surname);
            return person == null ? NotFound() : Ok(person);
        }
        [HttpPut("personalId")]
        public ActionResult<Person> UpdatePersonalId([FromQuery] int id, [FromQuery] string personalId)
        {
            var person = _personRepository.UpdatePersonPersonalId(id, personalId);
            return person == null ? NotFound() : Ok(person);
        }
        [HttpPut("phone")]
        public ActionResult<Person> UpdatePhone([FromQuery] int id, [FromQuery] string phone)
        {
            var person = _personRepository.UpdatePersonPhone(id, phone);
            return person == null ? NotFound() : Ok(person);
        }
        [HttpPut("email")]
        public ActionResult<Person> UpdateEmail([FromQuery] int id, [FromQuery] string email)
        {
            var person = _personRepository.UpdatePersonEmail(id, email);
            return person == null ? NotFound() : Ok(person);
        }
        [HttpPut("image")]
public ActionResult<Person> UpdateImage([FromQuery]int id, [FromQuery] byte[] image)
        {
            var person = _personRepository.UpdatePersonImage(id, image);
            return person == null ? NotFound() : Ok(person);
        }
    }
}
