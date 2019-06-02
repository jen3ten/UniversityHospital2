using System;
using Xunit;

namespace UniversityHospital2.Tests
{
    public class JanitorTests 
    {
        [Fact]
        public void DoesJanitorPaySalaryMethodShowCorrectSalary()
        {
            Janitor sut = new Janitor("fakeJanitorName", 33, false);

            int expectedSalary = 40000;

            Assert.Equal(expectedSalary, sut.EmployeeSalary);            
        }
    }
}
