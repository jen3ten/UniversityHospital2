using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }

        public Doctor(string employeeName, int employeeNumber, int employeeSalary, bool paidOrNot, string employeeType, string specialty) : base(employeeName, employeeNumber, employeeSalary, paidOrNot, employeeType)
        {
            Specialty = specialty;
        }
    }
}
