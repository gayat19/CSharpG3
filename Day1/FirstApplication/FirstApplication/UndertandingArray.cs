using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class UndertandingArray
    {
        int[] arr = new int[10];
        void TakeNumbers()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter the {0} number",(i+1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        void PrintOnlyEven()
        {
            Console.WriteLine("The even number");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if(arr[i]%2==0)
            //        Console.WriteLine(arr[i]);
            //}
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                   Console.WriteLine(item);
            }
        }
        static void Main(string[] arr)
        {
            UndertandingArray array = new UndertandingArray();
            array.TakeNumbers();
            array.PrintOnlyEven();
            Console.ReadKey();
        }
    }
}
