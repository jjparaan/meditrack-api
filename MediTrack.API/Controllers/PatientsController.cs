using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.UseCases.Patients;
using Microsoft.AspNetCore.Mvc;

namespace MediTrack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly GetAllPatientHandler _getAllPatientHandler;
        private readonly GetPatientByIdHandler _getPatientByIdHandler;
        private readonly CreatePatientHandler _createPatientHandler;
        private readonly UpdatePatientHandler _updatePatientHandler;
        private readonly DeletePatientHandler _deletePatientHandler;

        public PatientsController(
            GetAllPatientHandler getAllPatientHandler, 
            GetPatientByIdHandler getPatientByIdHandler,
            CreatePatientHandler createPatientHandler, 
            UpdatePatientHandler updatePatientHandler, 
            DeletePatientHandler deletePatientHandler
            )
        {
            _getAllPatientHandler = getAllPatientHandler;
            _getPatientByIdHandler = getPatientByIdHandler;
            _createPatientHandler = createPatientHandler;
            _updatePatientHandler = updatePatientHandler;
            _deletePatientHandler = deletePatientHandler;
        }

        [HttpGet]
        [Route("/getall")]
        public async Task<IActionResult> GetAllPatients()
        {
            List<PatientDto> patients = await _getAllPatientHandler.HandleAsync();
            return Ok(patients);
        }
    }
}
