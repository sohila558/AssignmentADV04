using System.Collections;

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
