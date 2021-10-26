using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        static void UnderstandingSelection()
        {
            Console.WriteLine("Please enter the day");
            string day = Console.ReadLine();
            day = day.ToUpper();
            if(day =="MONDAY")
                Console.WriteLine("Start of the week");
            else if(day =="TUESDAY")
                Console.WriteLine("Its just the day 2");
            else if(day == "WEDNESDAY")
                Console.WriteLine("Mid of teh week is here");
            else if(day =="THURSDAY")
            {
                Console.WriteLine("Its almost the weekend");
                Console.WriteLine("Prepare for weekend");
            }
            else if(day == "FRIDAY")
                Console.WriteLine("Its weekend. Enjoy");
            else if(day =="SATURDAY")
                Console.WriteLine("Start of weekend");
            else if(day=="SUNDAY")
                Console.WriteLine("Weekend end day is here");
            else
                Console.WriteLine("It is not a valid day");
  
        }
        static void UnderstandingSwitch()
        {
            Console.WriteLine("Please enter the day");
            string day = Console.ReadLine();
            day = day.ToUpper();
            //switch (day)
            //{
            //    case "MONDAY":
            //        Console.WriteLine("Start of the week");
            //        break;
            //    case "TUESDAY":
            //        Console.WriteLine("Its just the day 2");
            //        break;
            //    case "WEDNESDAY":
            //        Console.WriteLine("Mid of teh week is here");
            //        break;
            //    case "THURSDAY":
            //        Console.WriteLine("Its almost the weekend");
            //        Console.WriteLine("Prepare for weekend");
            //        break;
            //    case "FRIDAY":
            //        Console.WriteLine("Its weekend. Enjoy");
            //        break;
            //    case "SATURDAY":
            //        Console.WriteLine("Start of weekend");
            //        break;
            //    case "SUNDAY":
            //        Console.WriteLine("Weekend end day is here");
            //        break;
            //    default:
            //        Console.WriteLine("It is not a valid day");
            //        break;
            //}
            switch (day)
            {
                case "MONDAY": 
                case "TUESDAY": 
                case "WEDNESDAY":
                case "THURSDAY":
                case "FRIDAY":
                    Console.WriteLine("Weekday");
                    break;
                case "SATURDAY":
                case "SUNDAY":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("It is not a valid day");
                    break;
            }
        }
        static void UnderstandingFor()
        {
            int num = 0,sum=0;
            //init;cond;upd
            for (int i = 0; i < 5; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("The sum is "+sum);
        }
        static void UnderstandingWhile()
        {
            int age =0;
            Console.WriteLine("Please enter your age");
            while(int.TryParse(Console.ReadLine(), out age) == false)
            {
                Console.WriteLine("Invalid age. Please enter again");
            }
            Console.WriteLine("Success you have entered teh age "+age);
        }
        static void UnderstandingDoWhile()
        {
            int num,sum =0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;

            } while (num>0);
            sum -= num;
            Console.WriteLine("The sum is "+sum);
        }
        void UnderstandingRegEx()
        {
            Console.WriteLine("Please enter the 4 digit part number");
            string partNumber = Console.ReadLine();
            var myRegEx = "[0-9][0-9][0-9][0-9]";
            var check = Regex.IsMatch(partNumber, myRegEx);
            if(check)
                Console.WriteLine("Very Good");
            else
                Console.WriteLine("Invalid part number");

        }
        /// <summary>
        /// My main method as entery point for the application
        /// </summary>
        /// <param name="args">Command Line argument</param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your name");
            //string name = Console.ReadLine();
            //// int age = 12.3;//type safe causes error
            //Console.WriteLine("Pleae enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());//unboxing 
            //Console.WriteLine("Please enter your height");
            //float height = float.Parse(Console.ReadLine());
            //Console.WriteLine("Welcome to C# " + name);
            //Console.WriteLine($"You are {age} years old");
            //Console.WriteLine("Your height is {0}", height);
            //if(age>=18)
            //    Console.WriteLine("You are ready to vote");
            //else
            //    Console.WriteLine("You have to grow up");
            //string data = age.ToString();//Boxing
            //int num = (int)height;//Explicit casting
            //Console.WriteLine(float.MaxValue);
            //UnderstandingSwitch(); //Methods call
            Program program = new Program();
            program.UnderstandingRegEx();//instance member
            Console.ReadKey();//getch()
        }
    }
}
