using System;
using UniversityHospital2;
using Xunit;

namespace UniversityHospitalsTests
{
    public class ReceptionistTests
    {
        [Fact]
        public void ReceptionistExpectedSalaryShouldEqualActual()
        {
            Receptionist sut = new Receptionist("none", 0, false);

            int expectedSalary = 45000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }

        [Fact]
        public void ReceptionistExpectedNameShouldMatchActual()
        {
            string expectedName = "Test";

            Receptionist sut = new Receptionist(expectedName, 0, false);

            Assert.Matches(expectedName, sut.EmployeeName);
        }
    }
}
