using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.net.Models;

namespace task6.net.Extensions
{
    public static class OrderExtensions
    {
        public static string FormatMessage(this Order order)
        {
            return $"Order #{order.Id} for {order.CustomerName} costs {order.Price}";
        }
    }
}
