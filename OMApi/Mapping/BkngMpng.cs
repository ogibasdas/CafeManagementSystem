using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.BkngDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class BkngMpng : Profile
    {
        public BkngMpng()
        {

            CreateMap<Booking, ResBkngDto>().ReverseMap();
            CreateMap<Booking, CrtBkngDto>().ReverseMap();
            CreateMap<Booking, GetBkngDto>().ReverseMap();
            CreateMap<Booking, UpdtBkngDto>().ReverseMap();


        }
    }
}
