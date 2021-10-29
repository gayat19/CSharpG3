using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingReflectionApplication
{
    class Program
    {
        void CreateEmployee()
        {
            //Employee employee = new Employee();
            //employee.PrintEmployeeData();
            var assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(assembly.FullName);
            //var types = assembly.GetTypes();
            //foreach (var item in types)
            //{
            //    Console.WriteLine("------------"+item.Name);
            //}
            var type = assembly.GetType("UnderstandingReflectionApplication.Employee");
            //var properties = type.GetProperties();
            //foreach (var item in properties)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //var instance = Activator.CreateInstance(type);
            //var myPrintMethod = type.GetMethod("PrintEmployeeData");
            //var mySetMethod = type.GetMethod("SetEmployeeData");
            //object[] parameters = new object[3];
            //parameters[0] = 101;
            //parameters[1] = "Jim";
            //parameters[2] = 21;
            //mySetMethod.Invoke(instance, parameters);
            //myPrintMethod.Invoke(instance, null);
            //Employee employee = new Employee();
            //employee.PrintEmployeeData();
            var attributes = type.GetCustomAttributes(typeof(MyInfoAttribute), false);
            foreach (var item in attributes)
            {
                Console.WriteLine("Developer Name "+((MyInfoAttribute)item).DeveloperName);
                Console.WriteLine("Developed Version " + ((MyInfoAttribute)item).MethodVersion);
            }
            Console.WriteLine("---------------------------------");
            var methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine("Method Name "+item.Name);
                var mattributes = item.GetCustomAttributes(typeof(MyInfoAttribute), false);
                foreach (var attribute in mattributes)
                {
                    Console.WriteLine("--------------Developer Name " + ((MyInfoAttribute)attribute).DeveloperName);
                    Console.WriteLine("--------------Developed Version " + ((MyInfoAttribute)attribute).MethodVersion);
                }
            }
        }
        static void Main(string[] args)
        {
            new Program().CreateEmployee();
            Console.ReadKey();
        }
    }
    [MyInfo("G3",1)]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [MyInfo("Jim", 3)]
        public void PrintEmployeeData()
        {
            Console.WriteLine("Employee data");
            Console.WriteLine("Employee ID " + Id);
            Console.WriteLine("Employee Name " + Name);
            Console.WriteLine("Employee ID " + Age);
        }
        [MyInfo("Kim", 4)]
        public void SetEmployeeData(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
