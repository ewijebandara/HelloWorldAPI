
namespace HelloWorldBaseAPI.Loggers
{
    /// <summary>
    /// Contract for logging to differnt loggers
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="message">The message.</param>
        void LogMessage(string message);
    }
}
