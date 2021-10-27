using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibrary
{
    public class Employee :IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        /// <summary>
        ///Expected Exceptions: InvalidAge Exception
        /// </summary>
        public void TakeEmployeeData()
        {
            int id, age;
            Console.WriteLine("Please enter the employee ID");
            while (!int.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalid ID. Please enter ID again");
            }
            Id = id;
            Console.WriteLine("Please enter the employee name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid ID. Please enter age again");
            }
            if (age < 18 || age > 56)
                throw new InvalidAgeException(age);
            Age = age;
        }
        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee ID "+Id+"\nEmployee Name "+Name+"\nEmployee Age "+Age);
        }
        public override string ToString()
        {
            return "Employee ID " + Id + "\nEmployee Name " + Name + "\nEmployee Age " + Age;
        }
        public int GetNumber() {
            return new Random().Next();
        }

        public int CompareTo(Employee other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
