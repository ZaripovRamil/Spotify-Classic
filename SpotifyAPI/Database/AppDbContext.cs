using System.Text.Json;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Entities.Enums;

namespace Database;

public class AppDbContext: IdentityDbContext<User>
{
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public AppDbContext() { }
    public AppDbContext(DbContextOptions options) : base(options) { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
            .HasIndex(p => new {p.UserName, p.Email})
            .IsUnique();
        modelBuilder.Entity<Genre>()
            .HasIndex(g => g.Name)
            .IsUnique();
        modelBuilder.Entity<Author>()
            .HasMany(x=>x.Albums)
            .WithOne(album => album.Author)
            .HasForeignKey(album => album.AuthorId)
            .HasPrincipalKey(author => author.Id)
            .IsRequired();
        modelBuilder.Entity<Album>()
            .HasMany(x=>x.Tracks)
            .WithOne(t=>t.Album)
            .HasForeignKey(track => track.AlbumId)
            .HasPrincipalKey(album => album.Id)
            .IsRequired();
        
        PopulateDb(modelBuilder);
    }

    private void PopulateDb(ModelBuilder modelBuilder)
    {
        #region users creation

        var mozart = new User("mozart", "", "Wolfgang Amadeus Mozart");
        var vivaldi = new User("vivaldi", "", "Antonio Lucio Vivaldi");
        var beethoven = new User("beethoven", "", "Ludwig van Beethoven");
        var shostakovich = new User("shostakovich", "", "Dmitri Shostakovich");
        var chopin = new User("chopin", "", "Frédéric Chopin");
        var rimskyKorsakov = new User("rimsky-korsakov", "", "Nikolai Rimsky-Korsakov");
        var liszt = new User("liszt", "", "Franz Liszt");
        var senneville = new User("senneville", "", "Paul de Senneville");
        var paganini = new User("paganini", "", "Niccolò Paganini");
        var memeGod = new User("astley", "", "Rick Astley");
        var tchaikovsky = new User("tchaikovsky", "", "Pyotr Tchaikovsky");

        #endregion
        #region authors creation

        var mozartAuthor = new Author(mozart);
        var vivaldiAuthor = new Author(vivaldi);
        var beethovenAuthor = new Author(beethoven);
        var shostakovichAuthor = new Author(shostakovich);
        var chopinAuthor = new Author(chopin);
        var rimskyKorsakovAuthor = new Author(rimskyKorsakov);
        var lisztAuthor = new Author(liszt);
        var sennevilleAuthor = new Author(senneville);
        var paganiniAuthor = new Author(paganini);
        var memeGodAuthor = new Author(memeGod);
        var tchaikovskyAuthor = new Author(tchaikovsky);

        #endregion
        #region albums creation

        var fourSeasonsAlbum = new Album("The Four Seasons", vivaldiAuthor, AlbumType.Album, 1725);
        var moonlightAlbum = new Album("Moonlight Sonata", beethovenAuthor, AlbumType.Single, 1802);
        var waltzNo2Album = new Album("Waltz No. 2", shostakovichAuthor, AlbumType.Single, 1938);
        var fantaisieImpromptuAlbum = new Album("Fantaisie-Impromptu", chopinAuthor, AlbumType.Single, 1834);
        var taleofTsarSaltanAlbum = new Album("The Tale of Tsar Saltan", rimskyKorsakovAuthor, AlbumType.Album, 1900);
        var liebestraumAlbum = new Album("Liebestraum", lisztAuthor, AlbumType.Album, 1850);
        var grandesEtudesDePaganiniAlbum = new Album("Grandes études de Paganini", lisztAuthor, AlbumType.Album, 1851);
        var lettreAMaMereAlbum = new Album("Lettre à ma mère", sennevilleAuthor, AlbumType.Album, 1979);
        var requiemMozartAlbum = new Album("Requiem", mozartAuthor, AlbumType.Album, 1791);
        var marriageOfFigaroAlbum = new Album("The marriage of Figaro", mozartAuthor, AlbumType.Album, 1786);
        var violinConcertoNo2Album = new Album("Violin Concerto No. 2", paganiniAuthor, AlbumType.Album, 1826);
        var wheneverYouNeedSomebodyAlbum =
            new Album("Whenever you need somebody", memeGodAuthor, AlbumType.Album, 1987);
        var valseScherzoAlbum = new Album("Valse-Scherzo", tchaikovskyAuthor, AlbumType.Album, 1877);
        var pianoSonataNo11Album = new Album("Piano Sonata No. 11", mozartAuthor, AlbumType.Album, 1784);
        var hungarianRhapsodiesAlbum = new Album("Hungarian Rhapsodies", lisztAuthor, AlbumType.Album, 1885);

        #endregion
        // #region authors' albums populating
        //
        // mozartAuthor.AddAlbums(requiemMozartAlbum, marriageOfFigaroAlbum, pianoSonataNo11Album);
        // vivaldiAuthor.AddAlbums(fourSeasonsAlbum);
        // beethovenAuthor.AddAlbums(moonlightAlbum);
        // shostakovichAuthor.AddAlbums(waltzNo2Album);
        // chopinAuthor.AddAlbums(fantaisieImpromptuAlbum);
        // rimskyKorsakovAuthor.AddAlbums(taleofTsarSaltanAlbum);
        // lisztAuthor.AddAlbums(liebestraumAlbum, grandesEtudesDePaganiniAlbum, hungarianRhapsodiesAlbum);
        // sennevilleAuthor.AddAlbums(lettreAMaMereAlbum);
        // paganiniAuthor.AddAlbums(violinConcertoNo2Album);
        // memeGodAuthor.AddAlbums(wheneverYouNeedSomebodyAlbum);
        // tchaikovskyAuthor.AddAlbums(valseScherzoAlbum);
        //
        // #endregion
        #region genres creation

        var classicGenre = new Genre("Classic");
        var instrumentalGenre = new Genre("Instrumental");
        var jazzGenre = new Genre("Jazz");
        var newAgeGenre = new Genre("New Age");
        var popGenre = new Genre("Pop");

        #endregion
        #region tracks creation

        var storm = new Track("Summer - Storm", fourSeasonsAlbum); // classic, instrumental
        var spring = new Track("Spring", fourSeasonsAlbum); // classic, instrumental
        var moonlight = new Track("Moonlight Sonata", moonlightAlbum); // classic, instrumental
        var waltzNo2 = new Track("Waltz No. 2", waltzNo2Album); // classic, jazz
        var fantasieImpromptu = new Track("Fantaisie Impromptu", fantaisieImpromptuAlbum); // classic, instrumental
        var flightOfBumblemee = new Track("Flight of the Bumblebee", taleofTsarSaltanAlbum); // classic, instrumental
        var laCampanellaLiszt = new Track("La Campanella", grandesEtudesDePaganiniAlbum); // classic, instrumental
        var loveDream = new Track("Love Dream", liebestraumAlbum); // classic, instrumental
        var marriegeDAmour = new Track("Marriage d'Amour", lettreAMaMereAlbum); // newage, instrumental
        var lacrimosa = new Track("Lacrimosa", requiemMozartAlbum); // classic
        var marriageOfFigaro = new Track("Marriage of Figaro - Overture", marriageOfFigaroAlbum); // classic, instrumental
        var laCampanellaPaganini = new Track("La Campanella", violinConcertoNo2Album); // classic, instrumental
        var rickroll = new Track("Never gonna give you up", wheneverYouNeedSomebodyAlbum); // pop
        var valseSentimental = new Track("Valse Sentimental", valseScherzoAlbum); // classic, instrumental
        var turkishMarch = new Track("Turkish March", pianoSonataNo11Album); // classic, instrumental
        var hungarianRhapsodyNo2 = new Track("Hungarian Rhapsody No. 2", hungarianRhapsodiesAlbum); // classic, instrumental

        #endregion
        // #region albums populating
        //
        // fourSeasonsAlbum.AddTracks(storm, spring);
        // moonlightAlbum.AddTracks(moonlight);
        // waltzNo2Album.AddTracks(waltzNo2);
        // fantaisieImpromptuAlbum.AddTracks(fantasieImpromptu);
        // taleofTsarSaltanAlbum.AddTracks(flightOfBumblemee);
        // grandesEtudesDePaganiniAlbum.AddTracks(laCampanellaLiszt);
        // liebestraumAlbum.AddTracks(loveDream);
        // lettreAMaMereAlbum.AddTracks(marriegeDAmour);
        // requiemMozartAlbum.AddTracks(lacrimosa);
        // marriageOfFigaroAlbum.AddTracks(marriageOfFigaro);
        // violinConcertoNo2Album.AddTracks(laCampanellaPaganini);
        // wheneverYouNeedSomebodyAlbum.AddTracks(rickroll);
        // valseScherzoAlbum.AddTracks(valseSentimental);
        // pianoSonataNo11Album.AddTracks(turkishMarch);
        // hungarianRhapsodiesAlbum.AddTracks(hungarianRhapsodyNo2);
        //
        // #endregion
        #region db populating

        modelBuilder.Entity<User>().HasData(mozart, vivaldi, beethoven, shostakovich, chopin, rimskyKorsakov, liszt,
            senneville, paganini, memeGod, tchaikovsky);
        modelBuilder.Entity<Author>().HasData(mozartAuthor, vivaldiAuthor, beethovenAuthor, shostakovichAuthor,
            chopinAuthor, rimskyKorsakovAuthor, lisztAuthor, sennevilleAuthor, paganiniAuthor, memeGodAuthor,
            tchaikovskyAuthor);
        modelBuilder.Entity<Genre>().HasData(classicGenre, instrumentalGenre, jazzGenre, newAgeGenre, popGenre);
        modelBuilder.Entity<Album>().HasData(fourSeasonsAlbum, moonlightAlbum, waltzNo2Album, fantaisieImpromptuAlbum,
        taleofTsarSaltanAlbum, grandesEtudesDePaganiniAlbum, liebestraumAlbum, lettreAMaMereAlbum,
        requiemMozartAlbum, marriageOfFigaroAlbum, violinConcertoNo2Album, wheneverYouNeedSomebodyAlbum,
        valseScherzoAlbum, pianoSonataNo11Album, hungarianRhapsodiesAlbum);
        modelBuilder.Entity<Track>().HasData(storm, spring, moonlight, waltzNo2, fantasieImpromptu, flightOfBumblemee,
            laCampanellaLiszt, loveDream, marriegeDAmour, lacrimosa, marriageOfFigaro, laCampanellaPaganini, rickroll,
            valseSentimental, turkishMarch, hungarianRhapsodyNo2);

        #endregion
    }
}