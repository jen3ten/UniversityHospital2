using System;

namespace UniversityHospital2
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Fred", 23, "surgeon");
            Console.WriteLine(doctor.EmployeeSalary + "");

            Nurse nurse = new Nurse("Suzy", 25, 30);

            Receptionist receptionist = new Receptionist("Frank", 45, false);

            Janitor janitor = new Janitor("Gwen", 79, true);


            
        }
    }
}
