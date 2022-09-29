using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksweb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
