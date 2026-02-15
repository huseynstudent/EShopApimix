using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace EShopApi.Entities;

[Index(nameof(Name), IsUnique = true)]
public class Category:BaseEntity
{
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
}
