using EnterpriseSystem.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseSystem.Models
{
    public static class LoggerViewModel
    {
        private static readonly Logger _logger = Logger.Instance;

        public static void LogInformation()
        {
            _logger.Notify += LogMessageDebug;
        }

        private static void LogMessageDebug(string message, string filepath)
        {
            Debug.WriteLine(message);
            File.AppendAllText(filepath, message + "\n");
        }
    }
}
