using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Repositories;

namespace MediTrack.Application.UseCases.Patients
{
    public class GetPatientByIdHandler
    {
        private readonly IPatientRepository _patientRepository;

        public GetPatientByIdHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<PatientDto> HandleAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "Cannot retrieve patient data withoud id");
            }

            PatientDto patient = await _patientRepository.GetByIdAsync(id);
            return patient;
        }
    }
}
