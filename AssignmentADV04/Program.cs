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

            //PrintProducts(Result);

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            #endregion

            #endregion
        }
    }
}
