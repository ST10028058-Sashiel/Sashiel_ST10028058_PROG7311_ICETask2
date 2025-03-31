using Microsoft.AspNetCore.Mvc;
using Sashiel_ST10028058_PROG7311_ICETask2.Models;
using Sashiel_ST10028058_PROG7311_ICETask2.Services;

namespace Sashiel_ST10028058_PROG7311_ICETask2.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        //  Step 1: Show available products
        [HttpGet]
        public IActionResult Create()
        {
            var availableProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1000 },
                new Product { Id = 2, Name = "Mouse", Price = 50 },
                new Product { Id = 3, Name = "Keyboard", Price = 150 }
            };

            return View(availableProducts);
        }

        //  Step 2:Handle form submission
        [HttpPost]
        public IActionResult Place(List<int> selectedProductIds)
        {
            var allProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1000 },
                new Product { Id = 2, Name = "Mouse", Price = 50 },
                new Product { Id = 3, Name = "Keyboard", Price = 150 }
            };

            var selectedProducts = allProducts
                .Where(p => selectedProductIds.Contains(p.Id))
                .ToList();

            var order = new Order
            {
                Id = 1,
                Products = selectedProducts
            };

            _orderService.PlaceOrder(order);

            ViewBag.Message = "Order has been placed successfully!";
            return View("PlaceOrder"); //  Load the renamed view
        }
    }
}
