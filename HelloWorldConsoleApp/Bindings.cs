using HelloWorldBaseAPI;
using HelloWorldConsoleApp.Services;
using Ninject.Modules;

namespace HelloWorldConsoleApp
{
    /// <summary>
    /// Ninject module binder 
    /// </summary>
    /// <seealso cref="Ninject.Modules.NinjectModule" />
   public class Bindings : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
       public override void Load()
       {
           // configure IAppSettings and IHelloWorldAPIService to resolve to their specified concrete implementations
           Bind<IAppSettings>().To<ConfigAppSettings>();
           Bind<IHelloWorldAPIService>().To<HelloWorldAPIService>();
       }
    }
}
