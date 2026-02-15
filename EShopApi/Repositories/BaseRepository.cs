using EShopApi.Context;

namespace EShopApi.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly EShopApiDbContext _context;

    public BaseRepository(EShopApiDbContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _context.Set<T>().Find(id);
        if (entity != null)
        {
            entity.GetType().GetProperty("IsDeleted")?.SetValue(entity, true);
            entity.GetType().GetProperty("DeletedDate")?.SetValue(entity, DateTime.Now);
            _context.SaveChanges();
        }
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void  Update(int id)
    {
        var entity = _context.Set<T>().Find(id);
        if (entity != null)
        {
            entity.GetType().GetProperty("UpdatedDate")?.SetValue(entity, DateTime.Now);
            _context.SaveChanges();
        }
    }
}
