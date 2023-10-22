using Database;

namespace DatabaseServices.Services.Repositories.Implementations;

public abstract class Repository
{
    protected AppDbContext DbContext { get; }

    protected Repository(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }
}