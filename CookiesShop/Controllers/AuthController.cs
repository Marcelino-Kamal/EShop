using CookiesShop.Data;
using CookiesShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CookiesShop.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly PasswordHasher<Users> _passwordHasher;

        public AuthController(ApplicationDbContext context) { 
            
            _context = context;
            _passwordHasher = new PasswordHasher<Users>();

        }

        public IActionResult Register() {
        
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Users user)
        {
            user.Password = _passwordHasher.HashPassword(user, user.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

       
    }
}
