using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibrary
{
    public class InvalidAgeException : Exception
    {
        string msg;
        public InvalidAgeException()
        {
            msg = "Invalid Age. Age should be between 18 and 56";
        }
        public InvalidAgeException(int age)
        {
            msg = "Invalid Age "+age+". Age should be between 18 and 56";
        }
        public override string Message => msg;
    }
}
