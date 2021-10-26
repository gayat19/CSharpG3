using System;
using CompanyLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompanyAppTest
{
    [TestClass]
    public class EmployeeUnitTest
    {
        [TestMethod]
        public void TestGetNumber()
        {
            //Arrange
            Employee employee = new Employee();
            //Act
            int num = employee.GetNumber()%2;
            //Assert
            Assert.AreEqual(0, num);
        }
    }
}
