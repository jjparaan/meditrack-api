using MediTrack.Application.Common.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace MediTrack.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            return services;
        }
    }
}
