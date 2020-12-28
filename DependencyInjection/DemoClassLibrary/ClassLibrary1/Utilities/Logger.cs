using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibraryDemo.Utilities
{
    public class Logger : ILogger
    {

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
