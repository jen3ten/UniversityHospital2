﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse(string employeeName, int employeeNumber , int numberOfPatients) : base(employeeName, employeeNumber, 50000, false, "Nurse")
        {
            NumberOfPatients = numberOfPatients;

        }
        List<Nurse> NurseList = new List<Nurse>();

        public void HireNurse()
        {
            Nurse nurse = new Nurse("Fanny", 23, 47);

            Console.WriteLine("What is the nurse's name?");
            nurse.EmployeeName = Console.ReadLine();

            Console.WriteLine("What is the nurse's employee number?");
            nurse.EmployeeNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many patients does the nurse have?");
            nurse.NumberOfPatients = Convert.ToInt32(Console.ReadLine());

            NurseList.Add(nurse);

        }
    }
}
