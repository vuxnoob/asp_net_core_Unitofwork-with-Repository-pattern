using asp_net_core_Unitofwork_with_Repository_pattern.Core.Model;
using System.Collections.Generic;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories
{
	public interface IOrderRepository : IRepository<Orders>
    {
        IEnumerable<Orders> GetTopOrders(int count);
        IEnumerable<Orders> GetOrdersWithCustomers(int pageIndex, int pageSize, string customerId);
    }
}
