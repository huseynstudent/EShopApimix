using EShopApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Context;

public class EShopApiDbContext:DbContext
{
    public EShopApiDbContext(DbContextOptions<EShopApiDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
