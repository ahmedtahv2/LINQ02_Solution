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

            #region Q6
            //var categoryGroups = ProductList.GroupBy(p => p.Category);

            //foreach (var group in categoryGroups)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()} products");
            //} 
            #endregion

            #region Q8
            //        var result = ProductList.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);
            #endregion

            #region Q10
            //int totalUnitsInStock = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(totalUnitsInStock); 
            #endregion

            #region Q11
            //decimal cheapestPrice = ProductList.Min(p => p.UnitPrice);
            //decimal mostExpensivePrice = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest: {cheapestPrice}");
            //Console.WriteLine($"Most: {mostExpensivePrice}"); 
            #endregion

            #region Q12
            //        var result = ProductList.Select(p => p.Category).Distinct(); 
            #endregion

            //foreach (var product in result)
            //    Console.WriteLine(product);

        }
    }
}
