using asp_net_core_Unitofwork_with_Repository_pattern.Core.Model;
using System.Collections.Generic;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories
{
	public interface ICustomerRepository : IRepository<Customers>
    {
        IEnumerable<Customers> GetCustomerByCity(string city);
    }
}