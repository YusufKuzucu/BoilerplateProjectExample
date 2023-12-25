


using MicroWebExample.Domain.Common;
using System.Linq.Expressions;

namespace MicroWebExample.Application.Interfaces
{
    public interface IBaseRepository<T, TE> where T : BaseEntity<TE>
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetByIdAsync(TE id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }


}
