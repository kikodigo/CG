using CG.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CG.Core.IoC
{
    public static class CoreServiceCollection
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddSingleton<ILoginServices, LoginServices>();
        }
    }
}
