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
}