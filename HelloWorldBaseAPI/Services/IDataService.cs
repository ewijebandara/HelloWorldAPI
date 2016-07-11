using HelloWorldBaseAPI.Entity;

namespace HelloWorldBaseAPI.Services
{
    /// <summary>
    /// Contract for data service
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// Gets the message data.
        /// </summary>
        /// <returns>MessageEntity.</returns>
        MessageEntity GetMessageData();
    }
}
