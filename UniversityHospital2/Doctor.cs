using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor(string employeeName, int employeeNumber, string specialty) : base(employeeName, employeeNumber ,90000, false, "doctor")
        {
            Specialty =specialty;            
        }

        List<Doctor> DoctorList = new List<Doctor>();

        public void HireDoctor()
        {
            Doctor doctor = new Doctor("Fred", 23, "surgeon");

            Console.WriteLine("What is the doctor's name?");
            doctor.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is the doctor's employee number?");
            doctor.EmployeeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the doctor's specialty?");
            doctor.Specialty = Console.ReadLine();

            DoctorList.Add(doctor);

        }
    }
}
