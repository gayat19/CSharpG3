using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStrutsAndClass
{
    class Employee
    {
        //private int id;
        //private string name;
        //private int age;

        //public int Id { get { return id; } set { id = value; } }

        //public string Name { get => name; set => name = value; }

        //public int Age { get => age; set {
        //        if (value >= 18 && value <= 56)
        //            age = value;
        //        else
        //            age = 0;
        //    } }
        public string this[int index]
        {
            get
            {
                return skills[index];
            }
            set
            {
                skills[index] = value;
            }
        }
        public int this[string skillName]
        {
            get {
                    int idx = -1;
                    for (int i = 0; i < skills.Length; i++)
                    {
                    if (skills[i] == skillName)
                        idx = i;
                    }
                return idx;
            }
        }
        string[] skills = new string[3];
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID "+Id);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee Age " + Age);
            foreach (var item in skills)
            {
                Console.WriteLine(item);
            }
        }
       
        public Employee()
        {
            Console.WriteLine("Default constructor");
        }
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
    class Program
    {

        void Print(Employee e)
        {
            e.Age += 1;
            e.PrintEmployeeDetails();
        }
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee(101,"Jim",22);
            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.Name = "Jim";
            emp1.Age = 22;
            emp1[0] = "C#";
            emp1[1] = "SQL";
            emp1[2] = "WPF";
            new Program().Print(emp1);
            Console.WriteLine("After the method call");
            emp1.PrintEmployeeDetails();
            Console.WriteLine("Please enter a skill to check");
            string sname = Console.ReadLine();
            if(emp1[sname]>=0)
                Console.WriteLine("Employee has the skill in position "+emp1[sname]);
            else
                Console.WriteLine("Employee does not have this skill");
            Console.ReadKey();
        }
    }
}
