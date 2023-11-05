using API_Hoteles.Models.DTO;
using AutoMapper;

namespace API_Hoteles.Models.DTO.Profiles
{
    public class HotelProfile : Profile
    {
        public HotelProfile()
        {
            CreateMap<Hotel, HotelDTO>();
            CreateMap<HotelDTO, Hotel>();
        }
    }
}
