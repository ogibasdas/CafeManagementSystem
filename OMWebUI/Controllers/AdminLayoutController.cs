using Microsoft.AspNetCore.Mvc;

namespace OMWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
