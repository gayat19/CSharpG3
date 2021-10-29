using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingReflectionApplication
{
    [AttributeUsage(AttributeTargets.All)]
    public class MyInfoAttribute:Attribute
    {
        string developerName;
        int methodVersion;

        public string DeveloperName { get => developerName;  }
        public int MethodVersion { get => methodVersion;  }

        public MyInfoAttribute(string developerName, int methodVersion)
        {
            this.developerName = developerName;
            this.methodVersion = methodVersion;
        }
    }
}
