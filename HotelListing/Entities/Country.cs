using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ShortName { get; set; }
    }

}
