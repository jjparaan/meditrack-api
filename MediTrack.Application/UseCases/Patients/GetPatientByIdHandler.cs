using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Services;

namespace MediTrack.Application.UseCases.Patients
{
    public class GetPatientByIdHandler
    {
        private readonly IPatientService _patientService;

        public GetPatientByIdHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public async Task<PatientDto> HandleAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id), "Cannot retrieve patient data withoud id");
            }

            PatientDto patient = await _patientService.GetByIdAsync(id);
            return patient;
        }
    }
}
