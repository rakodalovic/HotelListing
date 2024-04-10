using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Entities
{
    public class Hotel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Address { get; set; } = string.Empty;
        public double Rating { get; set; }

        //[ForeignKey(nameof(Country))]
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
