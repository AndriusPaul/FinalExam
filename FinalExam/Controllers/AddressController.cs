using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _addressRepository;

        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        [HttpGet]

        public List<Address> GetByPersonId([FromQuery] int id)
        {
            return _addressRepository.GetByPersonId(id);
        }
        [HttpPost]

        public Address Add([FromQuery] int id, [FromBody] AddressDto address)
        {
            return _addressRepository.AddNewAddressById(id, address);
        }
        [HttpPut]
        public Address Update([FromQuery] int id, [FromBody] AddressDto address)
        {
            return _addressRepository.UpdateAddressById(id, address);
        }
        [HttpDelete]
        public Address Delete([FromQuery] int id)
        {
            return _addressRepository.Delete(id);
        }


    }
}
