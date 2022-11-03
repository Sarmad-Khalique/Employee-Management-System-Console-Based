using DAL;
using DTO;

namespace BLL
{
    public class EmployeeBLL
    {
        public static void SaveEmployee(EmployeeDTO dto)
        {
            dto.Tax = CalculateTax(dto.Salary);

            EmployeeDAL.SaveEmployee(dto);
        }

        public static List<EmployeeDTO> GetAllEmployees()
        {
            List<EmployeeDTO> employees = EmployeeDAL.ReadAllEmployees();
            foreach (EmployeeDTO employee in employees)
            {
                employee.Salary *= 2;
            }
            return employees;
        }

        public static double CalculateTax(int salary)
        {
            if (salary <= 100)
            {
                return 10f;
            }else if (salary <= 200)
            {
                return 20f;
            }
            return 30f;
        }
    }
}