using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CookiesShop.Binders
{
    public class ProductBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {





            return Task.CompletedTask;  
        }
    }
}
