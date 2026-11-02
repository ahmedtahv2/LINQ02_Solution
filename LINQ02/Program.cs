using static LINQ02.Source;
namespace LINQ02


{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var result = ProductList.OrderByDescending(p => p.UnitPrice)
            //                          .Take(3); 
            #endregion

            #region Q2
            //var result = ProductList.Skip(5).Take(5); 
            #endregion



            foreach (var product in result)
                Console.WriteLine(product);

        }
    }
}
