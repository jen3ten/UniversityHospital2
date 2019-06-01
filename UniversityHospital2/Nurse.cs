using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    internal class Nurse : Employee
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

       /* public void SelectNurse()
        {
            int i = 0;    
            foreach (Nurse nurse in NurseList)
            {
                i += 1;
                Console.WriteLine(i + ": " + nurse.EmployeeName);
            }
            Console.WriteLine("Select a nurse by number.");
            int nurseSelect = Convert.ToInt32(Console.ReadLine());
            NurseList[nurseSelect - 1].INTERACT();
            */

        
    }
}
