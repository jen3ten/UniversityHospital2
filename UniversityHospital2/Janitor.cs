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
            ;
        }
    }
}
