using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumeWCFApplication.EmployeeService;

namespace ConsumeWCFApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            Employee employee = new Employee()
            {
                Id = 104,
                Name = "Lim",
                Age = 27
            };
            client.AddEmployee(employee);
            Console.WriteLine("Employee Added");
            var employees = client.GetEmployee(0);
            foreach (var item in employees)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Age);
            }
            Console.ReadKey();
        }
    }
}
