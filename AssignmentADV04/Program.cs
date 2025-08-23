using AssignmentADV04.Task;

namespace AssignmentADV04
{
    internal class Program
    {
        static IEnumerable<Product> PrintProducts(IEnumerable<Product> product)
        {
            foreach (var item in product)
            {
                Console.WriteLine(item);
            }
            return product;
        }
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.

            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);

            //var Result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //PrintProducts(Result);

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);

            //var Result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0 && P.UnitPrice > 3
            //             select P;

            //PrintProducts(Result);

            #endregion

            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock

            //var Result = ListGenerator.ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //var Result = (from P in ListGenerator.ProductList
            //              where P.UnitsInStock == 0
            //              select P).FirstOrDefault();

            //Console.WriteLine(Result);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ListGenerator.ProductList.FirstOrDefault(P => P.UnitPrice > 1000);

            //var Result = (from P in ListGenerator.ProductList
            //             where P.UnitPrice > 1000
            //             select P).FirstOrDefault();

            //Console.WriteLine(Result?.ProductName ?? "NA");

            #endregion

            #endregion
        }
    }
}
