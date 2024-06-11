using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class titles
{
    [Key]
    public int Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public ICollection<character_titles> CharacterTitles { get; set; } = new HashSet<character_titles>();

}