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

            #region Q3
            //var result = ProductList.OrderBy(p => p.UnitPrice)
            //                        .TakeWhile(p => p.UnitPrice < 25m); 
            #endregion

            #region Q4
            //        bool resut2 = ProductList.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);
            //        Console.WriteLine(resut2); 
            #endregion

            #region Q5
            //int[] ids = { 3, 9, 13, 18 };

            //bool result2 = ids.Contains(9);
            //Console.WriteLine(result2); 
            #endregion

            //foreach (var product in result)
            //    Console.WriteLine(product);

        }
    }
}
