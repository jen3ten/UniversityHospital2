using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Patient
    {
        public string PatientName { get; set; }
        public int BloodLevel { get; set; }
        public int HealthLevel { get; set; }

        public Patient(string patientName)
        {
            PatientName = patientName;
            BloodLevel = 20;
            HealthLevel = 10;
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

        public List<Patient> PatientList = new List<Patient>();
        

    public void AddPatients()
    {

        Patient patient = new Patient("Alex");
        PatientList.Add(patient);
        Patient patientSally = new Patient("Sally");
        PatientList.Add(patientSally);
        Patient patientGreg = new Patient("Greg");
        PatientList.Add(patientGreg);
        Patient patientKyle = new Patient("Kyle");
        PatientList.Add(patientKyle);

    }

    public void ViewPatients()
        {
            foreach (Patient patient in PatientList)
            {
                Console.WriteLine($"{PatientName}:     BloodLevel: {BloodLevel} HealthLevel: { HealthLevel} ");
            }
        }

        
    }
}
