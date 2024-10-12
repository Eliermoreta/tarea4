using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<MediaItem> MediaItems { get; set; }
    public DbSet<personaje> Personajes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MediaItem>()
            .HasMany(m => m.Personajes)
            .WithOne(p => p.MediaItem)
            .HasForeignKey(p => p.MediaItemId);
    }
}
}