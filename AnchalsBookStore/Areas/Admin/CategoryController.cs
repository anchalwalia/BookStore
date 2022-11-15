using Microsoft.AspNetCore.Mvc;

namespace AnchalsBookStore.Areas.Admin
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
