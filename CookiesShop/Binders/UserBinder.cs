using CookiesShop.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CookiesShop.Binders
{
    public class UserBinder : IModelBinder

    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string Fname = bindingContext.HttpContext.Request.Form["Fname"];
            string Lname = bindingContext.HttpContext.Request.Form["Lname"];
            string email = bindingContext.HttpContext.Request.Form["email"];
            string password = bindingContext.HttpContext.Request.Form["password"];
            int RoleId = Convert.ToInt32(bindingContext.HttpContext.Request.Form["RoleId"]);

            var user = new Users()
            {
                Username = Fname + Lname,
                Email = email,
                RoleID = RoleId,
                Password = password
            };

            bindingContext.Result = ModelBindingResult.Success(user);
            return Task.CompletedTask;
        }
    }
}
