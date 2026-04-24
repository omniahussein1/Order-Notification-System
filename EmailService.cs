using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.net.Models;

namespace task6.net.Services
{
    internal class EmailService
    {
        public void SendEmail(Order order)
        {
            Console.WriteLine($"Email sent for order {order.Id}");
        }
    }
}
