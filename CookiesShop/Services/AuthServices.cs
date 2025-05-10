using CookiesShop.Models;
using Microsoft.AspNetCore.Identity;

namespace CookiesShop.Services
{
    public static class AuthServices
    {
       
       
        public static bool IsAuthenticated(Users u, string enteredPassword) {

            var res= new PasswordHasher<Users>().VerifyHashedPassword(u,u.Password,enteredPassword);
            return res == PasswordVerificationResult.Success;
        }
        public static string HashMyPass(Users u) { 
            
            return new PasswordHasher<Users>().HashPassword(u,u.Password);
        }
       

        
    }
}
