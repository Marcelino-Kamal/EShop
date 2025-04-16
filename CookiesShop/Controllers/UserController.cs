using Microsoft.AspNetCore.Mvc;

namespace CookiesShop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
