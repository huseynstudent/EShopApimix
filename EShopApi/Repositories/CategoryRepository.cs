using EShopApi.Context;
using EShopApi.DTOs;
using EShopApi.Entities;

namespace EShopApi.Repositories;

public class CategoryRepository : BaseRepository<Category>
{
    public CategoryRepository(EShopApiDbContext context) : base(context)
    {
    }
    public List<GetAllGategoryWithProducts> GetAllGategoryWithProducts()
    {
        var products = _context.Products.ToList();
        var categories = _context.Categories.ToList();
        var result = from c in categories select

            new GetAllGategoryWithProducts
            {
                Name = c.Name,

            }
        return result.ToList();
    }
