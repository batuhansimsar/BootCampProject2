using BootcampProject.Repositories.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampProject.Repositories.Repositories
{
    // Generic repository sınıfı, CRUD işlemlerinin gerçek implementasyonunu sağlar

    public class EfRepository<T> : IRepository<T> where T : class
    {
        private readonly BootcampDbContext _context;
        private readonly DbSet<T> _dbSet;

        public EfRepository(BootcampDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        //Yeni bir entity ekler
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        //Var olan entity'yi günceller
        public async Task UpdateAyncs(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        //Entityi siler
        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        //Tüm entityleri getirir
        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
