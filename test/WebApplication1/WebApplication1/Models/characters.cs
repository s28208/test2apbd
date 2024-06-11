using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class characters
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(120)]
    public string LastName { get; set; } = string.Empty;
    public int CurrentWei { get; set; } 
    public int MaxWeight { get; set; } 

    public ICollection<character_titles> CharacterTitles { get; set; } = new HashSet<character_titles>();
    public ICollection<backpacks> Backpacks { get; set; } = new HashSet<backpacks>();

}