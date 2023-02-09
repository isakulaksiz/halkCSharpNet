using Microsoft.AspNetCore.Mvc;

namespace eshop.Controllers
{
    public class ShoppingCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct(int id)
        {
            return Json($"İşlem başarılı. Gelen ürün id'si:{id}");
        }
    }
}
