using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleWCFApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IEmployeeService
    {
        static Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
        {
            { 101,new Employee(){Id=101,Name="Tim",Age=21} },
            { 102,new Employee(){Id=102,Name="Kim",Age=27} }
        };
        public Employee AddEmployee(Employee composite)
        {
            employees.Add(composite.Id, composite);
            return composite;
        }

        public IEnumerable<Employee> GetEmployee(int value)
        {
            return employees.Values.ToList() ;
        }
    }
}
