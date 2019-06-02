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
    }
}
