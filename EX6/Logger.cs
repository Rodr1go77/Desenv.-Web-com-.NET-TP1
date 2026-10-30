using System;

namespace EX6
{
    internal class Logger
    {

        public static void LogToConsole(string message)
        {
            Console.WriteLine($"Log to Console: {message}");
        }

        public static void LogToFile(string message)
        {
            // Simulate logging to a file
            Console.WriteLine($"Log to File: {message}");
        }

        public static void LogToDatabase(string message)
        {
            // Simulate logging to a database
            Console.WriteLine($"Log to Database: {message}");
        }


    }
}
