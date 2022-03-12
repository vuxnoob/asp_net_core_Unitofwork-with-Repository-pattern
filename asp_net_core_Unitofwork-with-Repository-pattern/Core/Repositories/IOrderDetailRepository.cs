using asp_net_core_Unitofwork_with_Repository_pattern.Core.Model;
using System.Collections.Generic;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories
{
	public interface IOrderDetailRepository : IRepository<OrderDetails>
    {
        IEnumerable<OrderDetails> GetByOrderId(int orderId);
    }
}
