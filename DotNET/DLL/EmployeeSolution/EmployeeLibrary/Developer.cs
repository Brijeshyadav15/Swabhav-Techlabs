namespace EmployeeLibrary
{
    public class Developer : Employee
    {
        public override int CalculateSalary()
        {
            return Basic + Pa;
        }
    }
}
