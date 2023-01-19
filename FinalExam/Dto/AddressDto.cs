using FinalExam.Entity;

namespace FinalExam.Dto
{
    public class AddressDto
    {
      public int UserId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string HouseNumber { get; set; }
    }
}
