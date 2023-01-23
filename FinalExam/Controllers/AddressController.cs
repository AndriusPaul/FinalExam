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

        public ActionResult<Address> GetById([FromQuery] int id)
        {
            var userAddress = _addressRepository.GetById(id);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpPost]
        public ActionResult<Address> Add([FromBody] AddressDto address)
        {
            var userAddress = _addressRepository.AddNewAddress(address);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpPut("city")]
        public ActionResult<Address> UpdateCity([FromQuery] int id, [FromQuery] string city) {
            var userAddress = _addressRepository.UpdateCity(id, city);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpPut("street")]
        public ActionResult<Address> UpdateStreet([FromQuery] int id, [FromQuery] string street)
        {
            var userAddress = _addressRepository.UpdateStreet(id, street);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpPut("streetNumber")]
        public ActionResult<Address> UpdateStreetNumber([FromQuery] int id, [FromQuery] string streetNumber)
        {
            var userAddress = _addressRepository.UpdateStreetNumber(id, streetNumber);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpPut("houseNumber")]
        public ActionResult<Address> UpdateHouseNumber([FromQuery] int id, [FromQuery] string houseNumber)
        {
            var userAddress = _addressRepository.UpdateHouseNumber(id, houseNumber);
            return userAddress == null ? NotFound() : Ok(userAddress);
        }
        [HttpDelete("ByUserId")]
        public ActionResult<Address> Delete([FromQuery]int id) {
        var addressToDelete = _addressRepository.Delete(id);
            return addressToDelete== null ? NotFound() : Ok(addressToDelete);
        }

    }
}
