using System;
using System.Threading;

namespace loggerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logFilePath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\log.txt"); // Define log file path
            Logger logger = new Logger(logFilePath);


            Console.WriteLine("A simple logger application."); // Display application purpose
            logger.LogInfo("Application started."); // Log application start

            try
            {
                Console.Write("Enter your favorite number: ");
                int favNum = int.Parse(Console.ReadLine()); // Get user input

                Console.Write("Enter your second favorite number: ");
                int secFavNum = int.Parse(Console.ReadLine()); // Get second user input

                int res = favNum / secFavNum; // Perform division
                Console.WriteLine($"The result of {favNum} divided by {secFavNum} is {res}.");
                logger.LogInfo($"Divion was successfull: {favNum} / {secFavNum} = {res}"); // Log successful division
            }
            catch (Exception ex)
            {
                logger.LogError($"unexpected error occurred: {ex.Message}"); // Log any errors
                Console.WriteLine("Logs written to log.txt");
            }
            logger.LogInfo("Application ended.");
            Console.WriteLine("\nLogs written to log.txt");
        }
    }
}


