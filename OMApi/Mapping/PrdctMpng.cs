using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.PrdctDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class PrdctMpng : Profile
    {
        public PrdctMpng()
        {
            CreateMap<Product, RsltPrdctDto>().ReverseMap();
            CreateMap<Product, CrtPrdctDto>().ReverseMap();
            CreateMap<Product, GetPrdctDto>().ReverseMap();
            CreateMap<Product, UpdtPrdctDto>().ReverseMap();
            CreateMap<Product, RsltPrdctWthCtgry>().ReverseMap();

        }
    }
   
}
