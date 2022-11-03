using DAL;
using DTO;

namespace BLL
{
    public class EmployeeBLL
    {
        public void SaveEmployee(EmployeeDTO dto)
        {
            dto.Tax = CalculateTax(dto.Salary);
            EmployeeDAL dal = new();
            dal.SaveEmployee(dto);
        }

        public List<EmployeeDTO> GetAllEmployees()
        {
            EmployeeDAL dal = new();
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            employees = dal.ReadAllEmployees();
            foreach (EmployeeDTO employee in employees)
            {
                employee.Salary *= 2;
            }
            return employees;
        }

        public double CalculateTax(int salary)
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