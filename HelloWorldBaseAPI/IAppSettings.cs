
namespace HelloWorldBaseAPI
{
    /// <summary>
    /// Contract for retrieve app setting details
    /// </summary>
    public interface IAppSettings
    {
        /// <summary>
        /// Gets the specified app setting.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.String.</returns>
        string Get(string name);
    }
}
