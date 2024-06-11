using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class item
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public int Weight { get; set; } 
    public ICollection<backpacks> Backpacks { get; set; } = new HashSet<backpacks>();
}