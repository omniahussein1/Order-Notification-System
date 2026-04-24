using task6.net.Models;
using task6.net.Services;
using task6.net.Extensions;


 public class Program
{
    static void Main()
    {
        var orderService = new OrderService();
        var email = new EmailService();
        var sms = new SMSService();

        orderService.OnOrderPlaced += email.SendEmail;
        orderService.OnOrderPlaced += sms.SendSMS;

        orderService.OnOrderPlaced += o =>
            Console.WriteLine(o.FormatMessage());

        var order = new Order
        {
            Id = 1,
            CustomerName = "Ali",
            Price = 150
        };

        orderService.PlaceOrder(order);
    }
}