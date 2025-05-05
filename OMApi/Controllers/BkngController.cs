using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.BkngDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BkngController : ControllerBase
    {

        private readonly IBookingService _bookingService;

        public BkngController(IBookingService bookingService)
        {
             _bookingService= bookingService;
        }

        [HttpGet]

        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateBooking(CrtBkngDto crtBkngDto)
        {
            Booking booking = new Booking()
            {
                Name = crtBkngDto.Name,
                Phone = crtBkngDto.Phone,
                EMail = crtBkngDto.EMail,
                PerCount = crtBkngDto.PerCount,
                Date = crtBkngDto.Date
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Başarılı bir şekilde eklendi");

        }

        [HttpDelete]

        public IActionResult DeleteBooking(int id) 
        
        {
            var value = _bookingService.TGetByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Başarılı bir şekilde silindi");
        }

        [HttpPut]

        public IActionResult UpdateBooking(UpdtBkngDto updtBkngDto)
        {
            Booking booking = new Booking()
            {
                Id = updtBkngDto.Id,
                Name = updtBkngDto.Name,
                Phone = updtBkngDto.Phone,
                EMail = updtBkngDto.EMail,
                PerCount = updtBkngDto.PerCount,
                Date = updtBkngDto.Date
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Başarılı bir şekilde güncellendi");
        }

        [HttpGet("GetBooking")]

        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);
        }


    }
}
