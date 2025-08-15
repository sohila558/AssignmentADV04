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

            #region Hashtables
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
