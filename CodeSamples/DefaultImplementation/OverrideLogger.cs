using System;

namespace DefaultImplementation
{
    public class OverrideLogger : ILogger
    {
        public void Log(LogLevel level, string message)
        {
            Console.WriteLine($"Level - {level:F}: {message}");
        }

        public void LogException(Exception ex)
        {
            Console.WriteLine($"Level - {LogLevel.Error}: {ex.Message}");
        }
    }
}
