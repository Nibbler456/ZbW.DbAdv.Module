using CodeFirst.VidApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.VidApp;

public class VidAppContext : DbContext
{
    public DbSet<Video> Videos { get; set; }
    public DbSet<Genre> Genres { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemoStart;Trusted_Connection=True;TrustServerCertificate=True");
        optionsBuilder.UseSqlServer(@"Data Source=localhost,1433;Initial Catalog=VidApp;user id=sa; password=Q0N*8hi7TAG$o763&wZ!$%%J%tV9I!DZ1v3v4rVx;;Encrypt=False");
            
        // optionsBuilder.LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Video>()
            .HasMany<Genre>()
            .WithMany();
    }
}
