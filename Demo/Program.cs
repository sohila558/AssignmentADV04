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
