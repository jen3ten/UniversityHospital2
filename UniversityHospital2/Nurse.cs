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
        List<Nurse> NurseList = new List<Nurse>();

        public void HireNurse()
        {
            Nurse nurse = new Nurse("Fanny", 23, 47);

            Console.WriteLine("What is the nurse's name?");
            nurse.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is the nurse's employee number?");
            nurse.EmployeeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many patients does the nurse have?");
            nurse.NumberOfPatients = Convert.ToInt32(Console.ReadLine());

            NurseList.Add(nurse);

        }

        public override void PaySalary()
        {
            foreach (Nurse nurse in NurseList)
            {
                if (nurse.PaidOrNot == false)
                {
                    Console.WriteLine($"You have paid {nurse.EmployeeName} $50,000");
                    nurse.PaidOrNot = true;
                }
                else
                {
                    Console.WriteLine($"{nurse.EmployeeName} has already been paid.");
                }
            }
        }

        public override void ViewEmployeeStatus()
        {

            foreach (Nurse nurse in NurseList)
            {
                Console.WriteLine($"Name: {nurse.EmployeeName} | Number: {nurse.EmployeeNumber} | Salary: {nurse.EmployeeSalary} | Paid: {nurse.PaidOrNot} | Position: {nurse.EmployeeType}");

            }
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
}
