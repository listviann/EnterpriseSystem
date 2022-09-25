using System.Diagnostics;

namespace EnterpriseSystem.Logging
{
    public static class LoggingFunctions
    {
        public static void LogMessage(string message, string filepath)
        {
            Console.WriteLine(message);
            Debug.WriteLine(message);
            File.AppendAllText(filepath, message + "\n");
        }
    }
}
