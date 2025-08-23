using System.Collections.Frozen;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            //var Result = from A in Arr
            //             where A % 2 != 0
            //             select A;

            //Console.WriteLine(Result);

            #endregion

            #region 2. Get the total of the numbers in an array. Int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count();

            //var Result = (from A in Arr
            //              select A).Count();

            //Console.WriteLine(Result);

            #endregion

            #region 3. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Arr = { "dictionary", "_", "english", ".", "txt" };

            //var Result = Arr.Select(S => S.Length).Sum();

            //var Result = (from A in Arr
            //              select A.Length).Sum();

            //Console.WriteLine(Result);

            #endregion

            #region 4. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] Arr = { "dictionary", "_", "english", ".", "txt" };

            //var Result = Arr.Select(W => W.Length).Min();

            //var Result = (from A in Arr
            //              select A.Length).Min();

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

            //var Result = from P in ListGenerator.ProductList
            //             orderby P.ProductName
            //             select P;

            //PrintProducts(Result);

            #endregion

            #region 2. Sort a list of products by units in stock from highest to lowest.

            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.UnitsInStock);

            //var Result = from P in ListGenerator.ProductList
            //             orderby P.UnitsInStock descending
            //             select P;  

            //PrintProducts(Result);

            #endregion

            #region 3. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.OrderBy(A => A.Length).ThenBy(A => A);

            //var Result = from A in Arr
            //             orderby A.Length, A
            //             select A;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ListGenerator.ProductList.OrderByDescending(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //var Result = from P in ListGenerator.ProductList
            //             orderby P.Category descending, P.UnitPrice descending
            //             select P;

            //PrintProducts(Result);

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(W => W.Length).ThenByDescending(W => W, StringComparer.OrdinalIgnoreCase);

            //var Result = from A in Arr
            //             orderby A.Length, A descending, StringComparer.OrdinalIgnoreCase
            //             select A;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 6. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();

            //var Result = (from A in Arr
            //              where A.Length > 1 && A[1] == 'i'
            //              select A).Reverse();


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var Result = ListGenerator.ProductList.Select(P => P.ProductName);

            //var Result = from P in ListGenerator.ProductList
            //             select P.ProductName;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(W => new { Upper = W.ToUpper(), Lower = W.ToLower() });

            //var Result = from w in words
            //             select new
            //             {
            //                 Upper = w.ToUpper(),
            //                 Lower = w.ToLower()
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 3. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };

            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var Result = numbersA.SelectMany(A => numbersB, (A, B) => new { A = A, B = B }).Where(Pair => Pair.A < Pair.B);

            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //foreach (var Pair in Result)
            //{
            //    Console.WriteLine($"{Pair.A} is less than {Pair.B}");
            //}

            #endregion

            #region 4. Select all orders where the order total is less than 500.00.

            //var Result = ListGenerator.CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500.00m);

            //var Result = from C in ListGenerator.CustomerList
            //             from O in C.Orders
            //             where O.Total < 500.00m
            //             select O;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ListGenerator.ProductList.Select(P => P.Category).Distinct();

            //var Result = (from P in ListGenerator.ProductList
            //              select P.Category).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = ListGenerator.ProductList.Select(P => P.ProductName[0])
            //                                      .Concat(ListGenerator.CustomerList.Select(C => C.CustomerName[0]))
            //                                      .Distinct();

            //var Result = (from p in ListGenerator.ProductList
            //              select p.ProductName[0])
            //              .Concat(from c in ListGenerator.CustomerList
            //                      select c.CustomerName[0]).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ListGenerator.ProductList.Select(P => P.ProductName[0])
            //                                      .Intersect(ListGenerator.CustomerList
            //                                      .Select(C => C.CustomerName[0]));

            //var Result = (from P in ListGenerator.ProductList
            //              select P.ProductName[0]).Intersect
            //             (from C in ListGenerator.CustomerList
            //              select C.CustomerName[0]);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ListGenerator.ProductList.Select(P => P.ProductName[0])
            //                                      .Except(ListGenerator.CustomerList
            //                                      .Select(C => C.CustomerName[0]));

            //var Result = (from P in ListGenerator.ProductList
            //              select P.ProductName[0]).Except
            //             (from C in ListGenerator.CustomerList
            //              select C.CustomerName[0]);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

        }
    }
}
