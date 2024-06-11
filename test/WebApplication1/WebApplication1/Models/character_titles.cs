using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

public class character_titles
{
    [Key] public int CharacterId { get; set; }
    [MaxLength(50)] public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }
    [ForeignKey(nameof(CharacterId))]
    public characters Characters { get; set; } = null!;
    [ForeignKey(nameof(TitleId))]
    public titles Titles { get; set; } = null!;
}