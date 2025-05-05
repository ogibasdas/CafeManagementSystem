using AutoMapper;
using OM.Dto.AbtDto;
using OM.Dto.SclMdaDto;
using OM.Entity.Entities;

namespace OMApi.Mapping
{
    public class SclMdaMpng : Profile
    {
        public SclMdaMpng()
        {

            CreateMap<SocialMedia, RsltSclMdaDto>().ReverseMap();
            CreateMap<SocialMedia, CrtSclMdaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSclMdaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdtSclMdaDto>().ReverseMap();

        }
    }

}
