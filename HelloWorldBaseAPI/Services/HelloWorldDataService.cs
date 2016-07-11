using HelloWorldBaseAPI.DataProviders;
using HelloWorldBaseAPI.Entity;
using System;

namespace HelloWorldBaseAPI.Services
{
    /// <summary>
    /// Implementation for data service contract
    /// </summary>
    /// <seealso cref="HelloWorldBaseAPI.Services.IDataService" />
    public class HelloWorldDataService : IDataService
    {
        private readonly IDataProvider dataProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorldDataService"/> class.
        /// </summary>
        /// <param name="dataProvider">The data provider.</param>
        public HelloWorldDataService(IDataProvider dataProvider)    
        { 
            this.dataProvider = dataProvider;
        }

        /// <summary>
        /// Gets the message data.
        /// </summary>
        /// <returns>MessageEntity.</returns>
        public MessageEntity GetMessageData()        {
            string messageBody = dataProvider.GetData();
            MessageEntity message = new MessageEntity { Body = messageBody };

            return message;
        }
    }
}
