using PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    public class Driver
    {
        public static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Add Employee");
            Console.WriteLine("2-View ALl Employees");
            Console.WriteLine("3-Exit");
        }
        public static void Main()
        {
            string choice;
            EmployeeView view = new();
            while (true)
            {
                Menu();
                Console.Write("Enter Your Choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        view.InputEmployee();
                        break;
                    case "2":
                        view.ShowEmployees();
                        break;
                    case "3":
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
