namespace WebApplication1.DTOs;

public class CharacterDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public int CurrentWei { get; set; } 
    public int MaxWeight { get; set; } 
    public ICollection<GetBackpackItemDTO> Pastries { get; set; } = null!;
    public ICollection<GetTitleDTO> Title { get; set; } = null!;


}

public class GetBackpackItemDTO
{
    public string ItemName { get; set; } 
    public int ItemWeight { get; set; } 
    public int Amount { get; set; } 
}

public class GetTitleDTO
{
    public string Title { get; set; } 
    public DateTime AquiredAt { get; set; } 
}