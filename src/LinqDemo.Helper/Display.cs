using LinqDemo.DataSource;

namespace LinqDemo.Helper
{
    public static class Display
    {
        public static void Print<T>(ICollection<T> values)
        {
            foreach (var item in values)
            {
                Console.Write(item + " ");
            }
        }

        public static void PrintProducts(ICollection<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"Id: { product.Id }, Name: { product.Name }, Price: { product.Price }");
            }
        }
    }
}
