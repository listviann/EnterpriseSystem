using System.Collections.Specialized;
using System.Configuration;

namespace EnterpriseSystem.Service
{
    // config class that reads the project configuration file which is contaied in App.config file
    public class Config
    {
        private readonly static NameValueCollection appSettings = ConfigurationManager.AppSettings;
        public readonly static string FILEPATH = appSettings["FileName"]!;
        public readonly static string EMPLOYEE_NOT_FOUND = appSettings["EmployeeNotFoundException"]!;
        public readonly static string PRODUCT_NOT_FOUND = appSettings["ProductNotFoundException"]!;
        public readonly static string ABOUT_INFO = appSettings["AboutInfo"]!;
    }
}
