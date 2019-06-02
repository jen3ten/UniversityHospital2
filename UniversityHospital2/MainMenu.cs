using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityHospital2
{
    class MainMenu
    {
        //EmployeeInfo
        //Pay All Employees
        //Patient Info
        //Get Doc
        //Get Nurse
        //Hire(Add)

        public void GetMainMenu()
        {
            Patient hospitalPatients = new Patient("Patient");
            hospitalPatients.AddPatients();
            EmployeeDatabase universityHospitals = new EmployeeDatabase();           
            bool running = true;
            Console.WriteLine("University Hospitals Database");
            do
            {
                Console.WriteLine("Press enter to continue:");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1: View Employee Database\n2: Hire Employee\n3: Pay all unpaid Employees\n4: Patient Database\n5: Select medical care\n6: Close program");
                string mainMenu = Console.ReadLine();
                switch (mainMenu)
                {
                    case "1":
                        universityHospitals.ViewDatabase();
            
                        break;

                    case "2":
                        Console.WriteLine("1: Hire Receptionist\n2: Hire Janitor\n3: Hire Nurse\n4: Hire Doctor");
                        string hireMenu = Console.ReadLine();
                        switch (hireMenu)
                        {
                            case "1":
                                universityHospitals.HireReceptionist();
                                break;
                            case "2":
                                universityHospitals.HireJanitor();
                                break;
                            case "3":
                                universityHospitals.HireNurse();
                                break;
                            case "4":
                                universityHospitals.HireDoctor();
                                break;
                        }   
                        break;

                    case "3":
                        universityHospitals.PayDatabase();
                        break;

                    case "4":
                        
                        hospitalPatients.ViewPatients();
                        break;

                    case "5":
                        Console.WriteLine("1: Blood draw from nurse\n2: Care from nurse\n3: Blood draw from doctor\n4: Care from doctor");
                        string medicalCare = Console.ReadLine();
                        switch (medicalCare)
                        {
                            case "1":
                                universityHospitals.GetNurseBloodDraw();
                                hospitalPatients.NurseDraw();
                                break;
                            case "2":
                                universityHospitals.GetNurseHealthCare();
                                hospitalPatients.NurseCare();
                                break;
                            case "3":
                                universityHospitals.GetDoctorBloodDraw();
                                hospitalPatients.DoctorDraw();
                                break;
                            case "4":
                                universityHospitals.GetDoctorHealthCare();
                                hospitalPatients.DoctorCare();
                                break;

                        }
                        break;
                    case "6":
                        running = false;
                        break;
                }
            }
            while (running);
        }




    }
}
