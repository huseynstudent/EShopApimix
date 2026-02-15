using EShopApi.Context;
using EShopApi.DTOs;
using EShopApi.Entities;
using EShopApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]
        public IActionResult Create(CreateCategoryDto category)
        {

            var newCategory = new Category
            {
                Name = category.Name
            };
            _categoryService.CreateCategory(newCategory);
            return Ok("CategoryController Post metodu çalıştı.");

        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest("ID mismatch");
            }
            _categoryService.UpdateCategory(category);
            return Ok("CategoryController Put metodu çalıştı.");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.DeleteCategory(id);
            return Ok("CategoryController Delete metodu çalıştı.");
        }
    }
}
