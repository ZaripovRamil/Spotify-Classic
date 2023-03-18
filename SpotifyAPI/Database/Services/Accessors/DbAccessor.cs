namespace Database.Services.Accessors;

public abstract class DbAccessor
{
    protected AppDbContext DbContext { get; }

    protected DbAccessor(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }
}