using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Application.DTOs.Patient;
using MediTrack.Application.Interfaces.Services;

namespace MediTrack.Application.UseCases.Patients
{
    public class CreatePatientHandler
    {
        private readonly IPatientService _patientService;

        public CreatePatientHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public async Task<Guid> HandleAsync(CreatePatientDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "Patient data cannot be null");
            }

            // Validate the DTO here if necessary
            var patientId = await _patientService.CreateAysnc(dto);
            return patientId;
        }
    }
}
