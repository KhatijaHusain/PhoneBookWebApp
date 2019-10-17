using CibDigiTechWebApp.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Bootstrapper
{
    public class ServiceBootstrapper
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPhoneBookService, PhoneBookService>();
            services.AddTransient<IEntryBookService, EntryBookService>();
            services.AddTransient<IDirectoryService, DirectoryService>();
        }
    }
}
