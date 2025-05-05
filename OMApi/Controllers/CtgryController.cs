using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OM.Business.Abstract;
using OM.Dto.CtgryDto;
using OM.Entity.Entities;

namespace OMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CtgryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CtgryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<RsltCtgryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateCategory(CrtCtgryDto crtCtgryDto)
        {
            _categoryService.TAdd(new Category()

            {
                Name = crtCtgryDto.Name,
                Status = true
            });

            return Ok("Kategori Başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Başarılı bir şekilde silindi");
        }

        [HttpGet("{id}")]

        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdtCtgryDto updateCategoryDto)
        {
            var existing = _categoryService.TGetByID(updateCategoryDto.Id);
            if (existing == null)
                return NotFound();

            existing.Name = updateCategoryDto.Name;
            existing.Status = updateCategoryDto.Status;

            _categoryService.TUpdate(existing);

            return Ok("Kategori güncellendi");
        }

    }
}

