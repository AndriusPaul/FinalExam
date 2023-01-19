using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IUserRepository
    {
        User Get(UserDto user);
        User Get(string username);
        User AddNewUser(UserDto user);
        User Delete(int id);
    }
}
