namespace AnonymousFunction
{
    //public delegate bool EvenNumberDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {

            //MyDelegate myDelegate = delegate(string message, int x)
            //{
            //    Console.WriteLine(x);
            //    Console.WriteLine(message);
            //};

            //myDelegate("this is a method that just print a message",10);
            //Console.WriteLine("Hello, World!");

            //Predicate<int> IsEven = 

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };


            List<int> evenNumber = numbers.FindAll((x) =>{
                Console.WriteLine("This is message");
                if (x == 0) return true;

                if (x % 2 == 0) return true;
                else return false;
            });

            foreach(var itm in evenNumber)
            {
                Console.WriteLine(itm);
            }
        }

        //public static bool IsEven(int x)
        //{
        //    if (x == 0) return true;

        //    if (x % 2 == 0) return true;
        //    else return false;
        //}

    }
}
