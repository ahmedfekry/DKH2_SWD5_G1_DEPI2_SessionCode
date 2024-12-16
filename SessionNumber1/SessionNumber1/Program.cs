

using System;
using System.IO;

namespace SessionNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;

            //int y = x;
            //y = 20;

            //Console.WriteLine(x);
            //Console.WriteLine(y);


            MyClass obj1 = new MyClass { Value = 10 };
            MyClass obj2 = obj1;  // obj2 refers to the same object as obj1
            obj2.Value = 20;
            Console.WriteLine(obj1.Value);  // Outputs: 20 (obj1 is affected)





            //Address Value
            //0x100     10
            //0x101     20
            //0x102     
            //0x103 


            /*
             * 
             * Value Types
             * 1- data types stored in the stack
             * 2- short life time
             * 3- each variable has its own copy of the value
             * 
             * int, float,double,bool,struct,enum
             * 
             * 
             * 
             * 
             * Reference Types
             * 1- data types stored in the heap
             * 2- long life time
             * 3- two variables has the same reference in the heap
             * 
             * 
             * string,array,object
             * 
             */

        }

        static void OutputSometime()
        {
            string x = "This is some text";
            Console.WriteLine(x);
        }

    }

    class MyClass
    {
        public int Value;
    }
}
