using System.Reflection.Metadata.Ecma335;

namespace SessionNumber6
{
    public delegate int AddDelegate(int a, int b);
    public delegate T AddDelegate<T>(T a, T b);
    public delegate void DeleteWithZeroParam();
    //void Action<T,T,T,T......>
    //T Func<T,T,T,T......>

    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMath math = new SimpleMath();

            DeleteWithZeroParam delegateWithZeroParam = () =>
            {
                Console.WriteLine("this is delegate with not params");
            };
            delegateWithZeroParam();
            /*
             * 1- The method definiation
             * 2- the parameters that the menthod takes
             * 3- the return type of the method
             */

            AddDelegate<int> addDelegate = new AddDelegate<int>(math.Add);
            Func<double,double,double> addD =
                new Func<double,double,double>(math.Add);
            
            Func<int,int,int> addWithInt = new Func<int,int,int>(math.Add);

            Action<int,int> subD = new Action<int,int>(add);

            //AddDelegate<int> subD = new AddDelegate<int>(math.Subtract);


            //int result = addD(1, 2);
            Console.WriteLine(addD(10, 12));
            //Console.WriteLine(subD.Invoke(10, 12));

            /*
             * System.Delegate
             * System.MulticastDelegate
             *  1- invoke 
             *  2- beginInvoke
             *  3- endInvoke
             * public sealed class AddDelegate : System.MulticastDelegate{
             * 
             * }
             * 
             */



            Console.WriteLine("Hello, World!");
        }


        //public static void FunctWithFunctAsParam(Delegate)
        //{

        //}
        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
