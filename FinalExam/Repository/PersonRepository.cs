using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;

namespace FinalExam.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly Context _context;

        public PersonRepository(Context context)
        {
            _context= context;
        }
        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }
        public Person AddNewPerson(PersonDto person)
        {
            var newPerson = new Person
            {
                Name = person.Name,
                Surname= person.Surname,
                PhoneNumber= person.PhoneNumber,
                Email= person.Email,
                ProfilePicture= person.ProfilePicture,
                Address= person.Address
            };
            _context.Persons.Add(newPerson);
            return newPerson;
        }

        public Person UpdatePerson(int id, PersonDto person)
        {
            var personToUpadate = _context.Persons.Single(x=>x.Id== id);
            personToUpadate.Name= person.Name;
            personToUpadate.Surname= person.Surname;
            personToUpadate.PhoneNumber= person.PhoneNumber;
            personToUpadate.Email= person.Email;
            personToUpadate.ProfilePicture= person.ProfilePicture;
            personToUpadate.Address= person.Address;
            _context.SaveChanges();
            return personToUpadate;
        }
        public Person DeletePerson(int id)
        {
            var personToDelete = _context.Persons.SingleOrDefault(x => x.Id == id);
            _context.Remove(personToDelete);
            _context.SaveChanges();
            return personToDelete;
        }
    }
}
