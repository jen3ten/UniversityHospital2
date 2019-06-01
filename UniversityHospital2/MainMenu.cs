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
                Console.WriteLine("Press any key to continue:");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1: View Employee Database\n2: Hire Employee\n3: Pay all unpaid Employees\n4: Patient Database\n5: Menu Choice");
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
                        universityHospitals.GetNurseBloodDraw();
                        hospitalPatients.NurseDraw();
                        break;
                }
            }
            while (running);
        }




    }
}
