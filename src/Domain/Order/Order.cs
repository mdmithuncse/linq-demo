using SharedKernel;

namespace Domain.Order
{
    public class Order : Audit
    {
        public Order() { }

        public required Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public required IList<OrderItem> Items { get; set; }
        public required decimal TotalDiscount { get; set; }
        public required decimal TotalAmount { get; set; }
    }
}
