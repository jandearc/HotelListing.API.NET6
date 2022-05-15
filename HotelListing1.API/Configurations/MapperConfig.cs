using AutoMapper;
using HotelListing1.API.Data;
using HotelListing1.API.Models.Country;
using HotelListing1.API.Models.Hotel;

namespace HotelListing1.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
             
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
