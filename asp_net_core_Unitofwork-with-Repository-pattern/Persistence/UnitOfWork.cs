using asp_net_core_Unitofwork_with_Repository_pattern.Core;
using asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories;
using asp_net_core_Unitofwork_with_Repository_pattern.DBContext;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Persistence
{
	public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext _context;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            Customers = new CustomerRepository(_context);
            OrderDetails = new OrderDetailRepository(_context);
        }

        public IOrderRepository Orders { get; set; }

        public ICustomerRepository Customers { get; set; }

        public IOrderDetailRepository OrderDetails { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
