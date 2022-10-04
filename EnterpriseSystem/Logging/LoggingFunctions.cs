using System.Diagnostics;

namespace EnterpriseSystem.Logging
{
    // static class which contains methods to subscribe to events for logger methods
    public static class LoggingFunctions
    {
        public static void LogMessage(string message, string filepath)
        {
            try
            {
                Console.WriteLine(message);
                Debug.WriteLine(message);
                File.AppendAllText(filepath, message + "\n");
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }
    }
}
