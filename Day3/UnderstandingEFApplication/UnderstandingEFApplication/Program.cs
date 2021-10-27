using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEFApplication
{
    partial class Sample
    {
        public Sample()
        {
            Num1 = 100;
        }
    }
    class Program
    {
        pubsEntities entities = new pubsEntities();
        //void InsertEmployee()
        //{
        //    Employee27Oct employee = new Employee27Oct();
        //    Console.WriteLine("Please enter the employee name");
        //    employee.name = Console.ReadLine();
        //    Console.WriteLine("Please enter the employee Age");
        //    employee.age = Convert.ToInt32(Console.ReadLine());
        //    entities.Employee27Oct.Add(employee);
        //    entities.SaveChanges();
        //    Console.WriteLine("Employee Added");
        //}
        //void UpdateEmployeeName()
        //{
            
        //    Console.WriteLine("Please enter the employee Id");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Employee27Oct employee = entities.Employee27Oct.Where(emp => emp.id == id).SingleOrDefault();
        //    if(employee == null)
        //    {
        //        Console.WriteLine("No such employee");
        //        return;
        //    }
        //    Console.WriteLine("Please enter the employee name");
        //    employee.name = Console.ReadLine();
        //    entities.SaveChanges();
        //    Console.WriteLine("Name Updated");
            
        //}
        //void PrintEmployees()
        //{
        //    foreach (var item in entities.Employee27Oct)
        //    {
        //        Console.WriteLine("Employee Name "+item.name);
        //    }
        //}
        //void DeleteEmployee()
        //{
        //    Console.WriteLine("Please enter the employee Id");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Employee27Oct employee = entities.Employee27Oct.Where(emp => emp.id == id).SingleOrDefault();
        //    if (employee == null)
        //    {
        //        Console.WriteLine("No such employee");
        //        return;
        //    }
        //    entities.Employee27Oct.Remove(employee);
        //    entities.SaveChanges();
        //    Console.WriteLine("Employee deleted");
        //}

       void UnderstandingLINQ()
        {
            //var myTitles = entities.titles.Where(t => t.price > 5)
            //                               .OrderBy(t => t.title1)
            //                               .Select((title) => new{BookName=title.title1,BookPrice=title.price })
            //                               .ToList();
            //foreach (var item in myTitles)
            //{
            //    Console.WriteLine("Book name " + item.BookName);
            //    Console.WriteLine("Book price " + item.BookPrice);

            //}
            var result = entities.titles.GroupBy(t => t.pub_id);
            var myTitles = result.Select(d => new { PublisherId = d.Key, TotaPrice = d.Sum(t => t.price) });
            foreach (var item in myTitles)
            {
                Console.WriteLine("Book name "+item.PublisherId);
                Console.WriteLine("Book price " + item.TotaPrice);

            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.DeleteEmployee();
            program.UnderstandingLINQ();
            Console.ReadKey();
        }
    }
}
