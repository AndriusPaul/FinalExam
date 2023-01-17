using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IPersonRepository
    {
        Person GetById(int id);
        Person AddNewPerson(PersonDto person);
        Person UpdatePersonName(int id, string name);
        Person UpdatePersonSurname(int id, string surname);
        Person UpdatePersonPersonalId(int id, string personalId);
        Person UpdatePersonPhone(int id, string phone);
        Person UpdatePersonEmail(int id, string email);
        Person UpdatePersonImage(int id, byte[] image);


    }
}
