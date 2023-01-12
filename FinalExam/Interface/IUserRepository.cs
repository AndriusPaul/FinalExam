using FinalExam.Dto;
using FinalExam.Entity;

namespace FinalExam.Interface
{
    public interface IUserRepository
    {
        List<User> GetAll();
        List<User> GetById(int id);
        User AddNewUser(UserDto user);
        User Delete(int id);
    }
}
