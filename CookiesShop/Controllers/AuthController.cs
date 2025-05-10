using CookiesShop.Data;
using CookiesShop.Models;
using CookiesShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;


namespace CookiesShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _httpClient;

        public AuthController(ApplicationDbContext context, IHttpClientFactory httpClientFactory) {
            _context = context;
            _httpClient = httpClientFactory.CreateClient();

        }
      
        [HttpPost("Register")]
        public async Task<IActionResult> Register(Users user)
        {
            user.Password = AuthServices.HashMyPass(user);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok("Added Successfully");
        }
        
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm]String email ,[FromForm] String password)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email == email);
            if (user != null && AuthServices.IsAuthenticated(user, password)) {

                return Ok("login success");
            }
            return Ok("invalid User");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null) { 
                
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return Ok("User has been deleted");
            
            }

            return Ok("User doesn't exists or Already deleted");
        }

       
    }
}
