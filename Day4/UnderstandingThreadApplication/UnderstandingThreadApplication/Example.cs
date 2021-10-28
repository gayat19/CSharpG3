using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnderstandingThreadApplication
{
    public class Example
    {
        private static void Main()
        {
            var cancelSource = new CancellationTokenSource();
            new Thread(() =>
              {
                    try
                    {
                        Work(cancelSource.Token); 
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("Canceled!");
                    }
                }).Start();

        Thread.Sleep(1000);
      cancelSource.Cancel(); 
      Console.ReadLine();
    }
    private static void Work(CancellationToken cancelToken)
    {
        while (true)
        {
            Console.Write("G3");
            cancelToken.ThrowIfCancellationRequested();
        }
    }
}
}
