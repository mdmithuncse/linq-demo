using System.Collections.ObjectModel;

namespace LinqDemo.DataSource
{
    public static class Number
    {
        public static ICollection<int> GetNumbers(int length)
        {
            ICollection<int> result = new Collection<int>();

            for (int i = 0; i <= length; i++)
            {
                result.Add(i);
            }

            return result;
        }
    }
}
