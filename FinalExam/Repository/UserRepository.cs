using FinalExam.Dto;
using FinalExam.Entity;
using FinalExam.Interface;

namespace FinalExam.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();
        public List<User> GetAll()
        {
            return _users;
        }
        public List<User> GetById(int id)
        {
            return _users.Where(x => x.Id == id).ToList();
        }
        public User AddNewUser(UserDto user)
        {
            var newUser = new User
            {
                Id = _users.Count == 0 ? 1 : _users.Max(x => x.Id) + 1,
                Name = user.UserName,
                Password = user.Password
            };
            _users.Add(newUser);
            return newUser;
        }
        public User Delete(int id)
        {
            var userToDelete = _users.Single(x => x.Id == id);
            _users.Remove(userToDelete);
            return userToDelete;
        }
    }
}
