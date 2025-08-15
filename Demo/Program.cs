using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
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




        }

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
    }
}
