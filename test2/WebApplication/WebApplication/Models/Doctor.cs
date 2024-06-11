namespace WebApplication2.Models;

using System.ComponentModel.DataAnnotations;

public class caracters
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(120)]
    public string LastName { get; set; } = string.Empty;
    
    public string Email { get; set; } = string.Empty;
    
    public ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();

    
}