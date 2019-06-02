using System;
using UniversityHospital2;
using Xunit;

namespace UniversityHospitalsTests
{
    public class NurseTests
    {
        [Fact]
        public void NurseExpectedSalaryShouldEqualActual()
        {
            Nurse sut = new Nurse("none", 0, 0);

            int expectedSalary = 50000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }

        [Fact]
        public void NurseExpectedNameShouldMatchActual()
        {
            string expectedName = "Test";

            Nurse sut = new Nurse(expectedName, 0, 0);

            Assert.Matches(expectedName, sut.EmployeeName);
        }
    }
}
