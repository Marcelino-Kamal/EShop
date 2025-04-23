using CookiesShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace CookiesShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
