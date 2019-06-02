using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Receptionist : Employee
    {
        public bool PhoneOrNot { get; set; }

        public Receptionist(string employeeName, int employeeNumber, bool phoneOrNot) : base(employeeName, employeeNumber, 45000, false, "Receptionist")
        {
            PhoneOrNot = phoneOrNot;
        }
     
        public override void PaySalary()
        {
             if (PaidOrNot == false)
             {
                 Console.WriteLine($"You have paid {EmployeeName} $45,000");
                 PaidOrNot = true;
             }
             else
             {
                 Console.WriteLine($"{EmployeeName} has already been paid.");
             }
        }
        
        public override void ViewEmployeeStatus()
        {
            Console.WriteLine($"Name: {EmployeeName} | Number: {EmployeeNumber} | Salary: {EmployeeSalary} | Paid: {PaidOrNot} | Position: {EmployeeType} | On Phone: {PhoneOrNot}");                   
        }
    }            
} 