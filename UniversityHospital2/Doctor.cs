using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    internal class Doctor : Employee
    {
        List<Doctor> DoctorList = new List<Doctor>();

        public string Specialty { get; set; }

        public Doctor(string employeeName, int employeeNumber, string specialty) : base(employeeName, employeeNumber ,90000, false, "doctor")
        {
            Specialty =specialty;            
        }
         
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
        public override void PaySalary()
        {
            foreach (Doctor doctor in DoctorList)
            {
                if (doctor.PaidOrNot == false)
                {
                    Console.WriteLine($"You have paid {doctor.EmployeeName} $90,000");
                    doctor.PaidOrNot = true;
                }
                else
                {
                    Console.WriteLine($"{doctor.EmployeeName} has already been paid.");
                }
            }
        }

        public override void ViewEmployeeStatus()
        {

            foreach (Doctor doctor in DoctorList)
            {
                Console.WriteLine($"Name: {doctor.EmployeeName} | Number: {doctor.EmployeeNumber} | Salary: {doctor.EmployeeSalary} | Paid: {doctor.PaidOrNot} | Position: {doctor.EmployeeType}");

            }
        }
    }
}
