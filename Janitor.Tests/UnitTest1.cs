using System;
using Xunit;

namespace UniversityHospital2.Tests
{
    public class JanitorTests
    {
        [Fact]
        public void DoesJanitorPaySalaryMethodShowCorrectSalary()
        {
            string fakeJanitorName = "";
            int fakeJanitorNumber = 4;
            bool fakeSweepingOrNot = false;

            Janitor sut = new Janitor(fakeJanitorName, fakeJanitorNumber, fakeSweepingOrNot);

            sut.PaySalary();
            Assert.True(40000, EmployeeSalary);

        }
    }
}
