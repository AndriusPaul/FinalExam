using System.ComponentModel.DataAnnotations;

namespace FinalExam.Dto
{
    public class UserDtoLogin
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
