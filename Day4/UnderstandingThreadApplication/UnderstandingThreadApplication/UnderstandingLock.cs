using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UnderstandingThreadApplication
{
    class UnderstandingLock
    {
        void PrintNumebrs()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }
            }
        }
        static void Main(string[] args)
        {
            UnderstandingLock program = new UnderstandingLock();
            Thread t1 = new Thread(program.PrintNumebrs);
            Thread t2 = new Thread(program.PrintNumebrs);
            t1.Name = "T1";
            t2.Name = "T2";
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
