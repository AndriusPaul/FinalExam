using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;


namespace FinalExam.Repository
{
    public class AddressRepository : IAddressRepository

    {
        private readonly Context _context;

        public AddressRepository(Context context)
        {
            _context = context;
        }

        public Address GetById(int id)
        {
            return _context.Addresses.FirstOrDefault(x => x.UserId == id);
            
        }
        public Address AddNewAddress(AddressDto address)
        {
            var newAddress = new Address
            {
                
                City = address.City,
                Street = address.Street,
                StreetNumber = address.StreetNumber,
                HouseNumber = address.HouseNumber,
                UserId = _context.Users.Max(x => x.Id),
            };

            _context.Addresses.Add(newAddress);
            _context.SaveChanges();
            return newAddress;
        }
 

        public Address UpdateStreet(int id, string street)
        {
            var userAddress = _context.Addresses.FirstOrDefault(x=>x.Id == id);
            if (userAddress == null) { return null; }
            userAddress.Street = street;
            _context.SaveChanges();
            return userAddress;
        }

        public Address UpdateStreetNumber(int id, string streetNumber)
        {
            var userAddress = _context.Addresses.FirstOrDefault(x=>x.Id ==id);
            if (userAddress == null) { return null; }
            userAddress.StreetNumber = streetNumber;
            _context.SaveChanges();
            return userAddress;
        }

        public Address UpdateHouseNumber(int id, string houseNumber)
        {
            var userAddress = _context.Addresses.FirstOrDefault(x=>x.Id == id);
            if (userAddress == null) { return null; }
            userAddress.HouseNumber = houseNumber;
            _context.SaveChanges();
            return userAddress;
        }

        public Address UpdateCity(int id, string city)
        {
            var userAddress = _context.Addresses.FirstOrDefault(x => x.Id == id);
            if (userAddress == null) { return null; }
            userAddress.City= city;
            _context.SaveChanges();
            return userAddress;
        }
    }
}
