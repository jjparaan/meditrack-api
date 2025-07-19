using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Repositories;

namespace MediTrack.Application.UseCases.Patients
{
    public class UpdatePatientHandler
    {
        private readonly IPatientRepository _patientRepository;

        public UpdatePatientHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<bool> HandleAsync(Guid id, CreatePatientDto dto)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "Cannot update patient data without id");
            }
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "Patient data cannot be null");
            }

            // Validate the DTO here if necessary
            bool result = await _patientRepository.UpdateAsync(id, dto);
            return result;
        }
    }
}
