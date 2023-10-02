using CG.Controllers;
using CG.Controllers.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CG.IoC
{
    public static  class ControllerServiceCollection
    {
        public static void AddControllersServices(this IServiceCollection services)
        {
            services.AddSingleton<ILoginControllers, LoginControllers>();
        }
    }
}
