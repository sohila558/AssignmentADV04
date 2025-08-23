using AssignmentADV04.Task;
using System.Collections.Frozen;
using System.ComponentModel.DataAnnotations;
using System.Threading;

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

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count(N => N % 2 != 0);

            //Console.WriteLine(Result);

            #endregion

            #region 2. Get the total of the numbers in an array. Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count();

            //Console.WriteLine(Result);

            #endregion

            #region 3. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Arr = { "dictionary", "_", "english", ".", "txt" };

            //var Result = Arr.Select(S => S.Length).Sum();

            //Console.WriteLine(Result);

            #endregion

            #region 4. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Arr = { "dictionary", "_", "english", ".", "txt" };

            //var Result = Arr.Select(W => W.Length).Min();

            //Console.WriteLine(Result);

            #endregion

            #region 5. Get the total units in stock for each product category.

            //var Result = ListGenerator.ProductList.GroupBy(P => P.Category).Select(P => new { CategoryName = P.Key, TotalUnitsInStock = P.Sum(P => P.UnitsInStock) });


            //var Result = from P in ListGenerator.ProductList
            //             group P by P.Category
            //             into Category
            //             select new { CategoryName = Category.Key, TotalUnitsInStock = Category.Sum(P => P.UnitsInStock) };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 6. Get the cheapest price among each category's products

            //var Result = ListGenerator.ProductList.GroupBy(P => P.Category).Select(P => new { CategoryName = P.Key, CheapestProduct = P.Min(P => P.UnitPrice) });

            //var Result = from P in ListGenerator.ProductList
            //             group P by P.Category
            //             into CheapestProduct
            //             select new { CategoryName = CheapestProduct.Key, CheapestProduct = CheapestProduct.Min(P => P.UnitPrice) };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7. Get the products with the cheapest price in each category (Use Let)

            //var Result = from P in ListGenerator.ProductList
            //             let MinPrice = (from M in ListGenerator.ProductList
            //                             where M.Category == P.Category
            //                             select M.UnitPrice).Min()
            //             where P.UnitPrice == MinPrice
            //             select new { P.Category, P.ProductName, P.UnitPrice };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 8. Get the average price of each category's products.

            //var Result = ListGenerator.ProductList.GroupBy(P => P.Category).Select(P => new { CategoryName = P.Key, AverragePrice = P.Average(P => P.UnitPrice) });

            //var Result = from P in ListGenerator.ProductList
            //             group P by P.Category
            //             into AveragePrice
            //             select new { CategoryName = AveragePrice.Key, AveragePrice = AveragePrice.Average(P => P.UnitPrice) };


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var Result = ListGenerator.ProductList.OrderBy(P => P.ProductName); 

            //PrintProducts(Result);

            #endregion

            #region 2. Sort a list of products by units in stock from highest to lowest.

            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.UnitsInStock);

            //PrintProducts(Result);

            #endregion

            #region 3. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A => A);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //PrintProducts(Result);

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(W => W.Length).ThenByDescending(W => W, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 6. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();                                       // نعكس الترتيب

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

        }
    }
}
