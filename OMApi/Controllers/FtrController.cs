using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.FtrDto;
using OM.Dto.RefDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FtrController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;


        public FtrController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }


        [HttpGet]

        public IActionResult FtrList()
        {
            var value = _mapper.Map<List<RsltFtrDto>>(_featureService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]


        public IActionResult CreateFtr(CrtFtrDto crtFtrDto)
        {
            _featureService.TAdd(new Feature()
            {
                Title1 = crtFtrDto.Title1,
                Title2 = crtFtrDto.Title2,
                Title3 = crtFtrDto.Title3,
                Description1 = crtFtrDto.Description1,
                Description2 = crtFtrDto.Description2,
                Description3 = crtFtrDto.Description3,
            });
            return Ok("Özellik Başarılı bir şekilde eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteFtr(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Özellik Başarılı bir şekilde silindi");
        }

        [HttpGet("GetFtr")]

        public IActionResult GetFtr(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateFtr(UpdtFtrDto updtFtrDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Id = updtFtrDto.Id,
                Title1 = updtFtrDto.Title1,
                Title2 = updtFtrDto.Title2,
                Title3 = updtFtrDto.Title3,
                Description1 = updtFtrDto.Description1,
                Description2 = updtFtrDto.Description2,
                Description3 = updtFtrDto.Description3
            });

            return Ok("Özellik Başarılı bir şekilde güncellendi");
        }

    }
}
