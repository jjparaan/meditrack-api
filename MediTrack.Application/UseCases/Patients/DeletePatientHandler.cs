using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Application.Interfaces.Services;

namespace MediTrack.Application.UseCases.Patients
{
    public class DeletePatientHandler
    {
        private readonly IPatientService _patientService;

        public DeletePatientHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public async Task<bool> HandleAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "Cannot delete patient data without id");
            }
            // Validate the id here if necessary
            bool result = await _patientService.DeleteAsync(id);
            return result;
        }
    }
}
