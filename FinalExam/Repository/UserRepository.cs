using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;

namespace FinalExam.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public List<User> GetById(int id)
        {
            return _context.Users.Where(x => x.Id == id).ToList();
        }
        public User AddNewUser(UserDto user)
        {
            var newUser = new User
            {
                //Id = _context.Users.Count == 0 ? 1 : _users.Max(x => x.Id) + 1,
                Name = user.UserName,
                Password = user.Password
            };
            _context.Add(newUser);
            return newUser;
        }
        public User Delete(int id)
        {
            var userToDelete = _context.Users.Single(x => x.Id == id);
            _context.Remove(userToDelete);
            return userToDelete;
        }
    }
}
