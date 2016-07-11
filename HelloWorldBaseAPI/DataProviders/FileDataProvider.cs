using System;
using System.IO;
using System.Web.Hosting;

namespace HelloWorldBaseAPI.DataProviders
{
    public class FileDataProvider : IDataProvider
    {
        private readonly IAppSettings appSettings;

        #region FileDataProvider methods

        public FileDataProvider(IAppSettings appSettings)
        {
            this.appSettings = appSettings;
        }

        public string GetData()
        {
            var filePath = this.appSettings.Get(AppSettingsKeys.DataFileLocationKey);

            if (string.IsNullOrEmpty(filePath))
            {
            }

            var message = ReadFile(filePath);

            return message;
        }

        #endregion       

        #region Helper Methods

        private string ReadFile(string filePath)
        {
            string fileContents = string.Empty;

            var serverPath = HostingEnvironment.MapPath("~/" + filePath);

            // Read the contents of the file
            try
            {
                using (var reader = new StreamReader(serverPath))
                {
                    fileContents = reader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return fileContents;
        }

        #endregion       
    }
}
