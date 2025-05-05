using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.CtgryDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class CtgryMpng :Profile
    {
        public CtgryMpng()
        {
            CreateMap<Category, RsltCtgryDto>().ReverseMap();
            CreateMap<Category, CrtCtgryDto>().ReverseMap();
            CreateMap<Category, GetCtgryDto>().ReverseMap();
            CreateMap<Category, UpdtCtgryDto>().ReverseMap();

        }
    }
}
