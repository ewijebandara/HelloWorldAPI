
using HelloWorldBaseAPI;
using HelloWorldBaseAPI.Entity;
using System;
using System.Net.Http;
namespace HelloWorldConsoleApp.Services
{
    /// <summary>
    ///  Client side implementation to call to api service .
    /// </summary>
    /// <seealso cref="HelloWorldConsoleApp.Services.IHelloWorldAPIService" />
    public class HelloWorldAPIService : IHelloWorldAPIService
    {
        /// <summary>
        /// The application settings
        /// </summary>
        private readonly IAppSettings appSettings;
        /// <summary>
        /// The client
        /// </summary>
        static HttpClient client = new HttpClient();
        /// <summary>
        /// The controller name
        /// </summary>
        private const string ControllerName = "message";

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorldAPIService"/> class.
        /// </summary>
        /// <param name="appSettings">The application settings.</param>
        public HelloWorldAPIService(IAppSettings appSettings)
        {
            this.appSettings = appSettings;
        }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <returns>MessageEntity.</returns>
        public MessageEntity GetMessage()       
        {
            MessageEntity message = null;
            try
            {
                var baseUrl = this.appSettings.Get(AppSettingsKeys.HelloWorldApiUrlKey);
                var fullUrl = baseUrl + ControllerName;

                HttpResponseMessage resp = client.GetAsync(fullUrl).Result;
                //This method throws an exception if the HTTP response status is an error code.  
                resp.EnsureSuccessStatusCode();
                 message = resp.Content.ReadAsAsync<MessageEntity>().Result;
            }
            catch(Exception exception)
            {
                message = new MessageEntity { Body = exception.Message };
            }
           
            return message;
            
        }
    }
}
