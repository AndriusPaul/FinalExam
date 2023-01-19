using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }
        public User AddNewUser(UserDto user)
        {
            var newUser = new User
            {

                Username = user.Username,
                Password = user.Password,
                Role = "user",
                
            };
            _context.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public User Delete(int id)
        {
            var userToDelete = _context.Users.Single(x => x.Id == id);
            _context.Remove(userToDelete);
            return userToDelete;
        }

        public User Get(UserDto data)
        {
           User user = _context.Users.FirstOrDefault(x => (x.Username == data.Username && x.Password == data.Password));
            if (user == null)
                return null;
            return user;
        }

        public User Get(string username)
        {
            return  _context.Users.FirstOrDefault(x => x.Username == username);

        }

    }
}
