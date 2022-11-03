using BLL;
using DTO;

namespace PL
{
    public class EmployeeView
    {
        public void InputEmployee()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            EmployeeDTO dto = new EmployeeDTO
            {
                Name = name,
                Salary = salary
            };

            EmployeeBLL bll = new();
            bll.SaveEmployee(dto);
        }

        public void ShowEmployees()
        {
            EmployeeBLL bll = new();
            List<EmployeeDTO> employees = bll.GetAllEmployees();

            Console.Clear();

            foreach (EmployeeDTO employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}