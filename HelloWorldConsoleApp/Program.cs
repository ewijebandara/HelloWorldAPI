using HelloWorldBaseAPI;
using HelloWorldConsoleApp.Services;
using Ninject;
using System;
using System.Reflection;

namespace HelloWorldConsoleApp
{
    /// <summary>
    /// Main console application runner
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            //Ninject mechanism to inject dependencies
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var appSettings = kernel.Get<IAppSettings>();
            var helloWorldAPIService = kernel.Get<IHelloWorldAPIService>();

            //Call client service to get the greeting message
            var message = helloWorldAPIService.GetMessage();
            if (message != null)
            {
                Console.WriteLine(message.Body);
            }
            else
            {
                Console.WriteLine("No Message to display");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
