using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.DscntDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DscntController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DscntController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<RsltDscntDto>>(_discountService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateDiscount(CrtDscntDto crtDscntDto)
        {
            _discountService.TAdd(new Discount()
            {
                
                Title = crtDscntDto.Title,
                Amount = crtDscntDto.Amount,
                Description = crtDscntDto.Description,
                ImageUrl = crtDscntDto.ImageUrl
            });
            return Ok("İndirim infosu eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim Silindi");
        }

        [HttpGet("GetDiscount")]

        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateDiscount(UpdtDscntDto updtDscntDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Id = updtDscntDto.Id,
                Title = updtDscntDto.Title,
                Amount = updtDscntDto.Amount,
                Description = updtDscntDto.Description,
                ImageUrl = updtDscntDto.ImageUrl
            });
            
            return Ok("İndirim Başarılı bir şekilde güncellendi");
        }



    }
}
