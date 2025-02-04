using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;
using System.Linq.Expressions;

namespace Healthy_Apetite_Backend.Repos.Base
{
    public interface IBaseRepo <TEntity> where TEntity : class , IDbEntity<TEntity>, new()
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
        public Task<ControllerResponse> UpdateAsync(TEntity entity);
        public Task<ControllerResponse> CreateAsync(TEntity entity);
        public Task<ControllerResponse> DeleteAsync(Guid id);
    }
}
