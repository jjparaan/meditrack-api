using MediTrack.Application.Interfaces.Services;
using MediTrack.Application.UseCases.Patients;
using MediTrack.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MediTrack.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<GetAllPatientHandler>();
            services.AddScoped<GetPatientByIdHandler>();
            services.AddScoped<CreatePatientHandler>();
            services.AddScoped<UpdatePatientHandler>();
            services.AddScoped<DeletePatientHandler>();

            return services;
        }
    }
}
