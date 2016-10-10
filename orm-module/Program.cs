using System;
using System.Linq;

using orm_module.Entities;

namespace orm_module
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Northwind context = new Northwind())
            {
                IQueryable<Order> orders = context.Order_Details
                    .Where(od => od.ProductID == 1)
                    .Select(od => od.Order);

                foreach(var order in orders)
                {
                    Console.WriteLine($"Order id: {order.OrderID}");
                    Console.WriteLine($"Customer name: {order.Customer.ContactName}");

                    Console.WriteLine("\nProducts list:");
                    foreach (Order_Detail details in order.Order_Details)
                    {
                        Console.WriteLine(details.Product.ProductName);
                    }

                    Console.WriteLine("-------------\n");
                }
            }
        }
    }
}
