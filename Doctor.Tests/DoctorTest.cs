using System;
using Xunit;

namespace Doctor.Tests
{
    public class DoctorTest
    {
        [Fact]
        public void DoctorSalaryShouldEqualActualDoctorSalary()
        {
              = new Doctor("fakeJanitorName", 33, false);

            int actualSalary = 40000;

            Assert.Equal(actualSalary, sut.EmployeeSalary);
        }
    }
}
