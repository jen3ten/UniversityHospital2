using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Patient
    {
        List<Patient> PatientList = new List<Patient>();
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
            foreach (Patient patient in PatientList)
                patient.HealthLevel += 1;
        }

        public void DoctorCare()
        {
            foreach (Patient patient in PatientList)
               patient.HealthLevel += 2;
        }

        public void NurseDraw()
        {
            foreach (Patient patient in PatientList)
                patient.BloodLevel -= 1;
        }

        public void DoctorDraw()
        {
            foreach (Patient patient in PatientList)
                patient.BloodLevel -= 2;
        }

        public  void AddPatients()
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
            foreach (Patient element in PatientList)
            {
                Console.WriteLine($"{element.PatientName}:     BloodLevel: {element.BloodLevel} HealthLevel: { element.HealthLevel} ");
            }
            Console.WriteLine(" ");
        }       
    }
}
