namespace DTO
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public double Tax { get; set; }

        public override string ToString()
        {
            return $"====================\n" +
                   $"Employee Info\n" +
                   $"====================\n" +
                   $"Name: {Name}\n" +
                   $"Salary: {Salary}\n" +
                   $"Tax:{Tax}\n"+
                   $"====================\n";
        }
    }
}