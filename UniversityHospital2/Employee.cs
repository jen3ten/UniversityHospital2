using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
        public int EmployeeSalary { get; set; }
        public bool PaidOrNot { get; set; }
        public string EmployeeType { get; set; }

        public Employee(string employeeName, int employeeNumber, int employeeSalary, bool paidOrNot, string employeeType)
        {
            EmployeeName = employeeName;
            EmployeeNumber = employeeNumber;
            EmployeeSalary = employeeSalary;
            PaidOrNot = paidOrNot;
            EmployeeType = employeeType;
        }

        public abstract void PaySalary();
    }

}


