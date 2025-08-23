using AssignmentADV04.Task;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo
{
    internal class Program
    {
        #region Implictly-Type Local Variable [var - dynamic]
        //public static var Print(var X)
        //{
        //    return X;
        //}

        //public static dynamic Print(dynamic X)
        //{
        //    return X;
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region AdvancedC#04
            #region Function Return Function
            //var action = Fun01();
            //action.Invoke();

            //Fun01()(); 
            #endregion

            #region Non-Generic Hashtables
            // Collection : Built-in DS in C#

            // Non-Generic Hashtables : Hashtable

            //Hashtable phoneBook = new Hashtable();

            //phoneBook.Add("Ahmed", 1111);
            //phoneBook.Add("Ali", 2222);
            //phoneBook.Add("Amr", 3333);
            //phoneBook.Add("Omar", 4444);
            //phoneBook.Add("Bassem", 5555);

            //foreach (DictionaryEntry item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Dictionary
            //Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            //phoneBook.Add("Ahmed", 111111);
            //phoneBook.Add("Ali", 222222);
            //// phoneBook.Add(null, 333333);

            //phoneBook.Add("Amr", 33333333);
            ////phoneBook.Add(33333333, "Amr");

            //var flag = phoneBook.Remove("Ahmed", out long result);
            //Console.WriteLine(flag);
            //Console.WriteLine(result);

            //foreach (KeyValuePair<string, long> item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Generic Hashtable : Hashset
            // Generic Hashtable : Hashset

            //HashSet<string> Names = new HashSet<string>();
            //Names.Add("Ahmed");
            //Names.Add("Amr");
            //Names.Add("Ali");
            //Names.Add("Bassem");

            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

            #region LINQ Session 1

            #region Implictly-Type Local Variable [var - dynamic]
            // Implictly-Type Local Variable [var - dynamic]

            // var

            //var Data01 = "Ahmed";

            // Compilor Can Detect the DataType of the local Variable Based on Initial Value At Compilation Time
            // Must Be Initialized 
            // Can't Initialized The local Variable with Null
            // Can't Change Datatype of the local Varialble After Initialization
            // Can't Use Var As Parameter Or Return Type 

            // Data01 = 12; // Invalid

            // Dynamic As Var In JS

            //dynamic Data02 = "Ahmed";

            // CLR Detect the Datatype of the Local Variable Based on Last Value, At Runtime
            // Don't Need to be Initialized 
            // Can Initialized the Local Variable with Null
            // Can Change The Local Variable After Initialization
            // Can Use dynamic Keyword AS a Parameter or return Type 

            //Data02 = 12;
            //Data02 = 12.5m;
            //Data02 = 12.5;
            //Data02 = 12.5f;
            //Data02 = true; 
            #endregion

            #region Anonymous Type
            // Anonymous Type

            // Employee E01 = new Employee() { Id = 1, Name = "Sohila", Salary = 15000 };
            //var E01 = new { Id = 1, Name = "Sohila", Salary = 15000 };

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            ////E01.Id = 12; // Invalid : Immutable Can't Change It's Value After Creation

            //Console.WriteLine(E01.GetType().Name); // <>f__AnonymousType0`3

            //Console.WriteLine(E01); // { Id = 1, Name = Sohila, Salary = 15000 }
            // Compilor Will Override on ToString 
            #endregion

            #region Extension Methods
            // Extension Methods

            //int Number = 12345;

            //var Result = intExtention.Reverse(Number); // Class Member Method

            //var Result = Number.Reverse(); // Extention Method

            //Console.WriteLine(Result); 
            #endregion

            #region What Is LINQ ?
            // LINQ : Language Integrated Query
            //      : 40+ Extension Methods (LINQ Operators) Against Any Data [Data In Sequence]
            //      : Regardless Data Store
            //      : 13 Category 
            //      : LINQ Operators Exist In Built-In Class "Enumerable"

            // Sequence : Object From Class Implement Interface "IEnumerable"
            // Local Sequence  : L2O, L2XML 
            // Remote Sequence : L2EF

            // Input Sequence --> LINQ Operator --> Output Sequence
            // Input Sequence --> LINQ Operator --> One Value 
            //                --> LINQ Operator --> Output Sequence


            // Input Sequence --> LINQ Operator --> Output Sequence

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var Result = Enumerable.Range(1, 100);
            //var Result = Enumerable.Any(Numbers, N => N % 2 == 0);

            //Console.WriteLine(Result);

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item}");
            //} 
            #endregion

            #region LINQ Syntax
            // LINQ Syntax 

            // 1.Fluent Sequence
            // Use LINQ Methods 

            // 1.1. LINQ Operator AS A Class Member Method through Class "Enumerable"

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}

            // 1.2. LINQ Operator AS Extension Method Through Sequence [Recommended]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = Numbers.Where(N => N % 2 == 0);

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}

            // 2.Query Syntax [Query Expression] Like SQL Style
            // Start From
            // end Select, Group By
            // Query Syntax easier than Fluent (Join, Group By, Let, Into) 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Result = from N in Numbers
            //             where N % 2 == 0
            //             select N;

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region LINQ Query Execution
            // LINQ Query Execution
            // 1. Differed Execution Way  : 10 Category
            // 2. Immediate Execution Way : 3 Category [Elements Operators, Casting Operators, Aggregate Operators]

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var Result = Numbers.Where(N => N % 2 == 0); // Differed

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15});

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}

            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var Result = Numbers.Where(N => N % 2 == 0).ToList(); // Immediate

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #endregion

            #region LINQ Session 2

            // LINQ: +40 Extension Methods
            // LINQ: 13 Category

            #region Filtration Operators - Where / OfType

            // 1. Filtration Operators - Where / OfType

            // All Product Out Stock


            // Fluent Syntax
            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);

            // Query Syntax [Query Expression]

            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock == 0
            //             select P;


            //var result = ListGenerator.ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ListGenerator.ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");

            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;

            //var result = ListGenerator.ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);
            //var result = ListGenerator.ProductList.Where((P, Index) => Index < 5);
            //var result = ListGenerator.ProductList.Where((P, Index) => Index < 5 && P.UnitsInStock == 0);
            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0).Where((P,I) => I < 5);

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, 4.5m, ProductList[0], ProductList[1] };

            //var result = arrayList.OfType<int>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tansformation Operator - Select / SelectMany

            // 2. Tansformation Operator - Select / SelectMany

            // Fluent Syntax

            //var result = ListGenerator.ProductList.Select(P => P);

            //var result = ListGenerator.ProductList.Select(P => P.ProductName);

            // Query Syntax

            //var result = from P in ListGenerator.ProductList
            //             select P.ProductName;

            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                          .Select(P => new 
            //                          { 
            //                              P.ProductName,
            //                              P.Category,
            //                              OldPrice = P.UnitPrice,
            //                              NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //                          });

            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //             };

            //var result = ListGenerator.CustomerList.Select(C => C.CustomerName);
            //var result = ListGenerator.CustomerList.Select(C => C.Orders); // If one Of the Property is Sequence We use SelectMany

            //var result = ListGenerator.CustomerList.SelectMany(C => C.Orders);

            //var result = from C in ListGenerator.CustomerList
            //             from O in C.Orders
            //             select O;

            // Indexed Select Valid only In Fluent Syntax

            //var result = ListGenerator.ProductList.Select((P, I) => new { I, P.ProductName }).Where(P => P.I < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Ordering Operators

            // Ordering Operators

            // Sorting

            //var result = ListGenerator.ProductList.OrderBy(P => P.UnitPrice);
            //var result = ListGenerator.ProductList.OrderBy(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });

            //var result = ListGenerator.ProductList.OrderByDescending(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });

            //var result = ListGenerator.ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenBy(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });

            //var result = ListGenerator.ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenByDescending(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });

            //var result = ListGenerator.ProductList.Where(P => P.Category == "Seafood")
            //                                      .OrderBy(P => P.UnitsInStock)
            //                                      .ThenByDescending(P => P.UnitPrice)
            //                                      .Select(P => new
            //                                      {
            //                                          P.ProductName,
            //                                          P.UnitPrice,
            //                                          P.UnitsInStock
            //                                      });

            //var result = from P in ListGenerator.ProductList
            //             where P.Category == "Meat/Poltury" && P.UnitsInStock > 0
            //             orderby P.UnitPrice, P.UnitsInStock
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };

            //var result = ListGenerator.ProductList.Reverse<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Elements Operator - Immediate Execution

            // 4. Elements Operator - Immediate Execution

            //var result = ListGenerator.ProductList.First(); // May Throw Exception [Sequence Contain No Elements]
            //var result = ListGenerator.ProductList.Last(); // May Throw Exception [Sequence Contain No Elements]

            //var result = ListGenerator.ProductList.First(P => P.UnitsInStock == 0); // May Throw Exception [Sequence Contains Matching No Elements]
            //var result = ListGenerator.ProductList.Last(P => P.UnitsInStock == 0); // May Throw Exception [Sequence Contains No Matching Elements]

            //var result = ListGenerator.ProductList.FirstOrDefault();
            //var result = ListGenerator.ProductList.FirstOrDefault(new Product() { ProductName = "Default Product"});
            //var result = ListGenerator.ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);
            //var result = ListGenerator.ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });



            //var result = ListGenerator.ProductList.LastOrDefault();
            //var result = ListGenerator.ProductList.LastOrDefault(new Product() { ProductName = "Default Product" });
            //var result = ListGenerator.ProductList.LastOrDefault(P => P.UnitsInStock == 0);
            //var result = ListGenerator.ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });


            //var result = ListGenerator.ProductList.ElementAt(0); // May Throw Exception [Index was out of Range]
            //var result = ListGenerator.ProductList.ElementAtOrDefault(1); 



            //var result = ListGenerator.ProductList.Single(); // May Throw Exception
            // Sequence Contain more than one Element
            // Sequence Contain no Elements

            //var result = ListGenerator.ProductList.Single(P => P.UnitsInStock == 0); // May Throw Exception
            // Sequence Contain more than one Element matching Condition
            // Sequence Contain no Elements

            //var result = ListGenerator.ProductList.SingleOrDefault(); // May Throw Exception
            // Sequence Contain more than one Element
            // REturn Default Value [Null] if the Sequence is Empty

            //var result = ListGenerator.ProductList.SingleOrDefault(); // May Throw Exception
            // Sequence Contain more than one Element
            // REturn Default Value [Null] if the Sequence is Empty



            //var result = ListGenerator.ProductList.SingleOrDefault(P => P.UnitsInStock == 0); // May Throw Exception
            // Sequence Contain more than one Element
            // REturn Default Value [Null] if the Sequence is Empty


            //var result = ListGenerator.ProductList.SingleOrDefault(P => P.UnitsInStock == 0); // May Throw Exception
            // Sequence Contain more than one Element
            // REturn Default Value [Null] if the Sequence is Empty

            //Console.WriteLine(result?.ProductName ?? "NA"); 
            #endregion

            #region Aggregate Operators - Immediate Execution
            // 5. Aggregate Operators - Immediate Execution

            // Count - Sum - Max - Min - Avg

            //var result = ListGenerator.ProductList.Count();

            //var result = ListGenerator.ProductList.Count(P => P.UnitsInStock == 0);


            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).Count();

            // Sum

            //var result = ListGenerator.ProductList.Sum(P => P.UnitPrice);

            // AVG

            //var result = ListGenerator.ProductList.Average(P => P.UnitPrice);

            // Max

            //var result = ListGenerator.ProductList.Max(P => P.UnitPrice);

            //Console.WriteLine(result); 
            #endregion

            #region Casting Operators - Immediate Execution
            // 6. Casting Operators - Immediate Execution

            //List<Product> list = (List<Product>)ListGenerator.ProductList.Where(P => P.UnitsInStock == 0); // Invalid

            //List<Product> list = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> list = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID);
            //HashSet<Product> list = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();


            //foreach (var item in list)
            //{
            //    Console.WriteLine(list);
            //} 
            #endregion

            #region Generation Operators
            // 7. Generation Operators
            // The Only Way To Call This Method as -> Class Member Method Through "Enumerable" Class

            // Range, Empty, Repeat 

            //var res = Enumerable.Range(1, 100);

            //var res = Enumerable.Empty<Product>().ToList();

            //res.Add(new Product() { ProductName = "Product01" });
            //res.Add(new Product() { ProductName = "Product02" });

            //var res = Enumerable.Repeat(ProductList[0], 3);  
            //var res = Enumerable.Repeat(1, 3);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(res);
            //} 
            #endregion

            #region Set Operators - Union Family
            // 8. Set Operators - Union Family
            // Union - union All - Intersect - Except

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            //var res = Seq01.Union(Seq02); // Like Union In SQL Without Duplication
            //var res = Seq01.Concat(Seq02); // Like Union All In SQL Without Duplication
            //var res = Seq01.Concat(Seq02); // Like Union In SQL Without Duplication
            //res = res.Distinct(); // Remove Duplication
            //var res = Seq01.Intersect(Seq02); // 50 -- 100
            //var res = Seq01.Except(Seq02); // 101 -- 149


            //foreach (var item in res)
            //{
            //    Console.WriteLine(res);
            //} 
            #endregion

            #region Quantifier Operators - Return Boolean
            // 9. Quantifier Operators - Return Boolean

            // Any - All - SequenceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            // Any() --> Return True if There Are  At Least one Element [In The Sequence Or Match The Condition]

            //var res = Seq01.Any(N => N % 2 == 0);

            // ProductList = new List<Product>(); 

            //var res = ListGenerator.ProductList.Any();
            //var res = ListGenerator.ProductList.Any(P => P.UnitsInStock == 0);

            // All() --> Return True if All Element in the Sequence Match The Conditions Or Sequence Is Empty

            //var res = ListGenerator.ProductList.All(P => P.UnitsInStock == 0);            
            //var res = ListGenerator.ProductList.All(P => P.UnitPrice > 0);

            // SequenceEqual()

            //var res = Seq01.SequenceEqual(Seq02);

            //var res = Seq02.Contains(1);

            //var res = ListGenerator.ProductList.Contains();

            //Console.WriteLine(res); 
            #endregion

            #region Zipping Operator
            // 10. Zipping Operator
            // Zip

            //List<string> Words = new List<string> { "Ten", "Twenty", "Thirty", "Fourty" };

            //List<int> Numbers = new List<int> { 10, 20, 30, 40, 50, 60 };

            //var result = Words.Zip(Numbers, (W, N) => $"{N} --> {W}");
            //var result = Words.Zip(Numbers, (W, N) => new {Numbers = N, Word = W});

            //foreach (var item in Words)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Groupping Operators
            // Groupping Operators

            //var res = ListGenerator.ProductList.GroupBy(P => P.Category);

            //res = from P in ListGenerator.ProductList
            //      group P by P.Category;

            //foreach (var Category in res)
            //{
            //    Console.WriteLine(Category.Key);

            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine(Product);
            //    }
            //}

            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new { CategoryName = Category.Key, CountOfCategory = Category.Count() };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.Key);

            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine(Product);
            //    }
            //} 
            #endregion

            #region Partitioning Operator - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile
            // Partitioning Operator - Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile

            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).Take(3);
            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).TakeLast(3);

            //var Result = ListGenerator.ProductList.Skip(5).Take(5);
            //var Result = ListGenerator.ProductList.SkipLast(5);

            //int[] Numbers = { 4, 1, 2, 3, 4, 5 };
            //var Result = Numbers.TakeWhile((N) => N % 3 == 0);
            //var Result = Numbers.SkipWhile((N) => N % 3 == 0);

            //int[] Numbers = { 5, 4, 1, 3, 9, 6, 7, 2, 0 };

            //var Result = Numbers.TakeWhile((N, I) => N > I);
            //var Result = Numbers.SkipWhile((N, I) => N > I);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Let - Into
            // Let - Into

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Mohamed", "Mona", "Aya", "Mariam", "Tuqqaa", "Sally", "Mahmoud", "Osama" };

            //var Result = from Name in Names
            //             select Regex.Replace(Name, "[aeouiAEUIO]", string.Empty)
            //             into NoVolesNames
            //             where NoVolesNames.Length > 3
            //             select NoVolesNames;


            //var Result = from Name in Names
            //             let NoVolesNames = Regex.Replace(Name, "[aeouiAEUIO]", string.Empty)
            //             where NoVolesNames.Length > 3
            //             select NoVolesNames;


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //Regex.Replace("Ahmed", "[aeouiAEUIO]", string.Empty);

            #endregion 
            #endregion



        }

        #region AdvancedC#04
        public static Action Fun01()
        {
            // Action action = Print;
            // Action action = delegate () { Console.WriteLine("Hello World"); };
            Action action = () => { Console.WriteLine("Hello World"); };
            return action;
        }

        public static void Print()
        {
            Console.WriteLine("Hello World");
        } 
        #endregion
    }
}
