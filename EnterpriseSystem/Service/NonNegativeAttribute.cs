using System.ComponentModel.DataAnnotations;

namespace EnterpriseSystem.Service
{
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
