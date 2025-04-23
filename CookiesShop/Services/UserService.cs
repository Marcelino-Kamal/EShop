using CookiesShop.Models;
using Microsoft.AspNetCore.Identity;

namespace CookiesShop.Services
{
    public static class UserService
    {

       
        public static bool IsAuthenticated(Users u,string hashedPassword, string enteredPassword) {

            return new PasswordHasher<Users>().HashPassword(u,enteredPassword) == hashedPassword;
        }
        public static string HashMyPass(Users u) { 
            
            return new PasswordHasher<Users>().HashPassword(u,u.Password);
        }
       

        
    }
}
