using FinalExam.Entity;
using Microsoft.EntityFrameworkCore;

namespace FinalExam
{
    public class Context :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public Context(DbContextOptions<Context> option): base(option) { }
    }
}
