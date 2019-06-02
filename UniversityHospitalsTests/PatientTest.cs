using System;
using UniversityHospital2;
using Xunit;

namespace UniversityHospitalsTests
{
    public class PatientTests
    {
        [Fact]
        public void ExpectedBloodLevelShouldEqualActual()
        {
            Patient sut = new Patient("sut");

            sut.BloodLevel = 50;

            Assert.Equal(50, sut.BloodLevel);
        }

        [Fact]
        public void ExpectedHealthLevelShouldEqualActual()
        {
            Patient sut = new Patient("sut");

            sut.HealthLevel = 25;

            Assert.Equal(25, sut.HealthLevel);
        }
    }
}
