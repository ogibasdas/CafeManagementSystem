using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.FtrDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class FtrMpng : Profile
    {
        public FtrMpng()
        {
            CreateMap<Feature, RsltFtrDto>().ReverseMap();
            CreateMap<Feature, CrtFtrDto>().ReverseMap();
            CreateMap<Feature, GetFtrDto>().ReverseMap();
            CreateMap<Feature, UpdtFtrDto>().ReverseMap();

        }
    }
    
}
