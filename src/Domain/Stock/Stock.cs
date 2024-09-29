namespace Domain.Stock
{
    public class Stock
    {
        public Stock() { }  

        public StockType Type { get; set; }
        public required Guid ProductId { get; set; }
        public required int Quantity { get; set; }
    }
}
