using Microsoft.EntityFrameworkCore;
using Models;

namespace Database;

public class AppDbContext: DbContext
{
    public DbSet<Track> Genres { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(p => new { p.Login, p.Email })
            .IsUnique();
    }
}