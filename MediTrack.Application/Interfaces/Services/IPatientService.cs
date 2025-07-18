using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Application.DTOs.Patients;

namespace MediTrack.Application.Interfaces.Services
{
    public interface IPatientService
    {
        Task<List<PatientDto>> GetAllAsync();
        Task<PatientDto> GetByIdAsync(Guid id);
        Task<Guid> CreateAysnc(CreatePatientDto dto);
        Task<bool> UpdateAsync(Guid id, CreatePatientDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
