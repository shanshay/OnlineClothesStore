﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using OnlineClothesStore.Store.Core.Domain;

namespace OnlineClothesStore.Store.Core.Abstractions.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetRangeByIdsAsync(List<int> ids);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
