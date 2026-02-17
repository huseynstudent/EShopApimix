using EShopApi.DTOs;
using EShopApi.Entities;
using EShopApi.Repositories;

namespace EShopApi.Services;

public class CategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryService(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public void CreateCategory(Category category)
    {
        _categoryRepository.Add(category);
    }
    public void UpdateCategory(Category category)
    {
        _categoryRepository.Update(category.Id);
    }
    public void DeleteCategory(int id)
    {
        _categoryRepository.Delete(id);
    }
    public Category GetCategoryById(int id)
    {
        return _categoryRepository.GetById(id);
    }
    public List<Category> GetAllCategories()
    {
        return _categoryRepository.GetAll();
    }
    public List<GetAllGategoryWithProducts> GetAllCategoryWithProducts()
    {
        return _categoryRepository.GetAllCategoryWithProducts();
    }
}
