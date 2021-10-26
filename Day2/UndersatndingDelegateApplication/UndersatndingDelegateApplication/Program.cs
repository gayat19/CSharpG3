using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndersatndingDelegateApplication
{
    class Program
    {
        public EventArgs e = new EventArgs();
        public delegate void CheckNumberHandler(int num,EventArgs args);
        public event CheckNumberHandler checkNumber;
        void GetNumber()
        {
            int num = new Random().Next(100);
            if (num > 100)
            {
                checkNumber += CheckForNumbers100;//Subscription of teh event
                checkNumber += CheckForNumbers50;//Subscription of teh event
            }
            else
                checkNumber += CheckForNumbers50;//Subscription of teh event
            int userNumber = int.Parse(Console.ReadLine());
            //If the user enter a number < 5 then no event will be raised
            if (userNumber > 5)
                checkNumber(num, e);//Raise of event

        }
        void CheckForNumbers50(int num,EventArgs e)
        {
            Console.WriteLine(e.ToString());
            if(num>50)
                Console.WriteLine("Number graeeater than 50");
        }
        void CheckForNumbers100(int num, EventArgs e)
        {
            if (num > 100)
                Console.WriteLine("Big than 100");
        }
        //public delegate void Del();//defining the type

        //void PrintHello()
        //{
        //    Console.WriteLine("hello all");
        //}
        void CallMethod(Action del)
        {
            del();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //Del del = new Del(program.PrintHello);//creating an object for my type
            //Anon method
            //Del del = delegate ()
            //{
            //    Console.WriteLine("hello all");
            //};
            //Lamda exp
            //Del del = ()=> {
            //    Console.WriteLine("hello all");
            //};
            //Action del = () => {
            //    Console.WriteLine("hello all");
            //};
            //program.CallMethod(del);//using the reff
            program.GetNumber();
            Console.ReadKey();
        }
    }
}
