using static LINQ02.Source;
namespace LINQ02


{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = ProductList.OrderByDescending(p => p.UnitPrice)
                                  .Take(3);

            foreach (var product in result)
                Console.WriteLine(product);

        }
    }
}
