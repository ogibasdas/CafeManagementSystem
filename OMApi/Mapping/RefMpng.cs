using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.RefDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class RefMpng : Profile
    {
        public RefMpng()
        {
            CreateMap<Reference, RsltRefDto>().ReverseMap();
            CreateMap<Reference, CrtRefDto>().ReverseMap();
            CreateMap<Reference, GetRefDto>().ReverseMap();
            CreateMap<Reference, UpdtRefDto>().ReverseMap();

        }
    }
   
}
