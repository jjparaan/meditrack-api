using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Repositories;

namespace MediTrack.Application.UseCases.Patients
{
    public class CreatePatientHandler
    {
        private readonly IPatientRepository _patientRepository;

        public CreatePatientHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<Guid> HandleAsync(CreatePatientDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "Patient data cannot be null");
            }

            // Validate the DTO here if necessary
            var patientId = await _patientRepository.CreateAysnc(dto);
            return patientId;
        }
    }
}
