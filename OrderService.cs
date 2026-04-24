using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.net.Models;

namespace task6.net.Services
{
    internal class OrderService
    {
        public event Action<Order>? OnOrderPlaced;
        public void PlaceOrder(Order order)
        {
            Console.WriteLine("Order Placed");

            Func<Order, bool> filter = o => o.Price > 100;

            if (filter(order))
            {
                OnOrderPlaced?.Invoke(order);
            }
        }

    }
}
