using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBaseAPI.Loggers
{
    /// <summary>
    /// Logging contract implementation.
    /// </summary>
    /// <seealso cref="HelloWorldBaseAPI.Loggers.ILogger" />
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
