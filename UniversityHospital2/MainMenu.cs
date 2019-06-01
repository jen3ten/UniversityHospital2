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
        //Nurse & Doctor Interact

        public void GetMainMenu()
        {
            EmployeeDatabase universityHospitals = new EmployeeDatabase();
            bool running = true;
            do
            {
                Console.WriteLine("Menu ---- Choices");
                string mainMenu = Console.ReadLine();
                switch (mainMenu)
                {
                    case "1":
                        universityHospitals.ViewDatabase();
                        break;

                    case "2":
                        //Hiring
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;
                }
            }
            while (running);
        }




    }
}
