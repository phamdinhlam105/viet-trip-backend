﻿using Microsoft.EntityFrameworkCore;
using viet_trip_backend.Data;
using viet_trip_backend.Interfaces;
using viet_trip_backend.Interfaces.Repositories;

namespace viet_trip_backend.Repositories
{
    public class BaseRepository<T>: IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            _context.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual async Task Delete(T entity)
        {

            if (entity is ISoftDeletetable softDeletable)
            {
                softDeletable.IsDeleted = true;
                _context.Update(entity);
            }
            else
            {
                _dbSet.Remove(entity);
            }

            await _context.SaveChangesAsync();
        }

    }
}
