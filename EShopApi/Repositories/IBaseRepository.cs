namespace EShopApi.Repositories;

public interface IBaseRepository<T> where T : class
{
    T GetById(int id);
    List<T> GetAll();
    void Add(T entity);
    void Update(int id);
    void Delete(int id);
}
