
namespace SplashOrders.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer? Customer { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
