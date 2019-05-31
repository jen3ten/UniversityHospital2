using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Janitor : Employee
    {
        public bool SweepingOrNot { get; set; }

        public Janitor(string employeeName, int employeeNumber, int employeeSalary, bool paidOrNot, string employeeType, bool sweepingOrNot) : base(employeeName, employeeNumber, employeeSalary, paidOrNot, employeeType)
        {
            SweepingOrNot = sweepingOrNot;
            ;
        }
    }
}
