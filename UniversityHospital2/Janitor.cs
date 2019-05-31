using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    internal class Janitor : Employee
    {
        public bool SweepingOrNot { get; set; }

        public Janitor(string employeeName, int employeeNumber, bool sweepingOrNot) : base(employeeName, employeeNumber, 40000, false, "Janitor")
        {
            SweepingOrNot = sweepingOrNot;           
        }

        List<Janitor> JanitorList = new List<Janitor>();

        public void HireJanitor()
        {
            Janitor janitor = new Janitor("Fred", 23, false);

            Console.WriteLine("What is the janitor's name?");
            janitor.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is the janitor's employee number?");
            janitor.EmployeeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the janitor sweeping? ");
            Console.WriteLine("1: Yes\n 2: No");
            string sweepingMenu = Console.ReadLine();

            if (sweepingMenu == "1")
            {
                janitor.SweepingOrNot = true;
            }
            else
            {
                janitor.SweepingOrNot = false;
            }
                          
            JanitorList.Add(janitor);
        }
    }
}
