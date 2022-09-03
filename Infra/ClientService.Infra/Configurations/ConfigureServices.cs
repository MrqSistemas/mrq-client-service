using Microsoft.Extensions.DependencyInjection;
using ClientService.Application.Applications;
using ClientService.Business.Clients;
using ClientService.Domain.Adapters;
using ClientService.Domain.Business;
using ClientService.Repository.Clients;

namespace ClientService.Infra.Configurations
{
    public class ConfigureServices
    {
        public static void AddApplications(IServiceCollection services)
        {
            services.AddScoped<IClientApplication, ClientApplication>();
        }

        public static void AddBusiness(IServiceCollection services)
        {
            services.AddScoped<IClientBusiness, ClientBusiness>();
        }

        public static void AddAdapters(IServiceCollection services)
        {
            services.AddScoped<IClientAdapter, ClientRepositorySqlServer>();
        }
    }
}
