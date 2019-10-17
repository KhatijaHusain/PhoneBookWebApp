using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Bootstrapper
{
    public static class DependencyInjectionRegister
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();

            DataAccessBootstrapper.Configure(services);

            ServiceBootstrapper.Configure(services, configuration);
        }
    }
}
