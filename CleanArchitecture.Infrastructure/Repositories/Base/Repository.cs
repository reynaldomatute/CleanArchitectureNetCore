using CleanArchitectura.Core.Repositories.Base;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly CleanArchitectureCotext _cleanArchitectureCotext;
        public Repository(CleanArchitectureCotext cleanArchitectureCotext)
        {
            _cleanArchitectureCotext = cleanArchitectureCotext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _cleanArchitectureCotext.Set<T>().AddAsync(entity);
            await _cleanArchitectureCotext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _cleanArchitectureCotext.Set<T>().Remove(entity);
            await _cleanArchitectureCotext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _cleanArchitectureCotext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _cleanArchitectureCotext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
