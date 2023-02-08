using eshop.Application.Services;
using eshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index(int pageNo = 1, int? categoryId = null)
        {

            var products = categoryId == null ? productService.GetAllProducts() : productService.GetProductsByCategoryId(categoryId.Value);
            var totalProductsCount = products.Count;
            var productsPerPage = 7;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)totalProductsCount / productsPerPage);

            /*
             * pageNo 1 ise 0 eleman atla 4 tane al
             * pageNo 2 ise 4             4
             * pageNo 3 ise 8             4
             * pageNo 4 ise 12            4
             */

            products = products.OrderBy(x => x.Id)
                               .Skip((pageNo - 1) * productsPerPage)
                               .Take(productsPerPage)
                               .ToList();

            ViewBag.SelectedCategoryId = categoryId;

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}