using eshop.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace eshop.API.Fiters
{

    public class ItemExistsAttribute : TypeFilterAttribute
    {
        public ItemExistsAttribute() : base(typeof(ItemExistsFilter))
        {

        }
    }
    public class ItemExistsFilter : IAsyncActionFilter
    {
        private readonly IProductService productService;

        public ItemExistsFilter(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //Amaç: ID'si verilen ürün var mı yok mu?
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestObjectResult(new { message = "bu metot id parametresi içermiyor!" });
                return;
            }


            if (!(context.ActionArguments["id"] is int id))
            {
                context.Result = new BadRequestResult();
                return;
            }

            var isExists = productService.IsExists(id);

            if (!isExists)
            {
                context.Result = new NotFoundObjectResult(new { message = $"{id} id'li ürün yok." });
                return;
            }

            await next();



        }
    }
}
