using Microsoft.AspNetCore.Mvc;

namespace BaiTH1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
