using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Models.Entities;
using Models.Entities.Enums;
using Models.Entities.Joints;

namespace Database;

public class AppDbContext : IdentityDbContext<User>
{
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Playlist> Playlists { get; set; }

    public DbSet<Subscription> Subscriptions { get; set; }

    private readonly IServiceProvider _serviceProvider;

    public AppDbContext(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public AppDbContext(DbContextOptions options, IServiceProvider serviceProvider) : base(options)
    {
        _serviceProvider = serviceProvider;
    }

    public void Migrate()
    {
        foreach (var migration in Database.GetPendingMigrations())
        {
            Console.WriteLine(migration);
        }

        Database.Migrate();
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     // if (!optionsBuilder.IsConfigured)
    //     //     optionsBuilder.UseNpgsql("Server=localhost;Database=Spotify;Port=5432;username = postgres;SSLMode=Prefer");
    //     base.OnConfiguring(optionsBuilder);
    //     optionsBuilder.EnableSensitiveDataLogging();
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasIndex(p => new { p.UserName, p.Email })
            .IsUnique();
        modelBuilder.Entity<Genre>()
            .HasIndex(g => g.Name)
            .IsUnique();
        modelBuilder.Entity<Author>()
            .HasMany(x => x.Albums)
            .WithOne(album => album.Author)
            .HasForeignKey(album => album.AuthorId)
            .HasPrincipalKey(author => author.Id)
            .IsRequired();
        modelBuilder.Entity<Album>()
            .HasMany(x => x.Tracks)
            .WithOne(t => t.Album)
            .HasForeignKey(track => track.AlbumId)
            .HasPrincipalKey(album => album.Id)
            .IsRequired();
        modelBuilder.Entity<Track>()
            .HasMany(t => t.Genres)
            .WithMany(g => g.Tracks)
            .UsingEntity<GenreTrack>();
        modelBuilder.Entity<Track>()
            .HasMany(t => t.Listeners)
            .WithMany(u => u.History)
            .UsingEntity<UserTrack>();

        PopulateDb(modelBuilder);
    }

    private static void PopulateDb(ModelBuilder modelBuilder)
    {
        #region subscription creation

        var premium = new Subscription { Id = "Premium", Name = "Premium", Price = 199 };
        modelBuilder.Entity<Subscription>()
            .HasData(premium);

        #endregion

        #region users creation

        var defaultUser = new User("user1", "defaultUser", null, "John Doe");
        var subscriptionTestUser = new User("user2", "subscriptionTestUser", null, "Jane Doe")
            { SubscriptionId = "Premium" };
        modelBuilder.Entity<User>().HasData(defaultUser, subscriptionTestUser);

        #endregion

        #region authors creation

        var mozartAuthor = new Author("author1", defaultUser, "Wolfgang Amadeus Mozart");
        var vivaldiAuthor = new Author("author2", defaultUser, "Antonio Lucio Vivaldi");
        var beethovenAuthor = new Author("author3", defaultUser, "Ludwig van Beethoven");
        var shostakovichAuthor = new Author("author4", defaultUser, "Dmitri Shostakovich");
        var chopinAuthor = new Author("author5", defaultUser, "Frédéric Chopin");
        var rimskyKorsakovAuthor = new Author("author6", defaultUser, "Nikolai Rimsky-Korsakov");
        var lisztAuthor = new Author("author7", defaultUser, "Franz Liszt");
        var sennevilleAuthor = new Author("author8", defaultUser, "Paul de Senneville");
        var paganiniAuthor = new Author("author9", defaultUser, "Niccolò Paganini");
        var memeGodAuthor = new Author("author10", defaultUser, "Rick Astley");
        var tchaikovskyAuthor = new Author("author11", defaultUser, "Pyotr Tchaikovsky");
        modelBuilder.Entity<Author>().HasData(mozartAuthor, vivaldiAuthor, beethovenAuthor, shostakovichAuthor,
            chopinAuthor, rimskyKorsakovAuthor, lisztAuthor, sennevilleAuthor, paganiniAuthor, memeGodAuthor,
            tchaikovskyAuthor);

        #endregion

        #region albums creation

        var fourSeasonsAlbum = new Album("album", "The Four Seasons", vivaldiAuthor, AlbumType.Album, 1725,
            "7c561b1e-3070-4e83-b71a-2fd7a69fa040");
        var moonlightAlbum = new Album("album1", "Moonlight Sonata", beethovenAuthor, AlbumType.Single, 1802,
            "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb");
        var waltzNo2Album = new Album("album2", "Waltz No. 2", shostakovichAuthor, AlbumType.Single, 1938,
            "29ad8ca9-c791-4482-8a44-15776862b282");
        var fantaisieImpromptuAlbum = new Album("album3", "Fantaisie-Impromptu", chopinAuthor, AlbumType.Single, 1834,
            "4180556e-5365-4b9c-aa72-a47241346855");
        var taleofTsarSaltanAlbum = new Album("album4", "The Tale of Tsar Saltan", rimskyKorsakovAuthor,
            AlbumType.Album, 1900, "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f");
        var liebestraumAlbum = new Album("album5", "Liebestraum", lisztAuthor, AlbumType.Album, 1850,
            "44f268c1-3e94-4d05-8ccb-17c2e77b538d");
        var grandesEtudesDePaganiniAlbum = new Album("album6", "Grandes études de Paganini", lisztAuthor,
            AlbumType.Album, 1851, "864239f6-65c5-440f-8326-213b3b25693f");
        var lettreAMaMereAlbum = new Album("album7", "Lettre à ma mère", sennevilleAuthor, AlbumType.Album, 1979,
            "5a9ba216-9883-471d-9c0f-4c3d37e4ec34");
        var requiemMozartAlbum = new Album("album8", "Requiem", mozartAuthor, AlbumType.Album, 1791,
            "9d0a67df-6fb4-4fac-b670-49a5f590beb7");
        var marriageOfFigaroAlbum = new Album("album9", "The marriage of Figaro", mozartAuthor, AlbumType.Album, 1786,
            "15fa89e4-7777-4330-b32e-62172cd398c0");
        var violinConcertoNo2Album = new Album("album10", "Violin Concerto No. 2", paganiniAuthor, AlbumType.Album,
            1826, "493afb2c-eb2a-4eab-9e4e-6585eb9924ae");
        var wheneverYouNeedSomebodyAlbum =
            new Album("album11", "Whenever you need somebody", memeGodAuthor, AlbumType.Album, 1987,
                "572cc6a2-a5ba-47f5-8819-8330770cf8b5");
        var valseScherzoAlbum = new Album("album12", "Valse-Scherzo", tchaikovskyAuthor, AlbumType.Album, 1877,
            "36febf49-1c49-4b69-8084-73ebce69040a");
        var pianoSonataNo11Album = new Album("album13", "Piano Sonata No. 11", mozartAuthor, AlbumType.Album, 1784,
            "b26e8131-28bf-4ae9-842b-33b3d639b08e");
        var hungarianRhapsodiesAlbum = new Album("album14", "Hungarian Rhapsodies", lisztAuthor, AlbumType.Album, 1885,
            "0a8c3ca2-56ca-4534-a426-648854e61821");

        #endregion

        #region genres creation

        var classicGenre = new Genre("genre1", "Classic");
        var instrumentalGenre = new Genre("genre2", "Instrumental");
        var jazzGenre = new Genre("genre3", "Jazz");
        var newAgeGenre = new Genre("genre4", "New Age");
        var popGenre = new Genre("genre5", "Pop");

        #endregion

        #region tracks creation

        var storm = new Track("track1", "Summer - Storm", fourSeasonsAlbum,
            "7c561b1e-3070-4e83-b71a-2fd7a69fa040"); // classic, instrumental
        var spring =
            new Track("track2", "Spring", fourSeasonsAlbum,
                "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf"); // classic, instrumental
        var moonlight = new Track("track3", "Moonlight Sonata", moonlightAlbum,
            "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb"); // classic, instrumental
        var waltzNo2 =
            new Track("track4", "Waltz No. 2", waltzNo2Album, "29ad8ca9-c791-4482-8a44-15776862b282"); // classic, jazz
        var fantasieImpromptu = new Track("track5", "Fantaisie Impromptu", fantaisieImpromptuAlbum,
            "4180556e-5365-4b9c-aa72-a47241346855"); // classic, instrumental
        var flightOfBumblemee = new Track("track6", "Flight of the Bumblebee", taleofTsarSaltanAlbum,
            "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f"); // classic, instrumental
        var laCampanellaLiszt = new Track("track7", "La Campanella", grandesEtudesDePaganiniAlbum,
            "864239f6-65c5-440f-8326-213b3b25693f"); // classic, instrumental
        var loveDream =
            new Track("track8", "Love Dream", liebestraumAlbum,
                "44f268c1-3e94-4d05-8ccb-17c2e77b538d"); // classic, instrumental
        var marriegeDAmour = new Track("track9", "Marriage d'Amour", lettreAMaMereAlbum,
            "5a9ba216-9883-471d-9c0f-4c3d37e4ec34"); // newage, instrumental
        var lacrimosa =
            new Track("track10", "Lacrimosa", requiemMozartAlbum, "9d0a67df-6fb4-4fac-b670-49a5f590beb7"); // classic
        var marriageOfFigaro = new Track("track11", "Marriage of Figaro - Overture", marriageOfFigaroAlbum,
            "15fa89e4-7777-4330-b32e-62172cd398c0"); // classic, instrumental
        var laCampanellaPaganini = new Track("track12", "La Campanella", violinConcertoNo2Album,
            "493afb2c-eb2a-4eab-9e4e-6585eb9924ae"); // classic, instrumental
        var rickroll = new Track("track13", "Never gonna give you up", wheneverYouNeedSomebodyAlbum,
            "572cc6a2-a5ba-47f5-8819-8330770cf8b5"); // pop
        var valseSentimental = new Track("track14", "Valse Sentimental", valseScherzoAlbum,
            "36febf49-1c49-4b69-8084-73ebce69040a"); // classic, instrumental
        var turkishMarch = new Track("track15", "Turkish March", pianoSonataNo11Album,
            "b26e8131-28bf-4ae9-842b-33b3d639b08e"); // classic, instrumental
        var hungarianRhapsodyNo2 = new Track("track16", "Hungarian Rhapsody No. 2", hungarianRhapsodiesAlbum,
            "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb"); // classic, instrumental

        #endregion

        #region db populating

        modelBuilder.Entity<Genre>().HasData(classicGenre, instrumentalGenre, jazzGenre, newAgeGenre, popGenre);
        modelBuilder.Entity<Album>().HasData(fourSeasonsAlbum, moonlightAlbum, waltzNo2Album, fantaisieImpromptuAlbum,
            taleofTsarSaltanAlbum, grandesEtudesDePaganiniAlbum, liebestraumAlbum, lettreAMaMereAlbum,
            requiemMozartAlbum, marriageOfFigaroAlbum, violinConcertoNo2Album, wheneverYouNeedSomebodyAlbum,
            valseScherzoAlbum, pianoSonataNo11Album, hungarianRhapsodiesAlbum);
        modelBuilder.Entity<Track>().HasData(storm, spring, moonlight, waltzNo2, fantasieImpromptu, flightOfBumblemee,
            laCampanellaLiszt, loveDream, marriegeDAmour, lacrimosa, marriageOfFigaro, laCampanellaPaganini, rickroll,
            valseSentimental, turkishMarch, hungarianRhapsodyNo2);

        #endregion

        #region genretracks creation

        modelBuilder.Entity<GenreTrack>()
            .HasData(new GenreTrack(classicGenre, storm), new GenreTrack(instrumentalGenre, storm),
                new GenreTrack(classicGenre, spring), new GenreTrack(instrumentalGenre, spring),
                new GenreTrack(classicGenre, moonlight), new GenreTrack(instrumentalGenre, moonlight),
                new GenreTrack(classicGenre, waltzNo2), new GenreTrack(jazzGenre, waltzNo2),
                new GenreTrack(classicGenre, fantasieImpromptu), new GenreTrack(instrumentalGenre, fantasieImpromptu),
                new GenreTrack(classicGenre, flightOfBumblemee), new GenreTrack(instrumentalGenre, flightOfBumblemee),
                new GenreTrack(classicGenre, laCampanellaLiszt), new GenreTrack(instrumentalGenre, laCampanellaLiszt),
                new GenreTrack(classicGenre, laCampanellaPaganini),
                new GenreTrack(instrumentalGenre, laCampanellaPaganini),
                new GenreTrack(classicGenre, loveDream), new GenreTrack(instrumentalGenre, loveDream),
                new GenreTrack(newAgeGenre, marriegeDAmour), new GenreTrack(instrumentalGenre, marriegeDAmour),
                new GenreTrack(classicGenre, lacrimosa),
                new GenreTrack(classicGenre, marriageOfFigaro), new GenreTrack(instrumentalGenre, marriageOfFigaro),
                new GenreTrack(popGenre, rickroll),
                new GenreTrack(classicGenre, valseSentimental), new GenreTrack(instrumentalGenre, valseSentimental),
                new GenreTrack(classicGenre, turkishMarch), new GenreTrack(instrumentalGenre, turkishMarch),
                new GenreTrack(classicGenre, hungarianRhapsodyNo2),
                new GenreTrack(instrumentalGenre, hungarianRhapsodyNo2)
            );

        #endregion
    }
}