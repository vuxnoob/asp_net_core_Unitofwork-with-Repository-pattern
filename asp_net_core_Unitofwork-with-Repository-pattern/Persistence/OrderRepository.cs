using asp_net_core_Unitofwork_with_Repository_pattern.Core.Model;
using asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories;
using asp_net_core_Unitofwork_with_Repository_pattern.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Persistence
{
	public class OrderRepository : Repository<Orders>, IOrderRepository
	{
		public OrderRepository(DbContext context) : base(context)
		{
		}

		// DI setter
		public NorthwindContext NorthwindContext
		{
			get { return Context as NorthwindContext; }
		}

		public IEnumerable<Orders> GetOrdersWithCustomers(int pageIndex, int pageSize, string customerId)
		{
			return NorthwindContext.Orders
				.Where(o => o.CustomerId == customerId)
				.OrderBy(c => c.OrderId)
				.Skip((pageIndex - 1) * pageSize)
				.Take(pageSize)
				.ToList();
		}

		public IEnumerable<Orders> GetTopOrders(int count)
		{
			return NorthwindContext.Orders.OrderByDescending(c => c.OrderId).Take(count).ToList();
		}
	}
}
