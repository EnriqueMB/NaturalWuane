using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> ExistAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task DeleteAsync(int id);
        Task<T> UpdateAsync(int id);
        Task<T> AddAsync(T element);
    }
}
