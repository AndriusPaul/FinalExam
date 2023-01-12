using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IAddressRepository
    {
        List<Address> GetByPersonId(int id);
        Address AddNewAddressById(int id, AddressDto address);
        Address UpdateAddressById(int id, AddressDto address);
        Address Delete(int id);
    }
}
