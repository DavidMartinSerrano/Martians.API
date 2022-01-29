using Microsoft.EntityFrameworkCore;
using Robot.Core.Repositories.Base;
using Robot.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Infrastructure.Repository.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly RobotContext _robotContext;

        public GenericRepository(RobotContext robotContext)
        {
            _robotContext = robotContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _robotContext.Set<T>().AddAsync(entity);
            await _robotContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _robotContext.Set<T>().Remove(entity);
            await _robotContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _robotContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _robotContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() =>
            {
                _robotContext.Set<T>().Attach(entity);
                _robotContext.Entry(entity).State = EntityState.Modified;
            });
            await _robotContext.SaveChangesAsync();
        }
    }
}
