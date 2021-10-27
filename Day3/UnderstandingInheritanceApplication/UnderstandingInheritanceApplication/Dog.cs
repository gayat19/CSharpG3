using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApplication
{
    abstract class Dog
    {
        public void Eat()
        {
            Console.WriteLine("Eats pedigree");
        }
        public void Sleep()
        {
            Console.WriteLine("Alert sleep");
        }
       
        public abstract void Look();
    }
    class GreatDane : Dog
    {
        public override void Look()
        {
            Console.WriteLine("Big and gentle");
        }
    }
    class Pug : Dog
    {
        public override void Look()
        {
            Console.WriteLine("Small and Fast");
        }
    }
}
