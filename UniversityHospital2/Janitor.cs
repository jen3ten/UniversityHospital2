using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Janitor : Employee
    {
        public bool SweepingOrNot { get; set; }

        public Janitor(string employeeName, int employeeNumber, bool sweepingOrNot) : base(employeeName, employeeNumber, 40000, false, "Janitor")
        {
            SweepingOrNot = sweepingOrNot;           
        }

        public override void PaySalary()
        {
                if (PaidOrNot == false)
                {
                    Console.WriteLine($"You have paid {EmployeeName} $40,000");
                    PaidOrNot = true;
                }
                else
                {
                    Console.WriteLine($"{EmployeeName} has already been paid.");
                }          
        }

        public override void ViewEmployeeStatus()
        {
                Console.WriteLine($"Name: {EmployeeName} | Number: {EmployeeNumber} | Salary: {EmployeeSalary} | Paid: {PaidOrNot} | Position: {EmployeeType}");            
        }
    }
}
