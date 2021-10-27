using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingSerialzationApplication
{
    class Program
    {
        Employee employee;
        Program()
        {
            employee = new Employee();
            employee.Id = 101;
            employee.Name = "Jim";
            employee.Age = 22;
        }
        void SerializeBinary()
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream buffer = File.Create(@"C:\Users\gayat\OneDrive\Desktop\Daily\EmployeeBinary.txt");
            formatter.Serialize(buffer, employee);
            buffer.Close();
        }
        void DeSerializeBinary()
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream buffer = File.OpenRead(@"C:\Users\gayat\OneDrive\Desktop\Daily\EmployeeBinary.txt");
            Employee employee = formatter.Deserialize(buffer) as Employee;
            Console.WriteLine(employee);
            buffer.Close();
        }
        void SerializeXML()
        {
            IFormatter formatter = new SoapFormatter();
            FileStream buffer = File.Create(@"C:\Users\gayat\OneDrive\Desktop\Daily\EmployeeXML.xml");
            formatter.Serialize(buffer, employee);
            buffer.Close();
        }
        void DeSerializeXML()
        {
            IFormatter formatter = new SoapFormatter();
            FileStream buffer = File.OpenRead(@"C:\Users\gayat\OneDrive\Desktop\Daily\EmployeeXML.xml");
            Employee employee = formatter.Deserialize(buffer) as Employee;
            Console.WriteLine(employee);
            buffer.Close();
        }
        void SerializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(employee.GetType());
            FileStream buffer = File.Create(@"C:\Users\gayat\OneDrive\Desktop\Daily\EmployeeJSON.txt");
            jsonSerializer.WriteObject(buffer, employee);
            buffer.Close();
        }
        void DeSerializeJSON()
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Employee));
            FileStream buffer = File.OpenRead(@"C:\Users\gayat\OneDrive\Desktop\Daily\EmployeeJSON.txt");
            Employee employee =jsonSerializer.ReadObject(buffer) as Employee;
            Console.WriteLine(employee);
            buffer.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DeSerializeJSON();
            Console.ReadKey();
        }
    }
}
