using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OMWebUI.Dtos.CategoryDtos;

using System.Text;

namespace OMWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();  //sunucu oluşturuldu
            var responseMessage = await client.GetAsync("https://localhost:7084/api/Ctgry"); //api'den veri çekildi
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData); //json verisi deserialize edildi
                return View(values); //veri view'e gönderildi
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateCategory()

        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            createCategoryDto.Status = true; //status true olarak ayarlandı
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7084/api/Ctgry", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7084/api/Ctgry/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"https://localhost:7084/api/Ctgry/{id}");

            if (!response.IsSuccessStatusCode)
                return NotFound();

            var jsonData = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:7084/api/Ctgry", content);

            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");

            var error = await response.Content.ReadAsStringAsync();
            ViewBag.ApiError = error;
            return View(dto);
        }


    }
}
