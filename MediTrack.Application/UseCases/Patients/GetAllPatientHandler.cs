using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Repositories;

namespace MediTrack.Application.UseCases.Patients
{
    public class GetAllPatientHandler
    {
        private readonly IPatientRepository _patientRepository;

        public GetAllPatientHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<List<PatientDto>> HandleAsync()
        {
            // Fetch all patients asynchronously
            var patients = await _patientRepository.GetAllAsync();
            return patients;
        }
    }
}
