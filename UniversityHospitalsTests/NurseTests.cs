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
    }
}
