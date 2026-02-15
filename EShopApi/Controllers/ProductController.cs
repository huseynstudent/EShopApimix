using EShopApi.DTOs;
using EShopApi.Entities;
using EShopApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }
        [HttpGet]
        [Route("GetAllProductsWithCategoryName")]
        public IActionResult GetAllProductsWithCategoryName()
        {
            var products = _productService.GetAllProductWithCategoryNames();
            return Ok(products);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Create(CreateProductDto product)
        {
            var newProduct = new Product
            {
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId
            };
            _productService.CreateProduct(newProduct);
            return Ok("ProductController Post metodu çalıştı.");
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("ID mismatch");
            }
            _productService.UpdateProduct(product);
            return Ok("ProductController Put metodu çalıştı.");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok("ProductController Delete metodu çalıştı.");
        }
    }
}
