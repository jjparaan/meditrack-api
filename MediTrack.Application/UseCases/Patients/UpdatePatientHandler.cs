using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Services;

namespace MediTrack.Application.UseCases.Patients
{
    public class UpdatePatientHandler
    {
        private readonly IPatientService _patientService;

        public UpdatePatientHandler(IPatientService patientService)
        {
            _patientService = patientService;
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
            bool result = await _patientService.UpdateAsync(id, dto);
            return result;
        }
    }
}
