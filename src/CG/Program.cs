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

            Application.Run(new frm_login());
        }
    }
}