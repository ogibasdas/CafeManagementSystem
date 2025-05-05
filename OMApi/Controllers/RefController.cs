using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.RefDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefController : ControllerBase
    {
        private readonly IReferenceService _referenceService;
        private readonly IMapper _mapper;

        public RefController(IReferenceService referenceService, IMapper mapper)
        {
            _referenceService = referenceService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ReferenceList()
        {
            var value = _mapper.Map<List<RsltRefDto>>(_referenceService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateReference(CrtRefDto crtRefDto)
        {
            _referenceService.TAdd(new Reference()
            {
                Name = crtRefDto.Name,
                Title = crtRefDto.Title,
                Comment = crtRefDto.Comment,
                ImageUrl = crtRefDto.ImageUrl,
                Status = crtRefDto.Status
            });
            return Ok("Referans Başarılı bir şekilde eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteReference(int id)
        {
            var value = _referenceService.TGetByID(id);
            _referenceService.TDelete(value);
            return Ok("Referans Başarılı bir şekilde silindi");
        }

        [HttpGet("GetReference")]

        public IActionResult GetReference(int id)
        {
            var value = _referenceService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateReference(UpdtRefDto updtRefDto)
        {
            _referenceService.TUpdate(new Reference()

            {
                Id = updtRefDto.Id,
                Name = updtRefDto.Name,
                Title = updtRefDto.Title,
                Comment = updtRefDto.Comment,
                ImageUrl = updtRefDto.ImageUrl,
                Status = updtRefDto.Status
            });
            
            return Ok("Referans Başarılı bir şekilde güncellendi");
        }



    }

}
