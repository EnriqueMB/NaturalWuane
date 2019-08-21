using System;
using System.Threading.Tasks;
using CIDFares.Spa.DataAccess.Contracts.DTOs.Requests;
using CIDFares.Spa.DataAccess.Contracts.Repositories.General;

namespace CIDFares.Spa.DataAccess.Repositories.General
{
    public class LoginRepository : ILoginRepository
    {
        public Task<LoginRequests> Login(string Account, string Password)
        {
            throw new NotImplementedException();
        }

    }
}
