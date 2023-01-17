using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IUserRepository
    {
        List<User> GetById(int id);
        User AddNewUser(UserDto user);
        User UpdateUser(int id, UserDto user);
        User Delete(int id);
    }
}
