using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStrutsAndClass
{
    class UndertsandingEnum
    {
        enum WeekDays
        {
            Monday=1,Tuesday=101,Wednesday=201,Thursday=301,Friday=401,Saturday=501,Sunday=601
        }
        static void Main(string[] a)
        {
            int myday = int.Parse(Console.ReadLine());
            if(((WeekDays)myday) == WeekDays.Tuesday)
                Console.WriteLine(WeekDays.Tuesday);
            Console.ReadKey();
        }
    }
}
