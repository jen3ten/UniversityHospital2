using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Receptionist : Employee
    {
        public bool PhoneOrNot { get; set; }

        public Receptionist(string employeeName, int employeeNumber, bool phoneOrNot) : base(employeeName, employeeNumber, 45000, false, "Receptionist")
        {
            PhoneOrNot = phoneOrNot;
            ;
        }
    }
}