using EShopApi.Context;
using EShopApi.Entities;

namespace EShopApi.Repositories;

public class CategoryRepository : BaseRepository<Category>
{
    public CategoryRepository(EShopApiDbContext context) : base(context)
    {
    }
}
