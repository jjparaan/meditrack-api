using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Services;

namespace MediTrack.Application.UseCases.Patients
{
    public class GetAllPatientHandler
    {
        private readonly IPatientService _patientService;

        public GetAllPatientHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public async Task<List<PatientDto>> HandleAsync()
        {
            // Fetch all patients asynchronously
            var patients = await _patientService.GetAllAsync();
            return patients;
        }
    }
}
