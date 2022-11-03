using DTO;
using System.Text.Json;

namespace DAL
{
    public class EmployeeDAL:BaseDAL
    {
        public static void SaveEmployee(EmployeeDTO dto)
        {
            Save(dto);
        }

        public static List<EmployeeDTO> ReadAllEmployees()
        {
            List<string> data = Read("Employees.txt");
            List<EmployeeDTO> employees = new();

            foreach (string employee in data)
            { 
                employees.Add(JsonSerializer.Deserialize<EmployeeDTO>(employee));
            }
            return employees;
        }
    }
}