using CG.Controllers.Interface;
using CG.Core.IoC;
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

            // Configurar o cont�iner de servi�os
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddRepositories(connectionString);
            serviceCollection.AddCoreServices();
            serviceCollection.AddControllersServices();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolva o servi�o de login
            var loginController = serviceProvider.GetRequiredService<ILoginControllers>();

            // Crie uma inst�ncia de frm_login com inje��o de depend�ncia
            var mainForm = new frm_login(loginController);

            Application.Run(mainForm);

        }
    }
}