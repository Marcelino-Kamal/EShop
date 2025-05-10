using CookiesShop.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CookiesShop.Binders
{
    public class ProductBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string Name = bindingContext.HttpContext.Request.Form["name"];
            string Desc = bindingContext.HttpContext.Request.Form["desc"];
            //string imgUrl = bindingContext.HttpContext.Request.Form["imgUrl"];
            decimal price = Convert.ToDecimal(bindingContext.HttpContext.Request.Form["price"]);
            bool inStock = Convert.ToBoolean(bindingContext.HttpContext.Request.Form["inStock"]);
            int CatID = Convert.ToInt32(bindingContext.HttpContext.Request.Form["CatID"]);

            var product = new Products() {
            
                name = Name,
                description = Desc,
                price = price,
                inStock = inStock,
                CategoryID = CatID,
            
            };


            bindingContext.Result = ModelBindingResult.Success(product);
            return Task.CompletedTask;  
        }
    }
}
