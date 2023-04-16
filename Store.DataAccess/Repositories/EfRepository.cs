﻿using Microsoft.EntityFrameworkCore;
using OnlineClothesStore.Store.Core.Abstractions.Repositories;
using OnlineClothesStore.Store.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClothesStore.Store.DataAccess.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly OnlineClothesStoreContext _dataContext;

        public EfRepository(OnlineClothesStoreContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await _dataContext.Set<T>().ToListAsync();
            return entities;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

            return entity;
        }

        public async Task<IEnumerable<T>> GetRangeByIdsAsync(List<int> ids)
        {
            var entities = await _dataContext.Set<T>().Where(x => ids.Contains(x.Id)).ToListAsync();
            return entities;
        }

        public async Task CreateAsync(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync();
        }
    }
}
