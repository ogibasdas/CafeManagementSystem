using AutoMapper;
using OM.Dto.AbtDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class AbtMpng : Profile
    {
        public AbtMpng()

        {
            CreateMap<About, RsltAbtDto>().ReverseMap();
            CreateMap<About, CrtAbtDto>().ReverseMap();
            CreateMap<About, GetAbtDto>().ReverseMap();
            CreateMap<About, UpdtAbtDto>().ReverseMap();
            


        }
    }
}
