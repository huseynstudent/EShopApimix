namespace EShopApi.Entities;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int CategoryId { get; set; }
}
