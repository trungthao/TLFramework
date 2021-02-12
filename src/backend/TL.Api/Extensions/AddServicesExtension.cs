using Microsoft.Extensions.DependencyInjection;
using TL.Domain.Services;
using TL.Services;

namespace TL.Api.Extensions
{
    public static class AddServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();
            
            return services;
        }
    }
}