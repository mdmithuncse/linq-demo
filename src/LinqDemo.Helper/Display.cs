using LinqDemo.DataSource;
using LinqDemo.DataSource.Relationships.OneToOne;

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

        public static void PrintProfiles(ICollection<UserProfile> profiles)
        {
            foreach (UserProfile profile in profiles)
            {
                Console.WriteLine($"Profile Id: { profile.Id }, Bio: { profile.Bio }, User Id: { profile.User.Id }, User Name: { profile.User.Name }");
            }
        }

        public static void PrintUsers(ICollection<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"User Id: { user.Id }, Name: { user.Name }, Profile Id: { user.Profile.Id }, Bio: { user.Profile.Bio }, User Id: { user.Profile.User.Id }, User Name: { user.Profile.User.Name }");
            }
        }
    }
}
