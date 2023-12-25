using Microsoft.EntityFrameworkCore;
using MicroWebExample.Application.Interfaces;
using MicroWebExample.Domain.Common;
using MicroWebExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MicroWebExample.Persistence.Repositories
{
    public class BaseRepository<T, TE> : IBaseRepository<T, TE> where T : BaseEntity<TE>
    {
        private readonly ApplicationDbContext _dataContext;

        public BaseRepository(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task AddAsync(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
            ? await _dataContext.Set<T>().ToListAsync()
                    : await _dataContext.Set<T>().Where(filter).ToListAsync();
        }

        public  async Task<T> GetByIdAsync(TE id)
        {
            return await _dataContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            var Entity = await _dataContext.Set<T>().FindAsync(entity.Id);
            if (Entity != null)
            {
                _dataContext.Set<T>().Remove(Entity);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity)
        {
            var updateEntity = await _dataContext.Set<T>().FindAsync(entity.Id);
            if (updateEntity != null)
            {
                _dataContext.Set<T>().Update(updateEntity);
              await  _dataContext.SaveChangesAsync();
            }
        }
    }
}
