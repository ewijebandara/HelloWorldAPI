using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBaseAPI
{
    /// <summary>
    ///Implementation for retrieve app setting details
    /// </summary>
    /// <seealso cref="HelloWorldBaseAPI.IAppSettings" />
    public class ConfigAppSettings : IAppSettings
    {
        /// <summary>
        /// Gets the specified app setting.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>System.String.</returns>
        public string Get(string name)
        {
            return ConfigurationManager.AppSettings.Get(name);
        }
    }
}
