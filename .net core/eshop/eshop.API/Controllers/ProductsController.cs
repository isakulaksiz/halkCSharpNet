using eshop.Application.Services;
using eshop.Entities;
using Microsoft.AspNetCore.Mvc;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{name}")]
        public IActionResult SearchProducts(string name)
        {
            IList<Product> products = productService.SearchProductByName(name);
            return Ok(products);
        }

        [HttpGet("{categoryId:int}")]

        public IActionResult GetProductsByCategoryId(int categoryId)
        {
            var products = productService.GetProductsByCategoryId(categoryId);
            return Ok(products);
        }

        [HttpGet("[action]/{id:int}")]
        public IActionResult GetProduct(int id)
        {
            var product = productService.GetProduct(id);
            if (product != null)
            {
                return Ok(product);
            }

            return NotFound();

        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var createdProductId = productService.CreateProduct(product);
                return CreatedAtAction(nameof(GetProduct), routeValues: new { id = createdProductId }, null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("id:int")]
        //Not: [FromRoute] ve [FromBody] attribute'leri zorunlu değildir! 
        public IActionResult UpdateProduct([FromRoute] int id, [FromBody] Product product)
        {

            return Ok();
        }



    }
}
