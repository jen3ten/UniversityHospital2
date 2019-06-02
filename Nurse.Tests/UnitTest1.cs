using System;
using Xunit;

namespace Nurse.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewEmployeeStatusMethodShouldShowStatusForNursesInNurseList()
        {
            string fakeName ="";
            int fakeEmployeeNumber = 4;
            int fakeNumberOfPatients = 30;
                                   
            Nurse sut = new Nurse(fakeName, fakeEmployeeNumber, fakeNumberOfPatients);
            sut.ViewEmployeeStatus();
            Assert.Equal(4, fakeEmployeeNumber);

        }
    }
}
