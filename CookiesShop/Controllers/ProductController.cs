using Microsoft.AspNetCore.Mvc;

namespace CookiesShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
