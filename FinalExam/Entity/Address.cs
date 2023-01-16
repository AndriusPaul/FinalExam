using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Entity
{
    public class Address
    {
        [ForeignKey("Person")]
        public int Id { get; set; }    
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string HouseNumber { get; set; }     
        
        public virtual Person Person { get; set; }
    }
}
