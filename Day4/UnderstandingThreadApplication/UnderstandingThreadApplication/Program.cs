using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace UnderstandingThreadApplication
{
    class Program
    {
        void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(Thread.CurrentThread.Name+" "+i);
            }
        }
        void PrintNumbersAgain()
        {
            for (int i = 1000; i < 1010; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)
        {
            Another();
            Console.ReadKey();
        }

        static async void Another()
        {
            Program program = new Program();
            //Thread thread1 = new Thread(program.PrintNumbers);
            //thread1.Name = "Thread1";
            //Thread thread2 = new Thread(program.PrintNumbers);
            //thread2.Name = "Thread2";
            ////program.PrintNumbers();
            ////program.PrintNumbersAgain();
            //thread1.Start();
            //thread2.Start();
            //Task t = Task.Run(() =>{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Thread.Sleep(500);
            //        Console.WriteLine(Thread.CurrentThread.Name + " " + i);
            //    }
            //});
            //Task<string> t = new Task<string>(() => "Hello World!!!");
            //t.Start();
            //Console.WriteLine("Inter line");
            //Console.WriteLine(t.Result);
            ////t.Wait();
            //Console.WriteLine("Check this line");
            //Task taskA = Task.Run(()=>Thread.Sleep(2000));
            //try
            //{
            //    taskA.Wait(1000);
            //    bool checkComplete = taskA.IsCompleted;
            //    Console.WriteLine("Status of taskA complete?? "+checkComplete);
            //    if(!checkComplete)
            //        Console.WriteLine("Timed out before complete");
            //}
            //catch (AggregateException ag)
            //{
            //    foreach (var item in ag.InnerExceptions)
            //    {
            //        Console.WriteLine(item.Message);
            //    }
            //}
            //TaskScheduler.UnobservedTaskException += (object sender,
            //UnobservedTaskExceptionEventArgs e) =>
            //{
            //    foreach (Exception ex in ((AggregateException)e.Exception).InnerExceptions)
            //    {
            //        Console.WriteLine(String.Format("An exception occurred: {0}", ex.Message));
            //    }
            //    e.SetObserved();
            //};
            //Task.Run(() =>
            //{
            //    using (WebClient client = new WebClient())
            //    {
            //        client.DownloadStringTaskAsync("https://mail.yah");
            //    }
            //});
            //Thread.Sleep(5000);
            //GC.WaitForPendingFinalizers();
            //GC.Collect();
            //Console.WriteLine("Execution complete.");
            //Console.ReadLine();
            //List<string> names = new List<string>();
            //for (int i = 0; i < 50; i++)
            //{
            //    names.Add("Name " + i);
            //}
            ////foreach (var item in names)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Parallel.ForEach(names, name => {
            //    Console.WriteLine(name);
            //});
            Task<string> task1 = Task.Run(() => "Hello");
            //string data = await task1.Result;
            await task1.ContinueWith(data=>Console.WriteLine(data.Result));
           
        }
    }
}
