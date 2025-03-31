namespace Sashiel_ST10028058_PROG7311_ICETask2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new();

        public decimal TotalAmount => Products.Sum(p => p.Price);
    }
}
