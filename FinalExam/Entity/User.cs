namespace FinalExam.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } 
        public string Role { get; set; }

        public virtual Person Person { get; set; }
    }
}
