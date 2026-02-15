using EShopApi.Context;
using EShopApi.DTOs;
using EShopApi.Entities;

namespace EShopApi.Repositories;

public class ProductRepository : BaseRepository<Product>
{
    public ProductRepository(EShopApiDbContext context) : base(context)
    {
    }
    public List<GetAllProductWithCategoryName> GetAllProductWithCategoryNames()
    {
        var products = _context.Products.ToList();
        var categories = _context.Categories.ToList();
        var result = from p in products
                     join c in categories on p.CategoryId equals c.Id
                     select new GetAllProductWithCategoryName
                     {
                         Name = p.Name,
                         Price = p.Price,
                         CategoryName = c.Name
                     };
        return result.ToList();
    }
}
