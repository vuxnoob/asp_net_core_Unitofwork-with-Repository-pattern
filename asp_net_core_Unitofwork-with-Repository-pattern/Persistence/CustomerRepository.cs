using asp_net_core_Unitofwork_with_Repository_pattern.Core.Model;
using asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories;
using asp_net_core_Unitofwork_with_Repository_pattern.DBContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Persistence
{
	public class CustomerRepository : Repository<Customers>, ICustomerRepository
	{
		public CustomerRepository(DbContext context) : base(context)
		{
		}

		// DI setter
		public NorthwindContext NorthwindContext
		{
			get { return Context as NorthwindContext; }
		}

		public IEnumerable<Customers> GetCustomerByCity(string city)
		{
			return NorthwindContext.Customers.Where(cw => cw.City == city).ToList();
		}
	}
}
