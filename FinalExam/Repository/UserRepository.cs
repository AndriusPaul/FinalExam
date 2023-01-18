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
        public List<User> GetById(int id)
        {
            return _context.Users.Where(x => x.Id == id).ToList();
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

        public User UpdateUser(int id, UserDto user)
        {
            var userToUpdate = _context.Users.FirstOrDefault(x => x.Id == id);
            if (userToUpdate == null)
            {

                return null;
            } 
                user.Password = user.Password;
                _context.SaveChanges();
                return userToUpdate;
            
        }
        public User Delete(int id)
        {
            var userToDelete = _context.Users.Single(x => x.Id == id);
            _context.Remove(userToDelete);
            return userToDelete;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetByUsername(string username)
        {
            return  _context.Users.FirstOrDefault(x => x.Username == username);
            
        }
    }
}
