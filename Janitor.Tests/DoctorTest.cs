using System;
using Xunit;

namespace UniversityHospital2.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void DoctorActualSalaryShouldEqualExpected()
        {
            Doctor sut = new Doctor("fake", 0, "none");

            int expectedSalary = 90000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }
    }
}
