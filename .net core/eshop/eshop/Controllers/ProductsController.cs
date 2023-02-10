using eshop.Application.Services;
using eshop.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {

        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var products = productService.GetAllProducts();
            return View(products);
        }

        public IActionResult Create()
        {
            //List<SelectListItem> selectOptions = new List<SelectListItem>();
            ViewBag.Categories = GetCategoriesForSelect();



            return View();
        }




        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.CreateProduct(product);
            }

            ViewBag.Categories = GetCategoriesForSelect();
            return View();
        }


        public IActionResult Edit(int id)
        {

            if (productService.IsExists(id))
            {
                var product = productService.GetProduct(id);
                ViewBag.Categories = GetCategoriesForSelect();
                return View(product);
            }

            ModelState.AddModelError("notExists", "belirtilen id'de ürün yok");
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        IEnumerable<SelectListItem> GetCategoriesForSelect()
        {
            return categoryService.GetCategories()
                                                .Select(c => new SelectListItem
                                                {
                                                    Text = c.Name,
                                                    Value = c.Id.ToString()
                                                });
        }


    }
}
