using System.Linq.Expressions;

namespace DatabaseServices.Infrastructure.Specs;

public static class ExpressionsExtensions
{
    public static Specification<T> AsSpec<T>(this Expression<Func<T, bool>> expr)
        where T : class => new(expr);
}