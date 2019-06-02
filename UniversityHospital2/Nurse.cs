using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse(string employeeName, int employeeNumber , int numberOfPatients) : base(employeeName, employeeNumber, 50000, false, "Nurse")
        {
            NumberOfPatients = numberOfPatients;
        }
       
        public override void PaySalary()
        {           
             if (PaidOrNot == false)
             {
                 Console.WriteLine($"You have paid {EmployeeName} $50,000");
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
