using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApplication
{
    class Cycle
    {
        public int Speed { get; set; }
        //protected int privateInt;
        public Cycle()
        {  
            Speed = 20;
            Console.WriteLine("Cycle created");
        }
        public virtual void Move()
        {
            Console.WriteLine("Ride it by pedal");
        }
        ~Cycle()
        {
            Console.WriteLine("Cycle gone");
        }
        
    }
    class MotorCycle:Cycle
    {
        public MotorCycle()
        {
            Speed = 60;
            Console.WriteLine("Motor added");
            //privateInt = 20;
        }
        public  override  void Move()
        {
            Console.WriteLine("Ride it by gear change");
        }
        ~MotorCycle()
        {
            Console.WriteLine("Motor Gone");
        }
    }
    class FastBike:MotorCycle
    {
        public FastBike()
        {
            Speed = 90;
            Console.WriteLine("Fast motor added");
        }
        public override void Move()
        {
            Console.WriteLine("Rides really fast");
        }
    }
    class MountainCycle : Cycle
    {
        public MountainCycle()
        {
            Speed = 30;
            Console.WriteLine("Small Motor added");
            //privateInt = 20;
        }
        public override  void Move()
        {
            Console.WriteLine("Ride it by gear change and pedel");
        }
        ~MountainCycle()
        {
            Console.WriteLine("Small gear Gone");
        }
    }
}
