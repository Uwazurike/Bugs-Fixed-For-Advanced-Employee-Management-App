using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Employee_management_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\iykef\\OneDrive\\Documents\\workforce.xml";
            List<Employee> myWorkers = new List<Employee>();
            if (File.Exists(fileName))
            {
                Methods.ReadInFile(fileName, myWorkers);
            }
            bool mainLoop = true;
            while (mainLoop)
            {
                Methods.MenuDisplay();
                string userValue = Methods.UserInput();

                if (userValue == "1")
                {
                    Methods.CreateNewEmployee(myWorkers);
                }
                else if (userValue == "2")
                {
                    Methods.GiveEmployeeRaise(myWorkers);
                }
                else if (userValue == "3")
                {
                    Methods.PayAllEmployees(myWorkers);
                }
                else if (userValue == "4")
                {
                    Methods.DisplayAllEmployees(myWorkers);
                }
                else if (userValue == "5")
                {
                    Methods.TerminateEmployee(myWorkers);
                }
                else if (userValue == "6")
                {
                    Methods.WriteFile(myWorkers);
                    mainLoop = false;
                }
                else
                {
                    Methods.InvalidEntry();
                }
            }
            Console.ReadLine();
        }
    }
}

