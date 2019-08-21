
using System.Configuration;

namespace CIDFares.Spa.DataAccess.Repositories.Base
{
    public abstract class Repository
    {
        private readonly string _ConnectionString;
        protected string ConnectionString
        {
            get { return _ConnectionString; }
        }
        private readonly string _WebConnectionString;

        protected string WebConnectionString
        {
            get { return _WebConnectionString; }
        }


        public Repository()
        {
            //_ConnectionString = ConfigurationManager.ConnectionStrings["strLocalConnection"].ConnectionString;
            _WebConnectionString = ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString;
        }
    }
}
