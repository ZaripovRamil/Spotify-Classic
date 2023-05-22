using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Statistics;

public class GenreData
{
    public GenreData(GenreLight genre, int count)
    {
        Genre = genre;
        Count = count;
    }

    public GenreLight Genre { get; set; }
    public int Count { get; set; }
}