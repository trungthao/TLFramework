using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TL.Domain.Constants;

namespace TL.Api.Extensions
{
    public static class AddConfigExtension
    {
        public static IServiceCollection AddConfigs(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection(AppSettings.ConfigName));

            return services;
        }
    }
}