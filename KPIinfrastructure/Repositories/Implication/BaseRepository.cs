﻿using KPIdomain.Common;
using KPIdomain.Exceptions;
using KPIinfrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KPIinfrastructure.Repositories.Implication
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbset;

        protected BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }

        public async Task<int> AddIntAsync(TEntity entity)
        {
            try
            {
                var addedEntity = (await _dbset.AddAsync(entity)).Entity;
                await _context.SaveChangesAsync();

                return addedEntity != null ? 1 : 0;
            }
            catch (Exception ex)

            {
                return 0;
            }
        }

        public async Task<TEntity?> AddAsync(TEntity entity)
        {
            try
            {
                var addedEntity = (await _dbset.AddAsync(entity)).Entity;
                await _context.SaveChangesAsync();

                return addedEntity;
            }
            catch (Exception ex)
            {
                return null; //✅ 
            }
        }

        public async Task<TEntity?> DeleteAsync(TEntity entity)
        {
            try
            {
                var removedEntity = _dbset.Remove(entity).Entity;
                await _context.SaveChangesAsync();
                return removedEntity;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<TEntity> GetAllAsEnumurable()
        {
            return _dbset.AsEnumerable();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbset.Where(predicate).ToListAsync();
        }
        public IQueryable<TEntity> GetAll() =>
            _dbset.AsQueryable();

        public async Task<TEntity> GetFirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await _dbset.Where(predicate).FirstOrDefaultAsync();

            if (entity == null) throw new ResourceNotFound(typeof(TEntity));

            return await _dbset.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<List<TEntity>?> GetAllAsync()
        {
            try
            {

                var result = await _dbset.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
