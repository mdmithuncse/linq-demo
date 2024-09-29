using SharedKernel;

namespace Domain.PromotionalOffers
{
    public class Discount : Audit
    {
        public Discount() { }
        
        public required DiscountType Type { get; set; }
        public required string Promotion {  get; set; }
        public required string Description { get; set; }
    }
}
