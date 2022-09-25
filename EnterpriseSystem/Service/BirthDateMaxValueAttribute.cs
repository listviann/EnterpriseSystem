using System.ComponentModel.DataAnnotations;

namespace EnterpriseSystem.Service
{
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
