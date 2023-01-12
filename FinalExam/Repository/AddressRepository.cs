using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;
using Microsoft.Extensions.Logging.Abstractions;

namespace FinalExam.Repository
{
    public class AddressRepository : IAddressRepository

    {
        private readonly Context _context;

        public AddressRepository(Context context)
        {
            _context = context;
        }

        public List<Address> GetByPersonId(int id)
        {
            return _context.Addresses.Where(x => x.Id == id).ToList();
        }
        public Address AddNewAddressById(int id, AddressDto address)
        {
            var newAddress = _context.Addresses.Single(x => x.Id == id);
            newAddress.City = address.City;
            newAddress.Street = address.Street;
            newAddress.StreetNumber = address.StreetNumber;
            newAddress.HouseNumber = address.HouseNumber;

            _context.Addresses.Add(newAddress);
            return newAddress;
        }

        public Address UpdateAddressById(int id, AddressDto address)
        {
            var addressToUpdate = _context.Addresses.Single(x=>x.Id == id);
            addressToUpdate.City = address.City;
            addressToUpdate.Street = address.Street;
            addressToUpdate.StreetNumber = address.StreetNumber;
            addressToUpdate.HouseNumber = address.HouseNumber;

            return addressToUpdate;
        }
        public Address Delete(int id)
        {
            var AddressToDelete = _context.Addresses.Single(x=>x.Id == id);
            _context.Addresses.Remove(AddressToDelete);
            return AddressToDelete;
        }



        
    }
}
