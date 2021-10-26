using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInterface
{
    interface IFlying
    {
        void TakeOff();
        void Land();
        void Fly();
    }
    interface ILiving
    {
        void Eat();
    }
    class Bird : IFlying,ILiving
    {
        public void Eat()
        {
            Console.WriteLine("Munch munch");
        }

        public void Fly()
        {
            Console.WriteLine("Glide");
        }

        public void Land()
        {
            Console.WriteLine("Stop flapping wings");
        }

        public void TakeOff()
        {
            Console.WriteLine("Falp flap flap");
        }

    }
    class Plane : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Auto Pilot");
        }

        public void Land()
        {
            Console.WriteLine("Switch on the Landing Gear");
        }

        public void TakeOff()
        {
            Console.WriteLine("Take Off start engine");
        }
    }
    class Program
    {
        void InTheSky(IFlying flying)//needs a flying object
        {
            flying.TakeOff();
            flying.Fly();
            flying.Land();
        }
        void InTheJungle(ILiving lifes)//needs a living object
        {
            lifes.Eat();
        }
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            //IFlying flyingObject = bird;
            //ILiving life = bird;
            Program program = new Program();
            program.InTheSky(bird);
            program.InTheJungle(bird);
            Console.ReadKey();
        }
    }
}
