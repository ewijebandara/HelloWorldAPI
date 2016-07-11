using HelloWorldBaseAPI.Entity;

namespace HelloWorldConsoleApp.Services
{
    /// <summary>
    /// Client side contract to call to api service 
    /// </summary>
   public interface IHelloWorldAPIService
    {
        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <returns>MessageEntity.</returns>
       MessageEntity GetMessage();
    }
}
