using System.Diagnostics;

namespace EnterpriseSystem.Logging
{
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
