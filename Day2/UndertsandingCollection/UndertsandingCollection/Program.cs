using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyLibrary;
using System.Collections;
using System.IO;

namespace UndertsandingCollection
{
    class Program
    {
        //Employee[] employees = new Employee[3];
        List<Employee> employees = new List<Employee>();
        void AddEmployees()
        {
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    employees[i] = new Employee();
            //    employees[i].TakeEmployeeData();
            //}
            do
            {
                Console.WriteLine("Do you want to add an employee??");
                string result = Console.ReadLine().ToLower();
                if (result == "no")
                    break;
                Employee employee = new Employee();
                try
                {
                    employee.TakeEmployeeData();
                    employees.Add(employee);
                }
                catch (InvalidAgeException invalidAgeException)
                {
                    Console.WriteLine(invalidAgeException.Message);
                }
                
                //employees.Add(10);
            } while (true);
        }
        void PrintEmployees()
        {
            //employees.Sort();
            var ageSortedEmployees = employees.Where(emp=>emp.Age>45).OrderBy(emp => emp.Age);
            
           
            foreach (var item in ageSortedEmployees)
            {
                //item.PrintEmployeeDetails();//Explicit casting
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddEmployees();
            program.PrintEmployees();
            Console.ReadKey();
        }
    }
}
