using System;
using Sashiel_ST10028058_PROG7311_ICETask2.Models;

namespace Sashiel_ST10028058_PROG7311_ICETask2.Services
{
    public class OrderService : IOrderService
    {
        public void PlaceOrder(Order order)
        {
            Console.WriteLine("✅ Order placed successfully!");
            Console.WriteLine("🛒 Products:");

            foreach (var product in order.Products)
            {
                Console.WriteLine($"- {product.Name} - ${product.Price}");
            }

            Console.WriteLine($"💰 Total Amount: ${order.TotalAmount}");
        }
    }
}
