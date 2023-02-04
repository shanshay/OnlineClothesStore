using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace OnlineClothesStore.Store.Core.Abstractions.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetRangeByIdsAsync(List<int> ids);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

    }
}
