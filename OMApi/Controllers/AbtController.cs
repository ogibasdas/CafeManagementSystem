using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.AbtDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbtController : ControllerBase
    {
        private readonly IAboutService _aboutService;

       public AbtController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);

        }

        [HttpPost]

        public IActionResult CreateAbout(CrtAbtDto crtAbtDto)
        {
            About about = new About()
            {
                
                Title = crtAbtDto.Title,
                Description = crtAbtDto.Description,
                ImageUrl = crtAbtDto.ImageUrl
            };

            _aboutService.TAdd(about);
            return Ok("Hakkımda Kısmı Başarılı bir şekilde eklendi");

        }
    

        [HttpDelete]

        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda Kısmı Başarılı bir şekilde silindi");
        }

        [HttpPut]

        public IActionResult UpdateAbout(UpdtAbtDto updtAbtDto)
        {
            About about = new About()
            {
                Id = updtAbtDto.Id,
                Title = updtAbtDto.Title,
                Description = updtAbtDto.Description,
                ImageUrl = updtAbtDto.ImageUrl
            };

            _aboutService.TUpdate(about);
            return Ok("Hakkımda Kısmı Başarılı bir şekilde güncellendi");
        }

        [HttpGet("GetAbout")]
        
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            return Ok(value);
        }

    }
}


