using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace loggerApplication
{
    // Define log levels
    public enum LogLevel
    {
        INFO,
        WARNING,
        ERROR
    }
    public class Logger
    {
        private readonly string logFilePath;
        private readonly LogLevel logLevel;

        public Logger(string logFilePath, LogLevel minLevel = LogLevel.INFO)
        {
            string directory = Path.GetDirectoryName(logFilePath) ?? ""; // Get directory from log file path or empty string
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(logFilePath); // Get file name without extension
            string extension = Path.GetExtension(logFilePath); // Get file extension

            string timestamp = $"{fileNameWithoutExtension}_{DateTime.Now:yyyyMMdd}{extension}"; // Create timestamped file name
            logFilePath = Path.Combine(directory, timestamp); // Combine directory and new file name

            this.logFilePath = logFilePath; // Initialize log file path
            this.logLevel = minLevel;
        }

        public void Log(string message, LogLevel level = LogLevel.INFO)
        {
            // Check if the log level meets the minimum requirement
            if (level < logLevel)
                return;

            string LogEntry = $"{DateTime.Now:yyyy-MM-dd} [{level}] {message}"; // Format log entry
            File.AppendAllText(logFilePath, LogEntry + Environment.NewLine); // Write log entry to file

            switch (level)
            {
                case LogLevel.INFO:
                    {
                        // Set console color for INFO level
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(LogEntry);
                        Console.ResetColor();
                        break;
                    }

                case LogLevel.WARNING:
                    {
                        // Set console color for WARNING level
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(LogEntry);
                        Console.ResetColor();
                        break;
                    }

                case LogLevel.ERROR:
                    {
                        // Set console color for ERROR level
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(LogEntry);
                        Console.ResetColor();
                        break;
                    }
            }
        }
        public void LogError(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void LogWarning(string message)
        {
            Log(message, LogLevel.WARNING);
        }

        public void LogInfo(string message)
        {
            Log(message, LogLevel.INFO);
        }


    }
}
