using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EShopApi.DTOs;

[Index(nameof(Name), IsUnique = true)]
public class CreateCategoryDto
{

    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
}
