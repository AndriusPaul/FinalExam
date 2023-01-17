using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IAddressRepository
    {
        Address GetById(int id);
        Address AddNewAddress(AddressDto address);
        Address UpdateCity(int id, string city);
        Address UpdateStreet(int id, string street);
        Address UpdateStreetNumber (int id, string streetNumber);
        Address UpdateHouseNumber(int id, string houseNumber );
     
    }
}
