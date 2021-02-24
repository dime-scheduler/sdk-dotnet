using System;
using System.ComponentModel;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Utils
{
    internal enum Department
    {
        [Description("Marketing")]
        Marketing,

        Sales,

        [Description("R&D")]
        RnD,

        Administration
    }

    internal class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Department Department { get; set; }
    }

    public class EnumExtensionsTests
    {
        [Fact]
        public void EnumExtensions_GetDescription_HasDescription_ShouldReturnDescription()
        {
            Employee newEmployee = new() { Department = Department.RnD, FirstName = "Max", LastName = "Power" };
            Assert.True(newEmployee.Department.GetDescription() == "R&D");
        }

        [Fact]
        public void EnumExtensions_GetDescription_HasNoDescription_ShouldReturnToString()
        {
            Employee newEmployee = new() { Department = Department.Marketing, FirstName = "Max", LastName = "Power" };
            Assert.True(newEmployee.Department.GetDescription() == "Marketing");
        }

        [Fact]
        public void EnumExtensions_GetDescription_NotAnEnum_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => 1.GetDescription());
        }
    }
}