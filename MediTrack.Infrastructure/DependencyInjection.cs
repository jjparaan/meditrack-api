using MediTrack.Application.Interfaces.Repositories;
using MediTrack.Application.UseCases.Patients;
using MediTrack.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MediTrack.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<GetAllPatientHandler>();
            services.AddScoped<GetPatientByIdHandler>();
            services.AddScoped<CreatePatientHandler>();
            services.AddScoped<UpdatePatientHandler>();
            services.AddScoped<DeletePatientHandler>();

            return services;
        }
    }
}
