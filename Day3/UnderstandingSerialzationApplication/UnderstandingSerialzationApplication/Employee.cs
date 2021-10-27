using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingSerialzationApplication
{
    [Serializable]
    public class Employee :ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee()
        {

        }
        public Employee(SerializationInfo info, StreamingContext context)
        {
            this.Id = Convert.ToInt32(info.GetValue("EmployeeID", typeof(int)).ToString());
            this.Name = info.GetValue("EmployeeName", typeof(string)).ToString();
            this.Age = Convert.ToInt32(info.GetValue("EmployeeAge", typeof(int)).ToString());
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EmployeeID", this.Id);
            info.AddValue("EmployeeName", this.Name);
            info.AddValue("EmployeeAge", this.Age);
        }
        public override string ToString()
        {
            return "Id " + Id + " Name " + Name + " Age " + Age;
        }
    }
}
