using System;
using Xunit;

namespace UniversityHospital2.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void ReceptionistExpectedSalaryShouldEqualActual()
        {
            Receptionist sut = new Receptionist("fake", 0, false);

            int expectedSalary = 45000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }
    }
}
