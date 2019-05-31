using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse(string employeeName, int employeeNumber, int employeeSalary, bool paidOrNot, string employeeType, int numberOfPatients) : base(employeeName, employeeNumber, employeeSalary, paidOrNot, employeeType)
        {
            NumberOfPatients = numberOfPatients;
        }
    }
}
