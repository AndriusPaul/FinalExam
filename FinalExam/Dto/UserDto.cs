using System.ComponentModel.DataAnnotations;

namespace FinalExam.Dto
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters!")]
        public string Password { get; set; } = string.Empty;
        public UserDto(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
