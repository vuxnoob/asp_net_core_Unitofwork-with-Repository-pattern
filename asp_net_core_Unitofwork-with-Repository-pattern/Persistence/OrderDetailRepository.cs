using asp_net_core_Unitofwork_with_Repository_pattern.Core.Model;
using asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories;
using asp_net_core_Unitofwork_with_Repository_pattern.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Persistence
{
	public class OrderDetailRepository : Repository<OrderDetails>, IOrderDetailRepository
	{
		public OrderDetailRepository(DbContext context) : base(context)
		{
		}

		// DI setter
		public NorthwindContext NorthwindContext
		{
			get { return Context as NorthwindContext; }
		}

		public IEnumerable<OrderDetails> GetByOrderId(int orderId)
		{
			return NorthwindContext.OrderDetails.Where(x => x.OrderId == orderId).ToList();
		}
	}
}
