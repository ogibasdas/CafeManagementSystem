using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.DscntDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class DscntMpng : Profile
    {
        public DscntMpng()
        {
            CreateMap<Discount, RsltDscntDto>().ReverseMap();
            CreateMap<Discount, CrtDscntDto>().ReverseMap();
            CreateMap<Discount, GetDscntDto>().ReverseMap();
            CreateMap<Discount, UpdtDscntDto>().ReverseMap();

        }
    }
    
}
