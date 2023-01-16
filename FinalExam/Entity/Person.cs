using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entity
{
    public class Person
    {

        [ForeignKey("User")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string Address { get; set; }

        public virtual User User { get; set; }
        public virtual  Address Address2 { get; set; }
    }
}
