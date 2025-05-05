using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.PrdctDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrdctController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public PrdctController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<RsltPrdctDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]

        public IActionResult ProductListWithCategory()
        {
            var value = _mapper.Map<List<RsltPrdctWthCtgry>>(_productService.TGetProductsWithCategories());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateProduct(CrtPrdctDto crtPrdctDto)
        {
            _productService.TAdd(new Product()
            {
                Name = crtPrdctDto.Name,
                Description = crtPrdctDto.Description,
                Price = crtPrdctDto.Price,
                ImageUrl = crtPrdctDto.ImageUrl,
                Status = crtPrdctDto.Status,
            });
            return Ok("Ürün Başarılı bir şekilde eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Başarılı bir şekilde silindi");
        }

        [HttpGet("GetProduct")]


        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }


        [HttpPut]

        public IActionResult UpdateProduct(UpdtPrdctDto updtPrdctDto)
        {
            _productService.TUpdate(new Product()
            {
                Id = updtPrdctDto.Id,
                Name = updtPrdctDto.Name,
                Description = updtPrdctDto.Description,
                Price = updtPrdctDto.Price,
                ImageUrl = updtPrdctDto.ImageUrl,
                Status = updtPrdctDto.Status,
            }); 
            return Ok("Ürün Başarılı bir şekilde güncellendi");
        }


    }
}
