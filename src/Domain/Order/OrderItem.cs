using Domain.Product;
using SharedKernel;

namespace Domain.Order
{
    public class OrderItem : Audit
    {
        public OrderItem() { }

        public required Guid ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; }
        public Category Category { get; set; }
    }
}
