using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        Person AddNewPerson(PersonDto person);
        Person UpdatePerson(int id, PersonDto person);
        Person DeletePerson(int id);
    }
}
