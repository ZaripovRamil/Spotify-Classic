namespace DatabaseServices.Infrastructure.Specs;

public interface IQueryableFilter<T> where T : class
{
    IQueryable<T> Apply(IQueryable<T> query);
}