using Microsoft.Extensions.DependencyInjection;
using TL.Domain.Repositories;
using TL.Repositories;

namespace TL.Api.Extensions
{
    public static class AddRepositoriesExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITestRepository, TestRepository>();

            return services;
        }
    }
}