using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.SclMdaDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SclMdaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SclMdaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<RsltSclMdaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateSocialMedia(CrtSclMdaDto crtSclMdaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
                Icon = crtSclMdaDto.Icon,
                Title = crtSclMdaDto.Title,
                Url = crtSclMdaDto.Url,

            });
            return Ok("Sosyal Medya Başarılı bir şekilde eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya Başarılı bir şekilde silindi");
        }


        [HttpGet("GetSocialMedia")]

        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }


        [HttpPut]

        public IActionResult UpdateSocialMedia(UpdtSclMdaDto updtSclMdaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()

            {
                Id = updtSclMdaDto.Id,
                Icon = updtSclMdaDto.Icon,
                Title = updtSclMdaDto.Title,
                Url = updtSclMdaDto.Url,
            });

            return Ok("Sosyal Medya Başarılı bir şekilde güncellendi");
        }

    }
  
}

