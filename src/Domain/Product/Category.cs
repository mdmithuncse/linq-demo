using SharedKernel;

namespace Domain.Product
{
    public class Category : Audit
    {
        public Category() { }

        public Priority Rank { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
