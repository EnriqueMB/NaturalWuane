using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> ExistAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<int> DeleteAsync(object id);
        Task<T> UpdateAsync(T element);
        Task<T> AddAsync(T element);
    }
}
