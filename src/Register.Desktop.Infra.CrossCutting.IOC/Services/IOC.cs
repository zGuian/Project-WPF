using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Register.Desktop.Application.Handlers;
using Register.Desktop.Application.Interfaces;
using Register.Desktop.Application.Services;
using Register.Desktop.Infra.Data.AppDataContext;
using Register.Desktop.Infra.Data.Interfaces;
using Register.Desktop.Infra.Data.Repository;

namespace Register.Desktop.Infra.CrossCutting.IOC.Services
{
    public static class IOC
    {
        public static IServiceCollection AddServicesInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.DependencyInjection(configuration);
            return services;
        }

        private static IServiceCollection DependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            #region Application
            services.AddScoped<IServicesEquipment, ServicesEquipment>();
            services.AddTransient<IHandlerEquipment, HandlerEquipment>();
            #endregion Application

            #region Repository
            services.AddScoped<IRepositoryEquipment, RepositoryEquipment>();
            #endregion Repository

            #region DataBase
            services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(
                configuration.GetConnectionString("DbContext")));
            #endregion DataBase

            return services;
        }
    }
}