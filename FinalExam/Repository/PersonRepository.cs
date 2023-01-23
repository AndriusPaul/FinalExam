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
            _context = context;
        }
        public Person GetById(int id)
        {
            return _context.Persons.FirstOrDefault(x => x.UserId == id);
        }
        public Person AddNewPerson(PersonDto person)
        {

            var newPerson = new Person
            {

                Name = person.Name,
                Surname = person.Surname,
                PersonalId = person.PersonalId,
                Phone = person.Phone,
                Email = person.Email,
                Image = person.Image,
                UserId = person.UserId
                

            };
            _context.Persons.Add(newPerson);
            _context.SaveChanges();
            return newPerson;
        }
        public Person UpdatePersonName(int id, string name)
        {
            var userToUpdate = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (userToUpdate == null) { return null; }
            userToUpdate.Name = name;
            _context.SaveChanges();
            return userToUpdate;

        }

        public Person UpdatePersonSurname(int id, string surname)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (user == null) { return null; }
            user.Surname = surname;
            _context.SaveChanges();
            return user;
        }
        public Person UpdatePersonPersonalId(int id, string personalId)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (user == null) { return null; }
            user.PersonalId = personalId;
            _context.SaveChanges();
            return user;
        }
        public Person UpdatePersonPhone(int id, string phone)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (user == null) { return null; }
            user.Phone = phone;
            _context.SaveChanges();
            return user;
        }

        public Person UpdatePersonEmail(int id, string email)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (user == null) { return null; }
            user.Email = email;
            _context.SaveChanges();
            return user;

        }
        public Person UpdatePersonImage(int id, byte[] image)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (user == null) { return null; }
            user.Image = image;
            _context.SaveChanges();
            return user;
        }

        public Person Delete(int userId)
        {
            var userToDelete =  _context.Persons.FirstOrDefault(x=>x.UserId == userId);
            _context.Remove(userToDelete);
            _context.SaveChanges();
            return userToDelete; 
        }
    }
}
