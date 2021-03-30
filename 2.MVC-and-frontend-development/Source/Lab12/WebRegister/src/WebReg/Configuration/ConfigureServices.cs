using Microsoft.Extensions.DependencyInjection;
using WebReg.Automapper;
using WebReg.Services;

namespace WebReg.Configuration
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => {
                cfg.AddProfile<PersonProfile>();
            });
            return services;
        }
    }
}
