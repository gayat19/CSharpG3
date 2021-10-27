using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApplication
{
    class Program
    {
        void DogShow(Dog dog)
        {
            dog.Eat();
            dog.Look();
            dog.Sleep();
        }
        static void Main(string[] args)
        {
            //Cycle motor = new FastBike();
            //motor.Move();
            //motor = null;
            //GC.Collect();
            //Dog dog = new Pug();
            //new Program().DogShow(dog);
            string name = "Tim Jim";
            Console.WriteLine(name.SampleExten());
            Console.ReadKey();
        }
    }
    static class StringLength
    {
        public static int SampleExten(this string msg)
        {
            return msg.Length + 1;
        }
    }
}
