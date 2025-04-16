using Microsoft.AspNetCore.Mvc;

namespace CookiesShop.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
