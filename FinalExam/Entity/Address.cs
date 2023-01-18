using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string HouseNumber { get; set; }
        [ForeignKey("Person")]

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

    }
}
