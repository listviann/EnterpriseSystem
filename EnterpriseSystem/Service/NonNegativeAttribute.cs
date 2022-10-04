using System.ComponentModel.DataAnnotations;

namespace EnterpriseSystem.Service
{
    // Validation attribute for Salary property of Employee class
    // Salary cannot be a negative
    public class NonNegativeAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is decimal salaryValue)
            {
                if (salaryValue >= 0)
                {
                    return true;
                }
                else
                {
                    ErrorMessage = "This value cannot be negative";
                }
            }

            return false;
        }
    }
}
