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
        
        public override void PaySalary()
        {          
                if (PaidOrNot == false)
                {
                    Console.WriteLine($"You have paid {EmployeeName} $90,000");
                    PaidOrNot = true;
                }
                else
                {
                    Console.WriteLine($"{EmployeeName} has already been paid.");
                }   
        }

        public override void ViewEmployeeStatus()
        {
            Console.WriteLine($"Name: {EmployeeName} | Number: {EmployeeNumber} | Salary: {EmployeeSalary} | Paid: {PaidOrNot} | Position: {EmployeeType} | Specialty: {Specialty}");
     
        }
    }
}
