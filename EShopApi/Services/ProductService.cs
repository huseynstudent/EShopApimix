using EShopApi.DTOs;
using EShopApi.Entities;
using EShopApi.Repositories;

namespace EShopApi.Services;

public class ProductService
{
    private readonly ProductRepository _productRepository;

    public ProductService(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public void CreateProduct(Product product)
    {
        _productRepository.Add(product);
    }
    public void UpdateProduct(Product product)
    {
        _productRepository.Update(product.Id);
    }
    public void DeleteProduct(int id)
    {
        _productRepository.Delete(id);
    }
    public Product GetProductById(int id)
    {
        return _productRepository.GetById(id);
    }
    public List<Product> GetAllProducts()
    {
        return _productRepository.GetAll();
    }
    public List<GetAllProductWithCategoryName> GetAllProductWithCategoryNames()
    {
        return _productRepository.GetAllProductWithCategoryNames();
    }
}
