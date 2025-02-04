using HealthyApetite.Shared.Models;
using System.Linq.Expressions;

namespace Healthy_Apetite_Backend.Repos.Base
{
    public static class IQuerybleExtension
    {
        public static IQueryable<TEntity> FindByCondition<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, bool>> expression)
            where TEntity : class, IDbEntity<TEntity>,new()
        {
            return query.Where(expression);
        }
    }
}
