using EShopApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace EShopApi.DTOs;

public class GetAllGategoryWithProducts
{
    [Required]
    public string Name { get; set; }
    public List<Product> Products { get; set; } = new List<Product> { };
}
