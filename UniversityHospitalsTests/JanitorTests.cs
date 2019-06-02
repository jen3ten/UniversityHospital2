using System;
using UniversityHospital2;
using Xunit;

namespace UniversityHospitalsTests
{
    public class JanitorTests
    {
        [Fact]
        public void JanitorExpectedSalaryShouldEqualActual()
        {
            Janitor sut = new Janitor("none", 0, false);

            int expectedSalary = 40000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);
        }

        [Fact]
        public void JanitorExpectedNameShouldMatchActual()
        {
            string expectedName = "Test";

            Janitor sut = new Janitor(expectedName, 0, false);

            Assert.Matches(expectedName, sut.EmployeeName);
        }
    }
}
