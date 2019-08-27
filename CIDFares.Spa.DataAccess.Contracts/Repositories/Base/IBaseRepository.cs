using System.Collections.Generic;
using System.Threading.Tasks;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> ExistAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetAsync(object id);
        Task<int> DeleteAsync(object id);

        Task<T> UpdateAsync(T element);
        Task<T> AddAsync(T element);
        Task<int> NameExistAsync(string name);
    }
}
