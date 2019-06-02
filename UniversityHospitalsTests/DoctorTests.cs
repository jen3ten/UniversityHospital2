using System;
using UniversityHospital2;
using Xunit;

namespace UniversityHospitalsTests
{
    public class DoctorTests
    {
        [Fact]
        public void DoctorExpectedSalaryShouldEqualActual()
        {
            Doctor sut = new Doctor("none", 0, "none");

            int expectedSalary = 90000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }

        [Fact]
        public void DoctorExpecteNameShouldEqualActual()
        {
            string expectedName = "Test";

            Doctor sut = new Doctor(expectedName, 0, "none");

            Assert.Matches(expectedName, sut.EmployeeName);
        }
    }
}
