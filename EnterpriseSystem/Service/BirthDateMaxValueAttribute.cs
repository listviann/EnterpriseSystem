using System.ComponentModel.DataAnnotations;

namespace EnterpriseSystem.Service
{
    // Validation attribute for BirthDate property of Employee class
    // employee's birth date cannot be equal to or greater than current date time
    public class BirthDateMaxValueAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime birthDateValue)
            {
                if (birthDateValue.Date <= DateTime.UtcNow.Date)
                {
                    return true;
                }
                else
                {
                    ErrorMessage = "Incorrect birth date value";
                }
            }

            return false;
        }
    }
}
