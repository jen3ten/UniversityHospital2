using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    class EmployeeDatabase
    {
        List<Receptionist> ReceptionistList = new List<Receptionist>();
        List<Janitor> JanitorList = new List<Janitor>();
        List<Nurse> NurseList = new List<Nurse>();
        List<Doctor> DoctorList = new List<Doctor>();

        public void HireReceptionist()
        {
            Receptionist receptionist = new Receptionist("Fred", 23, false);
            Console.WriteLine("What is the receptionist's name?");
            receptionist.EmployeeName = Console.ReadLine();
            Console.WriteLine("What is the receptionist's employee number?");
            receptionist.EmployeeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is the receptionist talking on phone? ");
            Console.WriteLine("1: Yes\n 2: No");
            string phoneMenu = Console.ReadLine();

            if (phoneMenu == "1")
            {
                receptionist.PhoneOrNot = true;
            }
            else
            {
                receptionist.PhoneOrNot = false;
            }

            ReceptionistList.Add(receptionist);
        }

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

        public void HireDoctor()
        {
            Doctor doctor = new Doctor("Fred", 23, "surgeon");
            Console.WriteLine("What is the doctor's name?");
            doctor.EmployeeName = Console.ReadLine();
            Console.WriteLine("What is the doctor's employee number?");
            doctor.EmployeeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the doctor's specialty?");
            doctor.Specialty = Console.ReadLine();
            DoctorList.Add(doctor);
        }

        public void ViewDatabase()
        {
            foreach (Receptionist receptionist in ReceptionistList)
            {
                receptionist.ViewEmployeeStatus();
            }
            foreach (Janitor janitor in JanitorList)
            {
                janitor.ViewEmployeeStatus();
            }
            foreach (Nurse nurse in NurseList)
            {
                nurse.ViewEmployeeStatus();
            }
            foreach (Doctor doctor in DoctorList)
            {
                doctor.ViewEmployeeStatus();
            }   
        }
    }
}
