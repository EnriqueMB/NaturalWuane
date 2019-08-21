using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;

namespace CIDFares.Spa.DataAccess.Contracts.Repositories.General
{
    public interface ILoginRepository
    {
        Task<LoginRequests> Login(string Account, string Password);
    }
}
