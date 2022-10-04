using EnterpriseSystem.Entities;

namespace EnterpriseSystem.Service
{
    // Sorter for Employee class objects and its successors
    public class EmployeeSorter : IComparer<Employee> // implemented contravariant generic interface
    {
        public int Compare(Employee employee, Employee other)
        {
            if (employee != null && other != null)
            {
                if (!employee.Name.Equals(other.Name))
                {
                    return employee.Name.CompareTo(other.Name);
                }
                else if (!employee.AverageIncome.Equals(other.AverageIncome))
                {
                    return employee.AverageIncome.CompareTo(other.AverageIncome);
                }
                else
                {
                    return employee.BirthDate.CompareTo(other.BirthDate);
                }
            }

            throw new Exception("Cannot compare objects");
        }
    }
}
