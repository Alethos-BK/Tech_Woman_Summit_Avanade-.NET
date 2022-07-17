using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppDio.Core.Mapster
{
    public static class MapsterExtensions
    {
        public static IServiceCollection AddCustomMapster(this IServiceCollection services, Assembly assembly)
        {
            var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;

            typeAdapterConfig.Scan(assembly);
            var mapperConfig = new Mapper(typeAdapterConfig);

            services.AddSingleton<IMapper>(mapperConfig);

            return services;
        }
    }
}
