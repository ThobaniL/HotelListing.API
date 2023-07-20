using HotelListing.API.Models.Country;

namespace HotelListing.API.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }        

        public int CountryId { get; set; }
    }
}