using asp_net_core_Unitofwork_with_Repository_pattern.DBContext;
using asp_net_core_Unitofwork_with_Repository_pattern.Persistence;
using System;

namespace asp_net_core_Unitofwork_with_Repository_pattern
{
	class Program
	{
		static void Main(string[] args)
		{
            using (var unitOfWork = new UnitOfWork(new NorthwindContext()))
            {

                // Example1
                var customersByCity = unitOfWork.Customers.GetCustomerByCity("London");

                // Example2
                var customers = unitOfWork.Customers.GetAll();

                // Example3
                var order = unitOfWork.Orders.Get(10250);
                var orderDetails = unitOfWork.OrderDetails.GetByOrderId(order.OrderId);
                unitOfWork.OrderDetails.RemoveRange(orderDetails);
                unitOfWork.Orders.Remove(order);
                unitOfWork.Complete();

                Console.WriteLine("Done!");
            }
        }
	}
}
