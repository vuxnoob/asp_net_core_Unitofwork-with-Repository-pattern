using asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories;
using System;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Core
{
	public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        ICustomerRepository Customers { get; }
        IOrderDetailRepository OrderDetails { get; }
        int Complete();
    }
}