using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    class Patient
    {
        public string PatientName { get; set; }
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }

        public Patient(string patientName, int bloodLevel, int healthLevel)
        {
            PatientName = patientName;
            BloodLevel = 20;
            HealthLevel =10;
            
        }
        public void NurseCare()
        {
            HealthLevel += 1; 
        }
        public void DoctorCare()
        {
            HealthLevel += 2;
        }
        public void NurseDraw()
        {
            BloodLevel -= 1;
        }
        public void DoctorDraw()
        {
            BloodLevel -= 2;
        }
    }
}
