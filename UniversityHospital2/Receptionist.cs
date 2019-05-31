using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Receptionist : Employee
    {
        public bool PhoneOrNot { get; set; }

        public Receptionist(string employeeName, int employeeNumber, int employeeSalary, bool paidOrNot, string employeeType, bool phoneOrNot) : base(employeeName, employeeNumber, employeeSalary, paidOrNot, employeeType)
        {
            PhoneOrNot = phoneOrNot;
            ;
        }
    }
}