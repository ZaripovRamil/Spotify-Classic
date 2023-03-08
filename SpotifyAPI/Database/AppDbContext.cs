using Microsoft.EntityFrameworkCore;
using Models;

namespace SpotifyAPI;

public class AppDbContext: DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Track> Genres { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<User>Users { get; set; }
    public DbSet<Playlist>Playlists { get; set; }
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}