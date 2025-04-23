using CookiesShop.Data;
using CookiesShop.Models;
using CookiesShop.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CookiesShop.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;
       

        public AuthController(ApplicationDbContext context) { 
            
            _context = context;
           

        }

        public IActionResult Register() {
        
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Users user)
        {
            user.Password = UserService.HashMyPass(user);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(String email , String password)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == email);
            if (user != null && UserService.IsAuthenticated(user,user.Password, password)) { }
            return RedirectToAction("Index", "Home");
        }

       
    }
}
