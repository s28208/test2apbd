using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<backpacks> Pastries { get; set; }
    public DbSet<character_titles> Clients { get; set; }
    public DbSet<characters> Employees { get; set; }
    public DbSet<item> Orders { get; set; }
    public DbSet<titles> OrderPastries { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<characters>().HasData(new List<characters>
            {
                new characters {
                    Id = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    CurrentWei = 2,
                    MaxWeight = 3
                },
                new characters {
                    Id = 2,
                    FirstName = "Anna",
                    LastName = "Nowak",
                    CurrentWei = 1,
                    MaxWeight = 5
                }
            });

            modelBuilder.Entity<item>().HasData(new List<item>
            {
                new item {
                    Id = 1,
                    Name = "item1",
                    Weight = 2
                },
                new item {
                    Id = 2,
                    Name = "item2",
                    Weight = 3
                }
            });

            modelBuilder.Entity<titles>().HasData(new List<titles>
            {
                new titles
                {
                    Id = 1,
                    Name = "T1"
                },
                new titles
                {
                    Id = 2,
                    Name = "T2"
                },
                new titles
                {
                    Id = 3,
                    Name = "T3"
                }
            });

            modelBuilder.Entity<character_titles>().HasData(new List<character_titles>
            {
                new character_titles
                {
                    CharacterId = 1,
                    TitleId = 2,
                    AcquiredAt = DateTime.Parse("2024-05-28"),
                    
                },
                new character_titles
                {
                    CharacterId = 2,
                    TitleId = 3,
                    AcquiredAt = DateTime.Parse("2024-05-31"),
                 
                },
                new character_titles
                {
                    CharacterId = 3,
                    TitleId = 1,
                    AcquiredAt = DateTime.Parse("2024-06-01"),
                   
                }
            });

            modelBuilder.Entity<backpacks>().HasData(new List<backpacks>
            {
                new backpacks
                {
                    CharacterId = 1,
                    ItemId = 2,
                    Amount = 3,
                },
                new backpacks
                {
                    CharacterId = 1,
                    ItemId = 1,
                    Amount = 4,
                },
                new backpacks
                {
                    CharacterId = 2,
                    ItemId = 1,
                    Amount = 1,
                },
                new backpacks
                {
                    CharacterId = 2,
                    ItemId = 2,
                    Amount = 2,
                },
            });
    }
}