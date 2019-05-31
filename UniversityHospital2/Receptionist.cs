using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    internal class Receptionist : Employee
    {
        public bool PhoneOrNot { get; set; }

        public Receptionist(string employeeName, int employeeNumber, bool phoneOrNot) : base(employeeName, employeeNumber, 45000, false, "Receptionist")
        {
            PhoneOrNot = phoneOrNot;
        }

        List<Receptionist> ReceptionistList = new List<Receptionist>();

        public void HireReceptionist()
        {
            Receptionist receptionist = new Receptionist("Fred", 23, false);

            Console.WriteLine("What is the receptionist's name?");
            receptionist.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is the receptionist's employee number?");
            receptionist.EmployeeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the receptionist talking on phone? ");
            Console.WriteLine("1: Yes\n 2: No");
            string phoneMenu = Console.ReadLine();

            if (phoneMenu == "1")
            {
                receptionist.PhoneOrNot = true;
            }
            else
            {
                receptionist.PhoneOrNot = false;
            }

            ReceptionistList.Add(receptionist);
        }
        public override void PaySalary()
        {
            foreach (Receptionist receptionist in ReceptionistList)
            {
                if (receptionist.PaidOrNot == false)
                {
                    Console.WriteLine($"You have paid {receptionist.EmployeeName} $45,000");
                    receptionist.PaidOrNot = true;
                }
                else
                {
                    Console.WriteLine($"{receptionist.EmployeeName} has already been paid.");
                }
            }
        }
        public override void ViewEmployeeStatus()
        {

        foreach (Receptionist receptionist in ReceptionistList)
            {
                Console.WriteLine($"Name: {receptionist.EmployeeName} | Number: {receptionist.EmployeeNumber} | Salary: {receptionist.EmployeeSalary} | Paid: {receptionist.PaidOrNot} | Position: {receptionist.EmployeeType}");
                    
            }
        }
            

    }
} 