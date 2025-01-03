//using System.Net.Http;

namespace SessionNumber8
{
    internal class Program
    {
        static int counter = 0;
        static object _lock = new object();
        static async Task Main(string[] args)
        {
            /*
             * Process :- is a running instance of a program.
             * Task:- is a unit of work that is typically performed by a thread.
             * Thread:- is the smallest unit of execution that can be scheduled by the operating system.
             * Main Thread:- is the first thread that is created when your program starts.
             * Mul
             * 
             * 
             * 
             * 
             */

            //PrintFunction1();
            //PrintFunction2();
            //Thread thread1 = new Thread(PrintFunction1);
            //Thread thread2 = new Thread(PrintFunction2);

            //thread1.Start();
            //thread1.Join();

            //thread2.Start();
            //thread2.Join();


            //SaveTodatabase();
            //Task.Run(SendNotification);
            //Console.WriteLine("the request is success");

            //Console.ReadLine();

            //10
            // async and await

            //Console.WriteLine("Main Thread => " + Thread.CurrentThread.ManagedThreadId);
            //await SaveTodatabase();

            //FetchData();

            // HttpRequests
            /* GET :- To get the data from the server.
             * POST: - To send the data to the server.
             *      1- Send the data in the body of the request.
             *      2- data is encrypted
             *      3- data is not visible in the URL
             *      4- Size is not limited
             * PUT: - To update the data on the server.
             * DELETE: - To delete the data from the server.
             * 
             */

            //PostManagement postManagement = new PostManagement();

            //await postManagement.UpdatePost(1, "Title", "Body");
            //await postManagement.DeletePost(1);
            //var posts = await postManagement.GetAllPosts();
            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"Title : {post.Title}");
            //}

            //SOLID
            /*
             * S => single resposibitly
             *      Every class should have only one mission and one reason to change
             * O => Open-Closed Principle
             *  Open for extension but closed for modifications
             * L => Liskov principle
             * I => interface segrigation
             * D => Dependancy Inversion
             * 
             * 
             * 
             * 
             */
        }


        //static async Task SaveTodatabase()
        //{
        //    Console.WriteLine("Save ToDatabase Thread => " + Thread.CurrentThread.ManagedThreadId);

        //    Console.WriteLine("Data Saving in progress");
        //    await Task.Delay(2000);
        //    Console.WriteLine("Data Saved");
        //}

        //static void FetchData()
        //{
        //    Console.WriteLine("Fetch Data Thread => " + Thread.CurrentThread.ManagedThreadId);

        //    Task.Delay(2000).Wait();
        //    Console.WriteLine("Data Fetched");
        //}

        ////static void SendNotification()
        ////{
        ////    Task.Delay(5000).Wait();
        ////    Console.WriteLine("Notification Sent");
        ////}

        ////static void PrintFunction1()
        ////{
        ////    Thread.Sleep(500);
        ////    lock (_lock)
        ////    {
        ////        for (int i = 0; i < 5; i++)
        ////        {
        ////            counter++;
        ////            Console.ForegroundColor = ConsoleColor.Red;
        ////            Console.WriteLine($"Counter : " + counter);
        ////        }
        ////    }

        ////}

        ////static void PrintFunction2()
        ////{
        ////    Thread.Sleep(500);
        ////    for (int i = 0; i < 5; i++)
        ////    {
        ////        counter++;
        ////        Console.ForegroundColor = ConsoleColor.Green;
        ////        Console.WriteLine($"Counter : " + counter);
        ////    }
        ////}   
    }
}
