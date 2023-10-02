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

            // Configurar o contêiner de serviços
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddRepositories(connectionString);
            serviceCollection.AddCoreServices();
            serviceCollection.AddControllersServices();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolva o serviço de login
            var loginController = serviceProvider.GetRequiredService<ILoginControllers>();

            // Crie uma instância de frm_login com injeção de dependência
            var mainForm = new frm_login(loginController);

            Application.Run(mainForm);

        }
    }
}