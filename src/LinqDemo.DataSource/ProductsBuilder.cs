namespace LinqDemo.DataSource
{
    public static class ProductsBuilder
    {
        public static IList<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 101,
                    Name = "Bread",
                    Price = 100M
                },

                new Product
                {
                    Id = 102,
                    Name = "Boiled Rice",
                    Price = 40M
                },

                new Product
                {
                    Id = 103,
                    Name = "Half Boiled Rice",
                    Price = 30M
                },

                new Product
                {
                    Id = 104,
                    Name = "Milk",
                    Price = 120M
                },

                new Product
                {
                    Id = 105,
                    Name = "Spaghetti",
                    Price = 220M
                },

                new Product
                {
                    Id = 106,
                    Name = "Whiskey",
                    Price = 500M
                },

                new Product
                {
                    Id = 107,
                    Name = "Wine",
                    Price = 750M
                },

                new Product
                {
                    Id = 108,
                    Name = "Washing Poweder",
                    Price = 420M
                },

                new Product
                {
                    Id = 109,
                    Name = "Body Lotion",
                    Price = 250M
                },

                new Product
                {
                    Id = 110,
                    Name = "Liquid Body Wash",
                    Price = 360M
                }
            };
        }
    }
}
