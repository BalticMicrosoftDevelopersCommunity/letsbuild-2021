using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebReg.Services;

namespace WebReg.Configuration
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPersonService, PersonService>();

            return services;
        }
    }
}
