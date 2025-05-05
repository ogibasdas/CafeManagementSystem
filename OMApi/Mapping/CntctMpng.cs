using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.CntctDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class CntctMpng : Profile
    {
        public CntctMpng()
        {

            CreateMap<Contact, RsltCntctDto>().ReverseMap();
            CreateMap<Contact, CrtCntctDto>().ReverseMap();
            CreateMap<Contact, GetCntctDto>().ReverseMap();
            CreateMap<Contact, UpdtCntctDto>().ReverseMap();

        }
    }
}
