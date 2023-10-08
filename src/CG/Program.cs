using CG.Core.IoC;
using CG.Core.Services.Interfaces;
using CG.IoC;
using CG.Repository.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace CG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            string connectionString = Environment.GetEnvironmentVariable("csSecretGest");

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddRepositories(connectionString);
            serviceCollection.AddCoreServices();
            serviceCollection.AddControllersServices();

            var loginServices = serviceCollection.BuildServiceProvider().GetRequiredService<ILoginServices>();

            Application.Run(new frm_login(loginServices));
        }
    }
}