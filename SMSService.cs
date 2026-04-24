using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task6.net.Models;

namespace task6.net.Services
{
    public class SMSService
    {
        public void SendSMS(Order order)
        {
            Console.WriteLine($"SMS sent for order {order.Id}");
        }
    }
}
