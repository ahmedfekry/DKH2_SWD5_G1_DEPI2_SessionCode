using System;
using System.Data;

namespace SessionNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // control of flow 
            //int x = 10;
            //if(x > 5)
            //    Console.WriteLine("X is greater than 5");
            //else if(x < 5) 
            //    Console.WriteLine("X is smaller than 5");
            //else
            //    Console.WriteLine("X is equal to 5");

            //string message = (x > 5) ? "X is greater than 5" : (x < 5) ? "X is smaller than 5" : "X is equal to 5";

            //Console.WriteLine(message);

            //string day = Console.ReadLine();
            //switch(day)
            //{
            //    case "Saturday": Console.WriteLine("1"); break;
            //    case "Sunday": Console.WriteLine("2 "); break;
            //    case "Monday": Console.WriteLine("3 "); break;
            //    case "Tuesday": Console.WriteLine("4 "); break;
            //    case "Wendsday": Console.WriteLine("5 "); break;
            //    case "Thrusday": Console.WriteLine("6 "); break;
            //    case "Friday": Console.WriteLine("7 "); break;
            //    default: Console.WriteLine("Unkown day"); break;
            //}

            // For, while, foreach

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Yeay, we are in the weekend - "+i.ToString());
            //}

            //int i = 1;
            //while (i <= 10) {
            //    Console.WriteLine("Yeay, we are in the weekend - " + i.ToString());
            //    i++;
            //}

            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;

            //Console.WriteLine(arr[0]);



            //string str = "Ahmed";
            //str = str+" MOhamed";

            //string[] arr = { "Ahmed", "Aly", "mohamed" };

            //string[] newArray = arr;

            //arr[0] = "Hello";
            //newArray[0] = "Maged";

            //Console.WriteLine(newArray[0]);

            //Array.Copy(arr, newArray, arr.Length);

            ////newArray[3] = "Saad";
            ////newArray[4] = "Mahmoud";

            //Console.WriteLine(arr.Length);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //foreach(string str in arr)
            //{
            //    Console.WriteLine(str);
            //}

            //double x = double.Parse(Console.ReadLine().ToString());
            //string func = Console.ReadLine();
            //double y = double.Parse(Console.ReadLine().ToString());

            //////Calculator(num1: x,num2: y,oper: func);

            //double result = Calculator2(x, y, func);

            //Console.WriteLine(result);

            //Console.WriteLine("Enter Height:");
            //double length = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Width:");
            //double width = double.Parse(Console.ReadLine());

            //Console.WriteLine(CalculateArea(length,width));

            //Console.WriteLine("========================================");

            //Console.WriteLine("Enter the radius: ");
            //double radius = double.Parse(Console.ReadLine());

            //Console.WriteLine(CalculateArea(radius));

            // compile time errors

            // Runtime errors => is the errors that happen the runtime of the application

            //try
            //{

            //    Console.WriteLine("Enter Height:");
            //    double length = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Width:");
            //    double? width = double.Parse(Console.ReadLine());

            //    Console.WriteLine(CalculateArea(length, width));

            //}
            //catch(InvalidOperationException ex)
            //{
            //    Console.WriteLine("Nullable exception");
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("invalid parsing happend please enter valid values");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("================ Error Happened =================");
            //    Console.WriteLine("You entered invalid values");
            //    Console.WriteLine("Error Details : " + ex.Message);
            //    Console.WriteLine("Exception Details : " + ex.StackTrace);
            //}
            //finally
            //{
            //    Console.WriteLine("================== Finally Code ============ ");
            //    Console.WriteLine("Please take care for error");
            //}

            //bool x = default;

            int? x = null; // Nullable<int> 

            Test test = new Test();
            test.Id = null;
            //x = 10;
            //Console.Write(x);
            //if (!x.HasValue)
            //{
            //    Console.Write("X does not have values");
            //}
            //else
            //{
            //    Console.WriteLine(x.Value);
            //}
        }

        static double CalculateArea(double length, double? width)
        {
            if (length == width)
            {
                throw new Exception("The values you entered is for square not rectangle");
            }
            return length * width.Value;
        }

        // ميثود لحساب مساحة الدائرة
        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }




        static int Calculator2(int  num1, int num2, string oper)
        {
            if(oper == "+")
            {
                return num1 + num2;
            }
            else if(oper == "-")
            {
                return num1 + num2;
            }
            else
            {
                return num1 * num2;
            }
        }
        static double Calculator2(double num1, double num2, string oper)
        {
            if (oper == "+")
            {
                return num1 + num2;
            }
            else if (oper == "-")
            {
                return num1 + num2;
            }
            else
            {
                return num1 * num2;
            }
        }
        static void Calculator(int num1,int num2,string oper)
        {
            if (oper == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (oper == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine(num1 * num2);
            }
        }
    }
}
