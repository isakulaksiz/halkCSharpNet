using introducingNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace introducingNetCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            List<Product> products = new()
            {
                new(){ Id=1, Name="Ürün A", Price=500},
                new(){ Id=2, Name="Ürün B", Price=600},
                new(){ Id=3, Name="Ürün C", Price=700},

            };

            ViewBag.Name = "Türkay";
            ViewBag.Hour = DateTime.Now.Hour;
            ViewBag.Info = "Test";


            return View(products);
        }
        [HttpGet]
        public IActionResult Response()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Response(Responser responser)
        {
            return ModelState.IsValid ? View("Thanks", responser) : (IActionResult)View();
        }
    }
}
