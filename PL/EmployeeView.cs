using BLL;
using DTO;

namespace PL
{
    public class EmployeeView
    {
        public static void InputEmployee()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            EmployeeDTO dto = new()
            {
                Name = name,
                Salary = salary
            };
            EmployeeBLL.SaveEmployee(dto);
        }

        public static void ShowEmployees()
        {
            List<EmployeeDTO> employees = EmployeeBLL.GetAllEmployees();

            Console.Clear();

            foreach (EmployeeDTO employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}