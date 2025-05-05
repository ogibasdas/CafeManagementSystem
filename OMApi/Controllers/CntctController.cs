using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using OM.Business.Abstract;
using OM.Dto.CntctDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CntctController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public CntctController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;   
        }

        [HttpGet]

        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<RsltCntctDto>>(_contactService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateContact(CrtCntctDto crtCntctDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = crtCntctDto.FooterDescription,
                Location = crtCntctDto.Location,
                EMail = crtCntctDto.EMail,
                Phone = crtCntctDto.Phone

            });

            return Ok("İletisim infosu eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletisim infosu silindi");
        }

        [HttpGet("GetContact")]

        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]

        public IActionResult UpdateContact(UpdtCntctDto updtCntctDto)
        {
            _contactService.TUpdate(new Contact()

            {
                Id = updtCntctDto.Id,
                FooterDescription = updtCntctDto.FooterDescription,
                Location = updtCntctDto.Location,
                EMail = updtCntctDto.EMail,
                Phone = updtCntctDto.Phone
            });

            return Ok("İletisim infosu güncellendi");
        }
    }
}
