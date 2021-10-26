using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndersandingOOPSApplication
{
    class Program
    {
        void Add(int num1)
        {
            num1++;
            Console.WriteLine("The result is "+num1);
        }
        void Add(int num1,int num2)
        {
            checked
            {
                int sum = num1 + num2;
                Console.WriteLine($"The result of adding {num1} and {num2} is {sum}");
            }
            
        }
        void Add(string num1, string num2="G3")
        {
            string res = num1 + " " + num2;
            Console.WriteLine($"The result of concat {num1} and {num2} is {res}");
        }
        void UnderstandingNullPrimitive()
        {
            int? num1 = null;//? indicates nullable type
            int sum = (num1 ?? 10) + 100;
            Console.WriteLine(sum);
        }
        int UnderstaingException()
        {
            int num1=0, num2,sum =0;
            try
            {
                Console.WriteLine("Please enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Debug.Assert(num1 > 0);
                Debug.WriteLine("The number value is " + num1);
                Console.WriteLine("Please enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;
                return sum;
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("The input given was not valid.");
                Console.WriteLine(formatException.Message);
                if (!EventLog.SourceExists("MyApp"))
                    EventLog.CreateEventSource("MyApp","Application" );
                EventLog.WriteEntry("MyApp", "G3 " + formatException.Message);
            }
            finally
            {
                Console.WriteLine("Finally gets executed always");
            }
            Console.WriteLine("The sum is "+sum);
            return -1;
        }
        void PrintNonRepeatingNumber(int[] arr)
        {
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //int repeatCount = 0;
                //for (int j = 0; j < arr.Length; j++)
                //{
                //    if (arr[i] == arr[j])
                //        repeatCount++;
                //}
                //if(repeatCount==1)
                //{
                //    Console.WriteLine(arr[i]);
                //    break;
                //}
                num ^= arr[i];  //XOR 
            }
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            Program p1= new Program();
            //p1.Add("Hello",num2:"Tim");
            //p1.Add(100,int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //p1.UnderstaingException();
            int[] arr = { 12, 45, 67, 90, 67, 90, 12 };
            p1.PrintNonRepeatingNumber(arr);
            Console.ReadKey();

        }
    }
}
