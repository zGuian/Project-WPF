using Microsoft.Extensions.DependencyInjection;
using Register.Desktop.Domain.Handlers;

namespace Register.Desktop.Infra.CrossCutting.IOC
{
    public static class IOC
    {
        public static IServiceCollection ServicesInjection(this IServiceCollection services)
        {
            services.DependencyInjection();
            return services;
        }

        private static IServiceCollection DependencyInjection(this IServiceCollection services)
        {
            #region Mediator
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(RegisterEquipmentEntryHandler).Assembly));
            #endregion Mediator

            #region Repository
            
            #endregion Repository

            return services;
        }
    }
}