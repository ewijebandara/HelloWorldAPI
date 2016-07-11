using HelloWorldBaseAPI.Entity;
using HelloWorldBaseAPI.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    /// <summary>
    /// Main message retrieve api
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class MessageController : ApiController
    {
        /// <summary>
        /// The data service
        /// </summary>
        private readonly IDataService dataService;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageController"/> class.
        /// </summary>
        /// <param name="dataService">The data service.</param>
        public MessageController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        // GET api/values
        /// <summary>
        /// Gets message data.
        /// </summary>
        /// <returns>MessageEntity.</returns>
        
        public MessageEntity Get()
        {
            MessageEntity message = dataService.GetMessageData();
            return message;
        }

    }
}
