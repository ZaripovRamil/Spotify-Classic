using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Database;

public class AppDbContext: IdentityDbContext<User>
{
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Album>Albums { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasIndex(p => new {p.UserName, p.Email})
            .IsUnique();
        modelBuilder.Entity<Author>()
            .HasMany(x=>x.Albums)
            .WithOne(album => album.Author)
            .IsRequired();
        modelBuilder.Entity<Album>().HasMany(x=>x.Tracks)
            .WithOne(t=>t.Album)
            .IsRequired();
        modelBuilder.Entity<Genre>()
            .HasIndex(g => g.Name)
            .IsUnique();
    }
}