using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyLibrary;
using System.Collections;

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
                employee.TakeEmployeeData();
                employees.Add(employee);
                //employees.Add(10);
            } while (true);
        }
        void PrintEmployees()
        {
            employees.Sort();
            foreach (var item in employees)
            {
                item.PrintEmployeeDetails();//Explicit casting
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
