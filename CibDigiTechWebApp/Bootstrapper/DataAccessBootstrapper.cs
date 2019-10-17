using CibDigiTechWebApp.DbContexts;
using CibDigiTechWebApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibDigiTechWebApp.Bootstrapper
{
    public class DataAccessBootstrapper
    {
        public static void Configure(IServiceCollection services)
        {
            string connectionString = "Username=postgres;Password=Password1;Host=localhost;Port=5432;Database=CibDigiTech;Pooling=true;";
                
                services.AddDbContext<PhoneBookDBContext>(
                options =>
                    options.UseNpgsql(connectionString ?? throw new InvalidOperationException("Incorrect or missing database connection string")));
            services.AddTransient<IPhoneBookRepo, PhoneBookRepo>();
            services.AddTransient<IEntryBookRepo, EntryBookRepo>();
        }
    }
}
