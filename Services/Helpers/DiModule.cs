using DataAccess;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Helpers
{
    public class DiModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {

            services.AddDbContext<DataContext>(x => x.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HomeRentDb;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddTransient<IPropertyRepository, PropertyRepository>();
          


            return services;
        }
    }
}
