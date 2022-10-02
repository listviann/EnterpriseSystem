using System.Collections.Specialized;
using System.Configuration;

namespace EnterpriseSystem.Service
{
    public class Config
    {
        private readonly static NameValueCollection appSettings = ConfigurationManager.AppSettings;
        public readonly static string FILEPATH = appSettings["FileName"]!;
        public readonly static string EMPLOYEE_NOT_FOUND = appSettings["EmployeeNotFoundException"]!;
        public readonly static string PRODUCT_NOT_FOUND = appSettings["ProductNotFoundException"]!;
    }
}
