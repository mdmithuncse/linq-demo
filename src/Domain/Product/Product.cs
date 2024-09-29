using SharedKernel;

namespace Domain.Product
{
    public class Product : Audit
    {
        public Product() { }

        public required Guid CategoryId { get; set; }
        public Guid? DiscountId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal PurchasePrice { get; set; }
        public required decimal CostPrice { get; set; }
        public required decimal RetailPrice { get; set; }
        public required decimal WholesalePrice { get; set; }
    }
}
