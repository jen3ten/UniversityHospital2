using System;
using Xunit;

namespace UniversityHospital2.Tests
{
    public class NurseTests
    {
        [Fact]
        public void NurseExpectedSalaryShouldEqualActual()
        {
            Nurse sut = new Nurse("fake", 0, 0);

            int expectedSalary = 50000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }
    }
}
