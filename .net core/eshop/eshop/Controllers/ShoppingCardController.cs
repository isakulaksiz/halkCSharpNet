using eshop.Application.Services;
using eshop.Extensions;
using eshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace eshop.Controllers
{
    public class ShoppingCardController : Controller
    {

        private readonly IProductService productService;

        public ShoppingCardController(IProductService productService)
        {
            this.productService = productService;
        }


        public IActionResult AddProduct(int id)
        {
            var product = productService.GetProduct(id);

            //İlk ürünü eklediğiniz zaman session nesnesi oluşacak ve içine sepet koleksiyonu eklenecek. 
            //Daha önce eklenmiş ise var olan session nesnesinden sepe koleksiyonu alınacak.
            ShoppingCardCollection shoppingCardCollection = getCollectionFromSession();
            shoppingCardCollection.AddToCard(product, 1);
            saveToSession(shoppingCardCollection);
            return Json($"İşlem başarılı. Gelen {id}'li ürün sepete eklendi.");
        }

        public IActionResult Index()
        {
            var shoppingCardCollection = getCollectionFromSession();
            return View(shoppingCardCollection);
        }



        private ShoppingCardCollection getCollectionFromSession()
        {
            //1. İlk ürünü eklediğiniz zaman....
            //if (HttpContext.Session.GetString("card") == null)
            //{
            //    ShoppingCardCollection shoppingCardCollection = new ShoppingCardCollection();
            //    HttpContext.Session.SetString("card", JsonConvert.SerializeObject(shoppingCardCollection));

            //}

            //string serializedCollection = HttpContext.Session.GetString("card");
            //return JsonConvert.DeserializeObject<ShoppingCardCollection>(serializedCollection);

            var shoppingCard = HttpContext.Session.GetJson<ShoppingCardCollection>("card") ?? new ShoppingCardCollection();
            return shoppingCard;
        }

        private void saveToSession(ShoppingCardCollection shoppingCardCollection)
        {
            //HttpContext.Session.SetString("card", JsonConvert.SerializeObject(shoppingCardCollection));
            HttpContext.Session.SetJson<ShoppingCardCollection>("card", shoppingCardCollection);
        }
    }
}
