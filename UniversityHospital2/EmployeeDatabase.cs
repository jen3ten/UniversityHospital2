using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    public class EmployeeDatabase
    {
        public List<Receptionist> ReceptionistList = new List<Receptionist>();
        public List<Janitor> JanitorList = new List<Janitor>();
        public List<Nurse> NurseList = new List<Nurse>();
        public List<Doctor> DoctorList = new List<Doctor>();

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

        public void AddDoctor()
        {
            Doctor doctorBob = new Doctor("Bob", 23, "surgeon");
            DoctorList.Add(doctorBob);
            Doctor doctorSuzy = new Doctor("Suzy", 44, "podiatrist");
            DoctorList.Add(doctorSuzy);
            Doctor doctorLindsay = new Doctor("Lindsay", 32, "geriatrics");
            DoctorList.Add(doctorLindsay);
            Doctor doctorMike = new Doctor("Mike", 12, "surgeon");
            DoctorList.Add(doctorMike);
        }

        public void ViewPremadeDoctors()
        {
            foreach (Doctor element in DoctorList)
            {
                Console.WriteLine($"{element.EmployeeName}:     BloodLevel: {element.EmployeeNumber} HealthLevel: { element.Specialty} ");
            }
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
            Console.WriteLine(" ");
        }

        public void PayDatabase()
        {
            foreach (Receptionist receptionist in ReceptionistList)
            {
                receptionist.PaySalary();
            }
            foreach (Janitor janitor in JanitorList)
            {
                janitor.PaySalary();
            }
            foreach (Nurse nurse in NurseList)
            {
                nurse.PaySalary();
            }
            foreach (Doctor doctor in DoctorList)
            {
                doctor.PaySalary();
            }
        }

        public void GetNurseBloodDraw()
        {
            int i = 0;
            foreach (Nurse nurse in NurseList)
            {
                i += 1;
                Console.WriteLine(i + ": " + nurse.EmployeeName);
            }
            Console.WriteLine("Select a nurse by number.");
            int nurseSelect = Convert.ToInt32(Console.ReadLine());
            if (nurseSelect > 0 && nurseSelect <= i)
            {
                Console.WriteLine($"You have selected {NurseList[nurseSelect - 1].EmployeeName} to draw blood.");
            }
            else
            {
                Console.WriteLine("That nurse does not exist. Try entering a different number or hiring a nurse.");
            }
        }

        public void GetNurseHealthCare()
        {
            int i = 0;
            foreach (Nurse nurse in NurseList)
            {
                i += 1;
                Console.WriteLine(i + ": " + nurse.EmployeeName);
            }
            Console.WriteLine("Select a nurse by number.");
            int nurseSelect = Convert.ToInt32(Console.ReadLine());
            if (nurseSelect > 0 && nurseSelect <= i)
            {
                Console.WriteLine($"You have selected {NurseList[nurseSelect - 1].EmployeeName} to care for patients.");
            }
            else
            {
                Console.WriteLine("That nurse does not exist. Try entering a different number or hiring a nurse.");
            }
        }

        public void GetDoctorBloodDraw()
        {
            int i = 0;
            foreach (Doctor doctor in DoctorList)
            {
                i += 1;
                Console.WriteLine(i + ": " + doctor.EmployeeName);
            }
            Console.WriteLine("Select a doctor by number.");
            int doctorSelect = Convert.ToInt32(Console.ReadLine());
            if (doctorSelect > 0 && doctorSelect <= i)
            {
                Console.WriteLine($"You have selected {DoctorList[doctorSelect - 1].EmployeeName} to draw blood.");
            }
            else
            {
                Console.WriteLine("That doctor does not exist. Try entering a different number or hiring a doctor.");
            }
        }

        public void GetDoctorHealthCare()
        {
            int i = 0;
            foreach (Doctor doctor in DoctorList)
            {
                i += 1;
                Console.WriteLine(i + ": " + doctor.EmployeeName);
            }
            Console.WriteLine("Select a doctor by number.");
            int doctorSelect = Convert.ToInt32(Console.ReadLine());
            if (doctorSelect > 0 && doctorSelect <= i)
            {
                Console.WriteLine($"You have selected {DoctorList[doctorSelect - 1].EmployeeName} to care for patients.");
            }
            else
            {
                Console.WriteLine("That doctor does not exist. Try entering a different number or hiring a doctor.");
            }   
        }
    }
}
