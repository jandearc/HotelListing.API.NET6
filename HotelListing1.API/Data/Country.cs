using System.ComponentModel.DataAnnotations;

namespace HotelListing1.API.Data
{
    public class Country
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual IList <Hotel> Hotels { get; set; }

    }
}