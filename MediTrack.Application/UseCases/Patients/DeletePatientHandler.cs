using MediTrack.Application.Interfaces.Repositories;

namespace MediTrack.Application.UseCases.Patients
{
    public class DeletePatientHandler
    {
        private readonly IPatientRepository _patientRepository;

        public DeletePatientHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<bool> HandleAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "Cannot delete patient data without id");
            }
            // Validate the id here if necessary
            bool result = await _patientRepository.DeleteAsync(id);
            return result;
        }
    }
}
