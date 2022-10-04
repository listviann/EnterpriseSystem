using System.ComponentModel.DataAnnotations;

namespace EnterpriseSystem.Service
{
    // Common interface that contains methods for model validation
    public interface IValidationHelper<T> where T : class
    {
        bool IsValidObject(T entity);
        bool IsValidInput(object input, string propName);
        void NotifyValidationFailed(List<ValidationResult> results);
    }
}
